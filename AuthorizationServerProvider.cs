using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Infrastructure;
using Microsoft.Owin.Security.OAuth;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using SmartAdminMvc.Utility;
using Microsoft.AspNet.Identity;
using AspNet.Identity.MySQL;

namespace SmartAdminMvc
{
	
		public class AuthorizationServerProvider : OAuthAuthorizationServerProvider
		{

		public AuthorizationServerProvider() : this(new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationDbContext()))) { }

		public AuthorizationServerProvider(UserManager<ApplicationUser> userManager)
		{
			_manager = userManager;
		}
		// TODO: This should be moved to the constructor of the controller in combination with a DependencyResolver setup
		// NOTE: You can use NuGet to find a strategy for the various IoC packages out there (i.e. StructureMap.MVC5)
		public UserManager<ApplicationUser> _manager { get; private set; }

		public override async Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
			{
				context.Validated(); // 
			}

			public override Task GrantRefreshToken(OAuthGrantRefreshTokenContext context)
			{

				// Change authentication ticket for refresh token requests  
				var newIdentity = new ClaimsIdentity(context.Ticket.Identity);
				newIdentity.AddClaim(new Claim("newClaim", "newValue"));

				var newTicket = new AuthenticationTicket(newIdentity, context.Ticket.Properties);
				context.Validated(newTicket);

				return Task.FromResult<object>(null);

			}


			public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
			{

				var identity = new ClaimsIdentity(context.Options.AuthenticationType);
				var user = await _manager.FindByEmailAsync(context.UserName);
				if (user != null)
				{
					//Authenticate the user credentials
					if (await _manager.FindAsync(user.UserName, context.Password) != null)
					{
						identity.AddClaim(new Claim(ClaimTypes.Role, user.RoleId.ToString()));
						identity.AddClaim(new Claim("username", context.UserName));
						identity.AddClaim(new Claim(ClaimTypes.Name, context.UserName));
						context.Validated(identity);
					}
					else
					{
						context.SetError("invalid_grant", "Provided username and password is incorrect");
						return;
					}
				}
				else
				{
					context.SetError("invalid_grant", "Provided username and password is incorrect");
					string a = "bit bucket";
					return;
				}


		}
		}

		public class RefreshTokenProvider : IAuthenticationTokenProvider
		{
			private static ConcurrentDictionary<string, AuthenticationTicket> _refreshTokens = new ConcurrentDictionary<string, AuthenticationTicket>();

			public async Task CreateAsync(AuthenticationTokenCreateContext context)
			{

				var guid = Guid.NewGuid().ToString();

				// copy all properties and set the desired lifetime of refresh token  
				var refreshTokenProperties = new AuthenticationProperties(context.Ticket.Properties.Dictionary)
				{
					IssuedUtc = context.Ticket.Properties.IssuedUtc,
					ExpiresUtc = DateTime.UtcNow.AddMinutes(60)
				};

				var refreshTokenTicket = new AuthenticationTicket(context.Ticket.Identity, refreshTokenProperties);

				_refreshTokens.TryAdd(guid, refreshTokenTicket);

				// consider storing only the hash of the handle  
				context.SetToken(guid);
			}


			public void Create(AuthenticationTokenCreateContext context)
			{
				throw new NotImplementedException();
			}

			public void Receive(AuthenticationTokenReceiveContext context)
			{
				throw new NotImplementedException();
			}

			public async Task ReceiveAsync(AuthenticationTokenReceiveContext context)
			{
				// context.DeserializeTicket(context.Token);
				AuthenticationTicket ticket;
				string header = context.OwinContext.Request.Headers["Authorization"];

				if (_refreshTokens.TryRemove(context.Token, out ticket))
				{
					context.SetTicket(ticket);
				}
			}
		}
	
}
