#region Using
//New Line 123
using AspNet.Identity.MySQL;
using MySql.Data.MySqlClient;
using SmartAdminMvc.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Web.Mvc;
using SmartAdminMvc.Common;
using SmartAdminMvc.App_Code;
using System.IO.Compression;
using System.Collections;
using System.Resources;
using System.Web.UI.WebControls;
using System.Web.Script.Serialization;
using System.Linq;
using System.Globalization;
using Ionic.Zip;
using Newtonsoft.Json;
using System.Text;
using SmartAdminMvc.App_Helpers;
using Microsoft.AspNet.Identity;
using Novacode;
using NPOI.HSSF.UserModel;
using NPOI.XSSF.UserModel;
using NPOI.SS.UserModel;
using SmartAdminMvc.Utility;
using System.Collections.Specialized;
using System.Text.RegularExpressions;
using SmartAdminMvc.EntityModel;
using System.Data.Entity;

#endregion

namespace SmartAdminMvc.Controllers
{
    [Authorize]
    public class AppViewsController : Controller
    {
        public AppViewsController() : this(new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationDbContext()))) { }

        public AppViewsController(UserManager<ApplicationUser> userManager)
        {
            _manager = userManager;
        }

        public UserManager<ApplicationUser> _manager { get; private set; }
        MySQLDatabase _database = new MySQLDatabase("loginConn");
        string uploadkey = ConfigurationManager.AppSettings["uploadkey"].ToString();
        string serverurl = ConfigurationManager.AppSettings["serverurl"].ToString();
        private MySqlConnection con;
        int _count = 0, _rep = 0, _countTM = 0, _total = 0, _val = 0;
        string _fname = string.Empty;
        string fileName = string.Empty;
		
		
	
        prudleConfigureTaskEntities Configtask = new prudleConfigureTaskEntities();

        public ActionResult Blog()
        {
            if (!loginUser.isLogin())
            {
                return RedirectToAction("Login", "Account");
            }

            return View();
        }

        public void connection()
        {
            string constr = ConfigurationManager.ConnectionStrings["loginConn"].ToString();
            con = new MySqlConnection(constr);
        }

        [System.Web.Services.WebMethod]
        public string GetNotifications()
        {
            DataTable table = new DataTable();
            DataTable fdata = new DataTable();

            try
            {
                connectionString.connectionOpen();
                int roleID = loginUser.getRoleID();

                if (roleID == 4)
                {
                    string strQry = @"SELECT n.id as id, n.nid, n.fid, n.oid, n.tid, n.`status`, n.ndate, n.keyId, nm.id as id1, nm.Notificationmsg,n.querydescription,f.ChildFileName FROM tbl_notifications n inner join tbl_notificationmaster nm on n.nid = nm.id inner join tbl_filedetails f on f.id=n.fid where n.tid = " + loginUser.getUserID() + " and  n.status = 1 order by  n.status desc, n.id desc;";
                    MySqlDataAdapter da = new MySqlDataAdapter(strQry, connectionString.getConnection());
                    da.Fill(table);

                    strQry = @"SELECT n.id as id, n.nid, n.fid, n.oid, n.tid, n.`status`, n.ndate, n.keyId, nm.id as id1, nm.Notificationmsg,n.querydescription,f.ChildFileName FROM tbl_notifications n inner join tbl_notificationmaster nm on n.nid = nm.id inner join tbl_filedetails f on f.id=n.fid where n.tid = " + loginUser.getUserID() + " and  n.status = 0 order by n.id desc limit 10;";
                    da = new MySqlDataAdapter(strQry, connectionString.getConnection());
                    da.Fill(fdata);
                }
                else
                {
                    string strQry = @"SELECT n.id as id, n.nid, n.fid, n.oid, n.tid, n.`status`, n.ndate, n.keyId, nm.id as id1, nm.Notificationmsg,n.querydescription,f.ChildFileName FROM tbl_notifications n inner join tbl_notificationmaster nm on n.nid = nm.id inner join tbl_filedetails f on f.id=n.fid where n.tid = " + loginUser.getUserID() + " and  n.status = 1 order by  n.status desc, n.id desc;";
                    MySqlDataAdapter da = new MySqlDataAdapter(strQry, connectionString.getConnection());
                    da.Fill(table);

                    strQry = @"SELECT n.id as id, n.nid, n.fid, n.oid, n.tid, n.`status`, n.ndate, n.keyId, nm.id as id1, nm.Notificationmsg,n.querydescription,f.ChildFileName FROM tbl_notifications n inner join tbl_notificationmaster nm on n.nid = nm.id inner join tbl_filedetails f on f.id=n.fid where n.tid = " + loginUser.getUserID() + " and  n.status = 0  order by  n.id desc limit 10;";
                    da = new MySqlDataAdapter(strQry, connectionString.getConnection());
                    da.Fill(fdata);
                }

                table.Merge(fdata);
		string testCommit = "Hello ! Welcome";
                connectionString.connectionClose();
            }
            catch (Exception ex)
            {
                Logger.AddLog("AppViewsController", "GetNotifications", ex.Message);
            }

            return DataTableToJSONWithJavaScriptSerializerDT(table);
        }

        public string UpdateNotificationstatus(string nid)
        {
            try
            {
	        var testCode = "This is Test String";
		var testCode2 = "This is Test String 2";
                connectionString.connectionOpen();

                string strUpdate = "UPDATE tbl_notifications SET status = 0 WHERE id = " + Convert.ToInt16(nid) + ";";
                MySqlCommand com = new MySqlCommand(strUpdate, connectionString.getConnection());
                com.ExecuteNonQuery();

                connectionString.connectionClose();
            }
            catch (Exception ex)
            {
                Logger.AddLog("AppViewsController", "UpdateNotificationstatus", ex.Message);
            }

            return nid;
        }

        public string GetNotificationsCount()
        {
            string countNt = "0";
            DataTable fdata = new DataTable();
		var testCode2 = "This is Demo String ignore2";
            try
            {
                connectionString.connectionOpen();

                string strQry = "SELECT COUNT(id) FROM tbl_notifications WHERE status = 1 and tid = " + loginUser.getUserID() + ";";
                MySqlDataAdapter da = new MySqlDataAdapter(strQry, connectionString.getConnection());
                da.Fill(fdata);

                if (fdata.Rows.Count > 0)
                    countNt = fdata.Rows[0][0].ToString();

                connectionString.connectionClose();
            }
            catch (Exception ex)
            {
                Logger.AddLog("AppViewsController", "GetNotificationsCount", ex.Message);
            }

            return countNt;
        }

        public ActionResult ProjectDetails()
        {
            if (!loginUser.isLogin())
            {
                return RedirectToAction("Login", "Account");
            }

            return View();
        }

        public ActionResult AssignProject()
        {
            if (!loginUser.isLogin())
            {
                return RedirectToAction("Login", "Account");
            }

            DataSet ds = new DataSet();
            List<SelectListItem> obj = new List<SelectListItem>();

            try
            {
                ds = getProjectInfobyOwner(loginUser.userDetail());
                obj.Add(new SelectListItem { Text = "-Select Project-", Value = "0" });
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    obj.Add(new SelectListItem
                    {
                        Text = ds.Tables[0].Rows[i][1].ToString(),
                        Value = ds.Tables[0].Rows[i][0].ToString()
                    });
                }
                ViewBag.LoadProject = obj;
            }
            catch (Exception ex)
            {
                Logger.AddLog("AppViewsController", "AssignProject", ex.Message);
            }

            return View();
        }

        [HttpPost]
        public ActionResult AssignProject(AssignProjectModel model)
        {
            if (!loginUser.isLogin())
            {
                return RedirectToAction("Login", "Account");
            }
	     string NewtestString = "This is New TestString - Prasoon 18-5/1201";
            DataSet ds = new DataSet();
            List<SelectListItem> obj = new List<SelectListItem>();
            mailsend objMail = new mailsend();
            bool _mailres = false;

            try
            {
                model.ownerid = loginUser.getUserID();
                model.status = "N";
                bool _res = assignprojecttouser(model);

                if (_res == true)
                {
                    _mailres = objMail.mailSend(model.email, model.email, "1", model.ownerid.ToString(), Convert.ToInt32(assignpId));
                    if (_mailres == true)
                        ViewBag.Message = true;
                    else
                        ViewBag.Message = false;
                }
                else
                    ViewBag.Message = false;

                ds = getProjectInfobyOwner(loginUser.userDetail());
                obj.Add(new SelectListItem { Text = "-Select Project-", Value = "0" });
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    obj.Add(new SelectListItem { Text = ds.Tables[0].Rows[i][1].ToString(), Value = ds.Tables[0].Rows[i][0].ToString() });
                }
                ViewBag.LoadProject = obj;
            }
            catch (Exception ex)
            {
                Logger.AddLog("AppViewsController", "AssignProject", ex.Message);
            }

            return View();
        }

        public string getLangEnglishName(string lid)
        {
            string lcode = string.Empty;

            try
            {
                string[] values = lid.Split(',');
                connectionString.connectionOpen();

                for (int i = 0; i < values.Length; i++)
                {
                    DataTable dt = new DataTable();
                    string strQry = "SELECT LangId FROM tbl_langmaster WHERE LangEnglishName = '" + values[i].Trim() + "';";
                    MySqlDataAdapter da = new MySqlDataAdapter(strQry, connectionString.getConnection());
                    da.Fill(dt);
                    if (i == values.Length - 1)
                    {
                        lcode = lcode + dt.Rows[0][0].ToString();
                    }
                    else
                    {
                        lcode = lcode + dt.Rows[0][0].ToString() + ", ";
                    }
                }

                connectionString.connectionClose();
            }
            catch (Exception ex)
            {
                Logger.AddLog("AppViewsController", "getLangEnglishName", ex.Message);
            }

            return lcode;
        }

        public string ExcelFileDetails(string fname)
        {
            DataTable dt = new DataTable();

            var fileName = "";
            string strMsg = string.Empty;

            int ownerid = loginUser.getUserID();
            try
            {
                foreach (string file in Request.Files)
                {
                    var fileContent = Request.Files[file];
                    if (fileContent != null && fileContent.ContentLength > 0)
                    {
                        var stream = fileContent.InputStream;
                        var xlfileName = fileContent.FileName.ToString(); // and optionally write the file to disk
                        var path = Path.Combine(Server.MapPath("~/appviews/ExcelData"), xlfileName);
                        fileName = Server.MapPath("../appviews/ExcelData/") + xlfileName;
                        using (var fileStream = System.IO.File.Create(path))
                        {
                            stream.CopyTo(fileStream);
                        }
                    }
                }

                string fileExt = Path.GetExtension(Request.Files[0].FileName.ToString());

                ISheet sheet;

                if (fileExt.ToLower() == ".xls")
                {
                    HSSFWorkbook hssfwb; //Use the NPOI Excel xlsx object
                    using (FileStream file = new FileStream(fileName, FileMode.Open, FileAccess.Read))
                    {
                        hssfwb = new HSSFWorkbook(file);
                    }
                    sheet = hssfwb.GetSheet("sheet1"); //Assign the sheet
                }
                else
                {
                    XSSFWorkbook hssfwb; //Use the NPOI Excel xlsx object
                    using (FileStream file = new FileStream(fileName, FileMode.Open, FileAccess.Read))
                    {
                        hssfwb = new XSSFWorkbook(file);
                    }
                    sheet = hssfwb.GetSheet("sheet1"); //Assign the sheet
                }

                dt = getDTforVendorExcel();

                for (int row = 1; row <= sheet.LastRowNum + 1; row++)
                {
                    string idvendor = string.Empty;
                    string vendortype = string.Empty;
                    string vstatus = string.Empty;
                    string inareason = string.Empty;
                    string vname = string.Empty;
                    string address = string.Empty;
                    string contno = string.Empty;
                    string email = string.Empty;
                    string nationality = string.Empty;
                    string vpcard = string.Empty;
                    string mtounge = string.Empty;
                    string source = string.Empty;
                    string target = string.Empty;
                    string currency = string.Empty;
                    string services = string.Empty;
                    string rate = string.Empty;
                    string domain = string.Empty;
                    string specialization = string.Empty;
                    string qualification = string.Empty;
                    string backg = string.Empty;
                    string nda = string.Empty;
                    string ndadate = string.Empty;
                    string msa = string.Empty;
                    string msadate = string.Empty;
                    string cv = string.Empty;
                    string cvdate = string.Empty;
                    string sfile = string.Empty;
                    string sdate = string.Empty;
                    string uby = string.Empty;
                    string udate = string.Empty;
                    string utime = string.Empty;
                    if (row == sheet.LastRowNum + 1)
                    {

                    }
                    else
                    {
                        try
                        {
                            idvendor = sheet.GetRow(row).GetCell(0).ToString().Trim();
                            vendortype = sheet.GetRow(row).GetCell(1).ToString().Trim();
                            vstatus = sheet.GetRow(row).GetCell(2).ToString().Trim();
                            inareason = sheet.GetRow(row).GetCell(3).ToString().Trim();
                            vname = sheet.GetRow(row).GetCell(4).ToString().Trim();
                            address = sheet.GetRow(row).GetCell(5).ToString().Trim();
                            contno = sheet.GetRow(row).GetCell(6).ToString().Trim();
                            email = sheet.GetRow(row).GetCell(7).ToString().Trim();
                            nationality = sheet.GetRow(row).GetCell(8).ToString().Trim();
                            vpcard = sheet.GetRow(row).GetCell(9).ToString().Trim();
                            mtounge = sheet.GetRow(row).GetCell(10).ToString().Trim();
                            source = getLangEnglishName(sheet.GetRow(row).GetCell(11).ToString().Trim());
                            target = getLangEnglishName(sheet.GetRow(row).GetCell(12).ToString().Trim());
                            currency = sheet.GetRow(row).GetCell(13).ToString().Trim();
                            services = sheet.GetRow(row).GetCell(14).ToString().Trim();
                            rate = sheet.GetRow(row).GetCell(15).ToString().Trim();
                            domain = sheet.GetRow(row).GetCell(16).ToString().Trim();
                            specialization = sheet.GetRow(row).GetCell(17).ToString().Trim();
                            qualification = sheet.GetRow(row).GetCell(18).ToString().Trim();
                            backg = sheet.GetRow(row).GetCell(19).ToString().Trim();
                            nda = sheet.GetRow(row).GetCell(20).ToString().Trim();
                            ndadate = sheet.GetRow(row).GetCell(21).ToString().Trim();
                            msa = sheet.GetRow(row).GetCell(22).ToString().Trim();
                            msadate = sheet.GetRow(row).GetCell(23).ToString().Trim();
                            cv = sheet.GetRow(row).GetCell(24).ToString().Trim();
                            cvdate = sheet.GetRow(row).GetCell(25).ToString().Trim();
                            sfile = sheet.GetRow(row).GetCell(26).ToString().Trim();
                            sdate = sheet.GetRow(row).GetCell(27).ToString().Trim();
                            uby = sheet.GetRow(row).GetCell(28).ToString().Trim();
                            udate = sheet.GetRow(row).GetCell(29).ToString().Trim();
                            utime = sheet.GetRow(row).GetCell(30).ToString().Trim();

                            dt.Rows.Add(idvendor, vendortype, vstatus, inareason, vname, address, contno, email, nationality, vpcard, mtounge, source, target, currency, services, rate, domain, specialization, qualification, backg, nda, ndadate, msa, msadate, cv, cvdate, sfile, sdate, uby, udate, utime);

                            connectionString.connectionOpen();

                            StringBuilder sCommand = new StringBuilder("INSERT INTO `tbl_vendordetails` (`vendortype`,`vstatus`,`inareason`,`vname`,`address`,`contno`,`email`,`nationality`,`vpcard`,`mtounge`,`source`,`target`,`currency`,`services`,`rate`,`domain`,`specialization`,`qualification`,`backg`,`nda`,`ndadate`,`msa`,`msadate`,`cv`,`cvdate`,`sfile`,`sdate`,`uby`,`udate`,`utime`) VALUES");
                            sCommand.Append(string.Format("('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}','{18}','{19}','{20}','{21}','{22}','{23}','{24}','{25}','{26}','{27}','{28}','{29}')", vendortype, vstatus, inareason, vname, address, contno, email, nationality, vpcard, mtounge, source, target, currency, services, rate, domain, specialization, qualification, backg, nda, ndadate, msa, msadate, cv, cvdate, sfile, sdate, uby, udate, utime));

                            MySqlCommand command = new MySqlCommand(sCommand.ToString(), connectionString.getConnection());
                            command.ExecuteNonQuery();
                            long _uid = command.LastInsertedId;
                            string strInsert = string.Empty;
                            if (vendortype.ToLower() == "agency")
                            {
                                strInsert = "INSERT INTO tbl_agencydetails (AgencyName, EmailId, idvendor) VALUES ('" + email + "','" + email + "'," + Convert.ToInt16(_uid.ToString()) + ")";
                                MySqlCommand com = new MySqlCommand(strInsert, connectionString.getConnection());
                                com.ExecuteNonQuery();
                            }
                            else
                            {
                                strInsert = "INSERT INTO tbl_translatordetails (TransltrName, EmailId, idvendor) VALUES ('" + email + "','" + email + "'," + Convert.ToInt16(_uid.ToString()) + ")";
                                MySqlCommand com = new MySqlCommand(strInsert, connectionString.getConnection());
                                com.ExecuteNonQuery();
                                long _tid = com.LastInsertedId;
                                insertTranslatorLanMap(_tid.ToString(), source, target);
                            }

                            connectionString.connectionClose();
                        }
                        catch (Exception ex)
                        {
                            Logger.AddLog("AppViewsController", "ExcelFileDetails", ex.Message);

                            connectionString.connectionOpen();

                            MySqlCommand com3 = new MySqlCommand("insert into tbl_translatordetails (name1,name2) values ('ujj','" + ex.Message + "')", connectionString.getConnection());
                            com3.ExecuteNonQuery();

                            connectionString.connectionClose();

                            idvendor = "0";
                            vendortype = "";
                            vstatus = "";
                            inareason = "";
                            vname = "";
                            address = "";
                            contno = "";
                            email = "";
                            nationality = "";
                            vpcard = "";
                            mtounge = "";
                            source = "";
                            target = "";
                            currency = "";
                            services = "";
                            rate = "";
                            domain = "";
                            specialization = "";
                            qualification = "";
                            backg = "";
                            nda = "";
                            ndadate = "";
                            msa = "";
                            msadate = "";
                            cv = "";
                            cvdate = "";
                            sfile = "";
                            sdate = "";
                            uby = "";
                            udate = "";
                            utime = "";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.AddLog("AppViewsController", "ExcelFileDetails", ex.Message);
            }

            NotificationHandler nh = new App_Helpers.NotificationHandler();
            try
            {
                for (int h = 0; h < dt.Rows.Count; h++)
                {
                    nh.Invite("byOther", dt.Rows[h]["email"].ToString(), loginUser.userDetail().UserName, dt.Rows[h]["vendortype"].ToString(), dt.Rows[h]["vname"].ToString());
                }
            }
            catch (Exception ex)
            {
                Logger.AddLog("AppViewsController", "ExcelFileDetails", ex.Message);
            }

            return strMsg;
        }

        public ActionResult AddVendor()
        {
            connectionString.connectionOpen();


            DataSet ds1 = new DataSet();
            DataSet ds2 = new DataSet();

            IdentityUser user = System.Web.HttpContext.Current.Session.GetDataFromSession<IdentityUser>("User");

            string str1 = "SELECT ag.AgencyName, ag.EmailId FROM tbl_agencydetails ag LEFT JOIN tbl_assignagencytranslator aat ON aat.AgencyID = ag.AgencyId WHERE aat.UserID = '" + user.UserId + "';";
            string str2 = "SELECT t.TransltrName, t.EmailId, lm.LangISOName srcLang, lm1.LangISOName trgLang FROM tbl_translatordetails t LEFT JOIN tbl_transltrlangmap tm ON tm.TransltrId = t.TransltrId LEFT JOIN tbl_transltrlangmap tm1 ON tm1.TransltrId = t.TransltrId LEFT JOIN tbl_langmaster lm ON lm.LangId = tm.LangId LEFT JOIN tbl_langmaster lm1 ON lm1.LangId = tm1.LangId LEFT JOIN tbl_assignagencytranslator aat ON aat.TranslatorID = t.TransltrId WHERE aat.UserID = '" + user.UserId + "' AND (tm.Type = 'S' AND tm1.Type = 'T');";

            MySqlDataAdapter da1 = new MySqlDataAdapter(str1, connectionString.getConnection());
            da1.Fill(ds1);
            ViewBag.List1 = ds1.Tables[0];

            MySqlDataAdapter da2 = new MySqlDataAdapter(str2, connectionString.getConnection());
            da2.Fill(ds2);
            ViewBag.List2 = ds2.Tables[0];

            return View();
        }
        public ActionResult AddVendors()
        {
            return View();
        }
        private void insertTranslatorLanMap(string translatorId, string sourceLanguage, string targetLanguages)
        {
            connectionString.connectionOpen();

            StringBuilder sCommand = new StringBuilder("INSERT INTO `tbl_transltrlangmap` (`TransltrId`, `LangId`, `Type`) VALUES ");
            List<string> Rows = new List<string>();
            Rows.Add(string.Format("('{0}','{1}','{2}')", Convert.ToInt16(translatorId), Convert.ToInt16(sourceLanguage), MySqlHelper.EscapeString("S")));

            foreach (string targetLanguage in targetLanguages.Split(','))
                Rows.Add(string.Format("('{0}','{1}','{2}')", Convert.ToInt16(translatorId), Convert.ToInt16(targetLanguage), MySqlHelper.EscapeString("T")));

            sCommand.Append(string.Join(",", Rows));
            sCommand.Append(";");

            using (MySqlCommand myCmd = new MySqlCommand(sCommand.ToString(), connectionString.getConnection()))
            {
                myCmd.CommandType = CommandType.Text;
                myCmd.ExecuteNonQuery();
            }
            connectionString.connectionClose();
        }

        private DataTable getDTforVendorExcel()
        {
            DataTable table = new DataTable();
            table.Columns.Add("idvendor", typeof(string));
            table.Columns.Add("vendortype", typeof(string));
            table.Columns.Add("vstatus", typeof(string));
            table.Columns.Add("inareason", typeof(string));
            table.Columns.Add("vname", typeof(string));
            table.Columns.Add("address", typeof(string));
            table.Columns.Add("contno", typeof(string));
            table.Columns.Add("email", typeof(string));
            table.Columns.Add("nationality", typeof(string));
            table.Columns.Add("vpcard", typeof(string));
            table.Columns.Add("mtounge", typeof(string));
            table.Columns.Add("source", typeof(string));
            table.Columns.Add("target", typeof(string));
            table.Columns.Add("currency", typeof(string));
            table.Columns.Add("services", typeof(string));
            table.Columns.Add("rate", typeof(string));
            table.Columns.Add("domain", typeof(string));
            table.Columns.Add("specialization", typeof(string));
            table.Columns.Add("qualification", typeof(string));
            table.Columns.Add("backg", typeof(string));
            table.Columns.Add("nda", typeof(string));
            table.Columns.Add("ndadate", typeof(string));
            table.Columns.Add("msa", typeof(string));
            table.Columns.Add("msadate", typeof(string));
            table.Columns.Add("cv", typeof(string));
            table.Columns.Add("cvdate", typeof(string));
            table.Columns.Add("sfile", typeof(string));
            table.Columns.Add("sdate", typeof(string));
            table.Columns.Add("uby", typeof(string));
            table.Columns.Add("udate", typeof(string));
            table.Columns.Add("utime", typeof(string));
            return table;
        }

        public ActionResult Projects()
        {
            ProjectViewModel model = new ProjectViewModel();
            try
            {
                DataSet ds = new DataSet();
                IdentityUser user = System.Web.HttpContext.Current.Session.GetDataFromSession<IdentityUser>("User");
                if (user == null)
                {
                    return RedirectToAction("Login", "Account");
                }
                connectionString.connectionOpen();


                try
                {
                    List<ProjectModel> projects = new List<ProjectModel>();
                    model.Projects = projects;
                    AccountController getrole = new AccountController();
                    int rlid = getrole.getRole(user.UserId);
                    string commandText;
                    string str;
                    string agencydetails = string.Empty;

                    if (rlid == 4)
                    {
                        DataTable dt = new DataTable();
                        string getowner = "select * from `tbl_assignproject` where assignto = '" + user.UserId + "'";

                        MySqlDataAdapter da = new MySqlDataAdapter(getowner, connectionString.getConnection());

                        da.Fill(dt);

                        commandText = "SELECT p.ProjectId, p.OwnerId, p.ProjectName, DATE_FORMAT(p.StartDate, '%d-%m-%Y') as 'SubmitionDate', DATE_FORMAT(ExpectedDate,'%d-%m-%Y %H:%i') as 'ExpectedDate', p.FilePath, l.LangId , l.LangISOName, p.Status, p.ProjectNotes,p.ProjectPriority from `tbl_project` p, `tbl_langmaster` l WHERE `OwnerId` = " + dt.Rows[0][1] + " and l.LangId = p.LangId Order by p.ProjectId desc;";
                        str = "select distinct m.ProjectId, m.LangId, l.LangISOName from tbl_projectlangmap m join tbl_project p on p.ProjectId = m.ProjectId join tbl_langmaster l on l.LangId = m.LangId where p.OwnerId = " + dt.Rows[0][1] + ";";
                    }
                    else
                    {
                        commandText = "SELECT p.ProjectId, p.OwnerId, p.ProjectName, DATE_FORMAT(p.StartDate, '%d-%m-%Y') as 'SubmitionDate', DATE_FORMAT(ExpectedDate,'%d-%m-%Y %H:%i') as 'ExpectedDate', p.FilePath, l.LangId , l.LangISOName, p.Status, DATE_FORMAT(p.SubmitionDate, '%d-%m-%Y') as 'CreatedDate', p.ProjectNotes,p.ProjectPriority from `tbl_project` p, `tbl_langmaster` l WHERE `OwnerId` = " + user.UserId + " and l.LangId = p.LangId and p.ProjectName !='undefined' Order by p.ProjectId desc;";
                        str = "select distinct m.ProjectId, m.LangId, l.LangISOName from tbl_projectlangmap m join tbl_project p on p.ProjectId = m.ProjectId join tbl_langmaster l on l.LangId = m.LangId where p.OwnerId = " + user.UserId + ";";
                        //agencydetails = "select distinct p.ProjectId,ad.AgencyId aid, ad.EmailId eid, ad.AgencyName agname  from tbl_project p inner join tbl_filedetails fd on p.ProjectId = fd.ProjectId inner join tbl_projectassignment pa on pa.FileId = fd.Id inner join tbl_agencydetails ad on pa.AgencyId = ad.AgencyId where ad.UserId != 'null' and p.OwnerId = " + user.UserId + ";";
                        agencydetails = "SELECT p.ProjectId, a.AgencyId aid, GROUP_CONCAT(CONCAT(pt.Task, ':', a.AgencyName) separator '|') agname FROM tbl_project p LEFT JOIN tbl_projecttask pt ON pt.ProjectID = p.ProjectId LEFT JOIN tbl_agencydetails a ON a.AgencyId = pt.AssignAgency WHERE p.OwnerId = " + user.UserId + " GROUP BY p.ProjectId;";
                    }

                    Dictionary<string, object> parameters = new Dictionary<string, object>() { };
                    Dictionary<int, ProjectModel> tempList = new Dictionary<int, ProjectModel>();

                    var rows = _database.Query(commandText, parameters);

                    foreach (var row in rows)
                    {
                        var projInfo = new ProjectModel
                        {
                            FileId = GetFileId(int.Parse(row["ProjectId"])),
                            ownername = user.UserId.ToString(),
                            ProjectId = int.Parse(row["ProjectId"]),
                            ProjectName = row["ProjectName"],
                            StartData = row["SubmitionDate"],
                            Source = row["LangISOName"],
                            FileName = row["FilePath"],
                            Status = row["Status"],
                            ExpDate = row["ExpectedDate"],
                            CreatedDate = row["CreatedDate"],
                            SourceID = row["LangId"],
                            TargetLanguage = new Dictionary<string, string>(),
                            AgencyName = new Dictionary<string, string>(),
                            progress = totalprogress(row["ProjectId"]),
                            Cost = GetCostByPid(row["ProjectId"]),
                            ProjectNotes = row["ProjectNotes"],
                            ProjectPriority = row["ProjectPriority"]
                        };
                        projects.Add(projInfo);
                        tempList.Add(projInfo.ProjectId, projInfo);
                    }

                    var rows1 = _database.Query(str, parameters);
                    foreach (var row in rows1)
                    {
                        int projid = int.Parse(row["ProjectId"]);

                        if (tempList.ContainsKey(projid))
                        {
                            ProjectModel proj = tempList[projid];

                            proj.TargetLanguage.Add(row["LangId"].ToString(), row["LangISOName"]);
                        }
                    }

                    var agencyRows = _database.Query(agencydetails, parameters);

                    foreach (var row in agencyRows)
                    {
                        int projid = int.Parse(row["ProjectId"]);

                        if (tempList.ContainsKey(projid))
                        {
                            ProjectModel proj = tempList[projid];

                            proj.AgencyName.Add(row["aid"].ToString(), row["agname"]);
                        }
                    }
                }
                catch (Exception ex)
                {
                    return View(model);
                }
                finally
                {
                    connectionString.connectionClose();
                }
                return View(model);
            }
            catch
            {
                return View(model);
            }
        }

        public string GetCostByPid(string pid)
        {
            DataTable dt = new DataTable();

            string qry_costsummary = "select RepeatedWord, repeatedWordUnitCost, TranslationRequired, newWordUnitCost from tbl_filedetails where ProjectId = " + pid;
            connectionString.connectionOpen();
            MySqlDataAdapter da = new MySqlDataAdapter(qry_costsummary, connectionString.getConnection());

            da.Fill(dt);
            connectionString.connectionClose();
            dt.TableName = "data";

            double cost = 0.0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                try
                {
                    cost = cost + Convert.ToInt32(dt.Rows[i]["RepeatedWord"].ToString()) * Convert.ToDouble(dt.Rows[i]["repeatedWordUnitCost"].ToString()) + Convert.ToInt32(dt.Rows[i]["TranslationRequired"].ToString()) * Convert.ToDouble(dt.Rows[i]["newWordUnitCost"].ToString());
                }
                catch
                {
                    cost = cost + 0.0;
                }
            }

            return cost.ToString();
        }

        public string projDetails(string pid)
        {
            IdentityUser user = System.Web.HttpContext.Current.Session.GetDataFromSession<IdentityUser>("User");
            string strDetails = string.Empty;
            try
            {
                DataTable dt = new DataTable();
                string lcode = string.Empty;
                string strQry = string.Empty;
                strQry = @"SELECT ProjectId,OwnerId,ProjectName,Description,LangId,SubmitionDate,ExpectedDate,CurrencyId,FilePath,Status,StartDate,ProjectTask,ProjectCategory,AllowFileDownload,PO,ProjectNotes FROM tbl_project p inner join tbl_filedetails fd on p.ProjectId = fd.ProjectId
                            where p.ProjectId =" + pid + ";";
                connectionString.connectionOpen();

                MySqlDataAdapter da = new MySqlDataAdapter(strQry, connectionString.getConnection());
                da.Fill(dt);
                connectionString.connectionClose();
                DataTable table = new DataTable();
                table.Columns.Add("ProjectName", typeof(string));
                table.Columns.Add("ProjectEDate", typeof(string));
                table.Columns.Add("ProjectSDate", typeof(string));
                table.Columns.Add("createdDate", typeof(string));
                table.Columns.Add("ProjectTask", typeof(string));
                table.Columns.Add("ProjectCategory", typeof(string));
                table.Columns.Add("Destination", typeof(string));
                table.Columns.Add("Source", typeof(string));
                table.Columns.Add("Status", typeof(string));
                table.Columns.Add("uid", typeof(string));
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (i == dt.Rows.Count - 1)
                    {
                        lcode = lcode + dt.Rows[i][26].ToString();
                    }
                    else
                    {
                        lcode = lcode + dt.Rows[i][26].ToString() + ", ";
                    }
                }
                string uid = string.Empty;
                if (Convert.ToInt16(dt.Rows[0][26].ToString()) == user.UserId)
                    uid = "true";
                else uid = "false";
                App_Helpers.NotificationHandler nh = new App_Helpers.NotificationHandler();
                AccountController getrole = new AccountController();
                int rlid = getrole.getRole(user.UserId);
                if (rlid.ToString() == "4")
                {
                    table.Rows.Add(dt.Rows[0][2].ToString(), dt.Rows[0][6].ToString(), dt.Rows[0][10].ToString(), dt.Rows[0][5].ToString(), dt.Rows[0][11].ToString(), dt.Rows[0][12].ToString(), nh.getlanguagecode(lcode), nh.getlanguagecode(dt.Rows[0][25].ToString()), dt.Rows[0][22].ToString(), uid);
                }
                else
                {
                    table.Rows.Add(dt.Rows[0][2].ToString(), dt.Rows[0][6].ToString(), dt.Rows[0][10].ToString(), dt.Rows[0][5].ToString(), dt.Rows[0][11].ToString(), dt.Rows[0][12].ToString(), nh.getlanguagecode(lcode), nh.getlanguagecode(dt.Rows[0][25].ToString()), dt.Rows[0][9].ToString(), uid);
                }


                strDetails = DataTableToJSONWithJavaScriptSerializerDT(table);
            }
            catch
            {
                strDetails = "0";
            }
            return strDetails;
        }

        //GET: /appviews/Add Agency
        [HttpGet]
        public ActionResult addagency()
        {
            AddAgency model = new AddAgency();

            IdentityUser user = System.Web.HttpContext.Current.Session.GetDataFromSession<IdentityUser>("User");
            if (user == null)
            {
                return RedirectToAction("Login", "Account");
            }

            DataSet ds = new DataSet();
            ds = getAgency(user);

            List<SelectListItem> obj = new List<SelectListItem>();
            int j = 1;
            obj.Add(new SelectListItem { Text = "-Select Agency-", Value = "0" });
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {

                obj.Add(new SelectListItem { Text = ds.Tables[0].Rows[i][1].ToString(), Value = ds.Tables[0].Rows[i][0].ToString() });
                j++;

            }
            ++j;
            obj.Add(new SelectListItem { Text = "Add New Agency", Value = "Add New Agency" });

            ViewBag.LoadAgency = obj;

            return View();
        }

        //GET
        public string getEmail(string aid)
        {
            string _value = string.Empty;
            DataSet ds = new DataSet();
            connectionString.connectionOpen();

            try
            {
                string str = "Select `EmailId` from `tbl_agencydetails` where `AgencyId` = " + Convert.ToInt16(aid) + ";";
                MySqlDataAdapter da = new MySqlDataAdapter(str, connectionString.getConnection());
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    _value = ds.Tables[0].Rows[0][0].ToString();
                }
                else
                {
                    return null;
                }
            }
            catch
            {
                return null;
            }
            finally
            {
                connectionString.connectionClose();
            }
            return _value;
        }

        //GET
        public ActionResult AddTranslator()
        {
            return View();
        }

        //GET: /appviews/Add Agency/Translator
        [HttpGet]
        public string ListOfTranslator(string ddlid)
        {
            AddAgency model = new AddAgency();

            IdentityUser user = System.Web.HttpContext.Current.Session.GetDataFromSession<IdentityUser>("User");
            List<ListItem> ddl = new List<ListItem>();
            DataSet ds = new DataSet();
            string query = string.Empty;
            if (ddlid == "Agency")
            {
                query = "SELECT `AgencyName`,`AgencyId` from tbl_agencydetails where `UserId` IS NOT NULL and `AgencyName` IS NOT NULL and `AgencyName` !='';";

            }
            else if (ddlid == "Translator")
            {
                query = "SELECT tbl_translatordetails.TransltrId,tbl_translatordetails.TransltrName from `tbl_translatordetails` where `UserId` IS NOT NULL and `TransltrName` IS NOT NULL and `TransltrName` !='';";
            }
            else
            {

            }
            string constr = ConfigurationManager.ConnectionStrings["loginConn"].ToString();

            if (query == string.Empty)
                return "";

            int getlastid = 0;
            using (MySqlConnection conn = new MySqlConnection(constr))
            {
                using (MySqlCommand cmd = new MySqlCommand(query))
                {

                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    conn.Open();
                    using (MySqlDataReader sdr = cmd.ExecuteReader())
                    {
                        if (ddlid == "Translator")
                            while (sdr.Read())
                            {
                                ddl.Add(new ListItem
                                {
                                    Value = sdr["TransltrId"].ToString(),
                                    Text = sdr["TransltrName"].ToString()
                                });
                                getlastid = Convert.ToInt16(sdr["TransltrId"].ToString()) + 1;
                            }

                        else
                            while (sdr.Read())
                            {
                                ddl.Add(new ListItem
                                {
                                    Value = sdr["AgencyId"].ToString(),
                                    Text = sdr["AgencyName"].ToString()
                                });
                                getlastid = Convert.ToInt16(sdr["AgencyId"].ToString()) + 1;
                            }
                    }
                    conn.Close();
                    ddl.Add(new ListItem
                    {
                        Value = getlastid.ToString(),
                        Text = "Others"
                    });
                    System.Web.Script.Serialization.JavaScriptSerializer jSearializer =
                    new System.Web.Script.Serialization.JavaScriptSerializer();
                    return jSearializer.Serialize(ddl);
                }
            }

        }

        [HttpGet]
        public string TranslatorList(string ddlid)
        {
            AddAgency model = new AddAgency();

            IdentityUser user = System.Web.HttpContext.Current.Session.GetDataFromSession<IdentityUser>("User");
            List<ListItem> ddl = new List<ListItem>();
            DataSet ds = new DataSet();
            string query = string.Empty;
            if (ddlid == "Agency")
            {
                query = "SELECT ag.AgencyId, ag.AgencyName FROM tbl_agencydetails ag INNER JOIN tbl_assignagencytranslator att ON att.AgencyID = ag.AgencyId WHERE att.UserID = '" + user.UserId + "';";
            }
            else if (ddlid == "Translator")
            {
                query = "SELECT t.TransltrId, t.TransltrName FROM tbl_translatordetails t INNER JOIN tbl_assignagencytranslator att ON att.TranslatorID = t.TransltrId WHERE att.UserID = '" + user.UserId + "';";
            }
            else if (ddlid == "Set Own cost")
            {
                query = "Select `UserId`, `UserName` from `tbl_users` where `RoleId` = 2";
            }
            string constr = ConfigurationManager.ConnectionStrings["loginConn"].ToString();

            if (query == string.Empty)
                return "";

            using (MySqlConnection conn = new MySqlConnection(constr))
            {
                using (MySqlCommand cmd = new MySqlCommand(query))
                {

                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    conn.Open();
                    using (MySqlDataReader sdr = cmd.ExecuteReader())
                    {
                        if (ddlid == "Translator")
                            while (sdr.Read())
                            {
                                ddl.Add(new ListItem
                                {
                                    Value = sdr["TransltrId"].ToString(),
                                    Text = sdr["TransltrName"].ToString()
                                });

                            }
                        else if (ddlid == "Set Own cost")
                        {
                            while (sdr.Read())
                            {
                                ddl.Add(new ListItem
                                {
                                    Value = sdr["UserId"].ToString(),
                                    Text = sdr["UserName"].ToString()
                                });

                            }
                        }
                        else
                            while (sdr.Read())
                            {
                                ddl.Add(new ListItem
                                {
                                    Value = sdr["AgencyId"].ToString(),
                                    Text = sdr["AgencyName"].ToString()
                                });

                            }
                    }
                    conn.Close();
                    System.Web.Script.Serialization.JavaScriptSerializer jSearializer =
                    new System.Web.Script.Serialization.JavaScriptSerializer();
                    return jSearializer.Serialize(ddl);
                }
            }

        }

        // GET: /appviews/profile
        public new ActionResult Profile()
        {
            IdentityUser user = System.Web.HttpContext.Current.Session.GetDataFromSession<IdentityUser>("User");
            if (user == null)
            {
                return RedirectToAction("Login", "Account");
            }
            ProfileModel model = new ProfileModel();
            Dictionary<string, object> parameters = new Dictionary<string, object>() { };
            AccountController getrole = new AccountController();
            int rlid = getrole.getRole(user.UserId);
            if (rlid == 2)
            {
                string str = "Select `UserId`,`OrgName`, `Address`, `City`, `Country`, `ContactNo`, `EmailId` from `tbl_organizationdetails` where `UserId`='" + user.UserId + "';";
                var rows = _database.Query(str, parameters);
                if (rows.Count > 0)
                {
                    if (rows[0]["UserId"] == "")
                    {
                        model.Id = Convert.ToInt16(null);
                    }
                    else
                    {
                        model.Id = int.Parse(rows[0]["UserId"]);
                    }
                    if (rows[0]["OrgName"] == null)
                    {
                        model.Name = "";
                    }
                    else
                    {
                        model.Name = rows[0]["OrgName"].ToString();
                    }
                    if (rows[0]["ContactNo"] == null)
                    {
                        model.PhoneNo = "";
                    }
                    else
                    {
                        model.PhoneNo = rows[0]["ContactNo"].ToString();
                    }
                    if (rows[0]["Address"] == null)
                    {
                        model.Address = "";
                    }
                    else
                    {
                        model.Address = rows[0]["Address"].ToString();
                    }
                    if (rows[0]["City"] == null)
                    {
                        model.City = "";
                    }
                    else
                    {
                        model.City = rows[0]["City"].ToString();
                    }
                    if (rows[0]["Country"] == null)
                    {
                        model.Country = "";
                    }
                    else
                    {
                        model.Country = rows[0]["Country"].ToString();
                    }
                }
            }
            if (rlid == 4)
            {
                string str = "Select `UserId`,`TransltrName`, `Address`, `City`, `Country`, `ContactNo`, `Designation`, `Description` from `tbl_translatordetails` where EmailId='" + user.Email + "';";
                var rows = _database.Query(str, parameters);
                if (rows.Count > 0)
                {
                    if (rows[0]["UserId"] == "")
                    {
                        model.Id = Convert.ToInt16(null);
                    }
                    else
                    {
                        model.Id = int.Parse(rows[0]["UserId"]);
                    }
                    if (rows[0]["TransltrName"] == null)
                    {
                        model.Name = "";
                    }
                    else
                    {
                        model.Name = rows[0]["TransltrName"].ToString();
                    }
                    if (rows[0]["Address"] == null)
                    {
                        model.Address = "";
                    }
                    else
                    {
                        model.Address = rows[0]["Address"].ToString();
                    }
                    if (rows[0]["City"] == null)
                    {
                        model.City = "";
                    }
                    else
                    {
                        model.City = rows[0]["City"].ToString();
                    }
                    if (rows[0]["Country"] == null)
                    {
                        model.Country = "";
                    }
                    else
                    {
                        model.Country = rows[0]["Country"].ToString();
                    }
                    if (rows[0]["Designation"] == null)
                    {
                        model.Designation = "";
                    }
                    else
                    {
                        model.Designation = rows[0]["Designation"].ToString();
                    }
                    if (rows[0]["ContactNo"] == null)
                    {
                        model.PhoneNo = "";
                    }
                    else
                    {
                        model.PhoneNo = rows[0]["ContactNo"].ToString();
                    }
                    //if (rows[0]["EmailId"] == null)
                    //{
                    //    model.Email = "";
                    //}
                    //else
                    //{
                    //    model.Email = rows[0]["EmailId"].ToString();
                    //}
                    if (rows[0]["Description"] == null)
                    {
                        model.Description = "";
                    }
                    else
                    {
                        model.Description = rows[0]["Description"].ToString();
                    }
                }
            }
            if (rlid == 3)
            {
                string str = "Select `UserId`,`AgencyName`, `Address`, `ContactNo`, `EmailId`, `City`, `Country`, `Designation`, `Description` from `tbl_agencydetails` where EmailId='" + user.Email + "';";
                var rows = _database.Query(str, parameters);
                if (rows.Count > 0)
                {
                    if (rows[0]["UserId"] == null)
                    {
                        model.Id = Convert.ToInt16("");
                    }
                    else
                    {
                        model.Id = int.Parse(rows[0]["UserId"]);
                    }
                    if (rows[0]["AgencyName"] == null)
                    {
                        model.Name = "";
                    }
                    else
                    {
                        model.Name = rows[0]["AgencyName"].ToString();
                    }
                    if (rows[0]["City"] == null)
                    {
                        model.City = "";
                    }
                    else
                    {
                        model.City = rows[0]["City"].ToString();
                    }
                    if (rows[0]["ContactNo"] == null)
                    {
                        model.PhoneNo = "";
                    }
                    else
                    {
                        model.PhoneNo = rows[0]["ContactNo"].ToString();
                    }
                    //if (rows[0]["EmailId"] == null)
                    //{
                    //    model.Email = "";
                    //}
                    //else
                    //{
                    //    model.Email = rows[0]["EmailId"].ToString();
                    //}
                    if (rows[0]["Country"] == null)
                    {
                        model.Country = "";
                    }
                    else
                    {
                        model.Country = rows[0]["Country"].ToString();
                    }
                    if (rows[0]["Address"] == null)
                    {
                        model.Address = "";
                    }
                    else
                    {
                        model.Address = rows[0]["Address"].ToString();
                    }
                    if (rows[0]["Designation"] == null)
                    {
                        model.Designation = "";
                    }
                    else
                    {
                        model.Designation = rows[0]["Designation"].ToString();
                    }
                    if (rows[0]["Description"] == null)
                    {
                        model.Description = "";
                    }
                    else
                    {
                        model.Description = rows[0]["Description"].ToString();
                    }
                }
            }
            return View(model);
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult SaveProfile(string ID, string Name, string Designation, string PhoneNo, string Email, string address, string city, string country, string Description, string[] Source, string[] Destination)
        {
            IdentityUser user = System.Web.HttpContext.Current.Session.GetDataFromSession<IdentityUser>("User");
            if (user == null)
            {
                return RedirectToAction("Login", "Account");
            }
            AccountController getrole = new AccountController();
            int rlid = getrole.getRole(user.UserId);
            connectionString.connectionOpen();

            if (rlid == 2)
            {
                DataTable dt = new DataTable();
                string str = "Select * from `tbl_organizationdetails` where `UserId` = '" + user.UserId + "';";
                MySqlDataAdapter da = new MySqlDataAdapter(str, connectionString.getConnection());
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    if (Name != "")
                    {
                        string query = "UPDATE `tbl_organizationdetails` set `OrgName` = '" + Name + "'  WHERE `UserId` = '" + user.UserId + "';";
                        MySqlCommand com1 = new MySqlCommand(query, connectionString.getConnection());
                        com1.ExecuteNonQuery();
                    }
                    if (PhoneNo != "")
                    {
                        string query = "UPDATE `tbl_organizationdetails` set `ContactNo` = '" + PhoneNo + "' WHERE `UserId` = '" + user.UserId + "';";
                        MySqlCommand com1 = new MySqlCommand(query, connectionString.getConnection());
                        com1.ExecuteNonQuery();
                    }
                    //if (Email != "")
                    //{
                    //    string query = "UPDATE `tbl_organizationdetails` set `EmailId` = '" + Email + "'  WHERE `UserId` = '" + user.UserId + "';";
                    //    MySqlCommand com1 = new MySqlCommand(query, connectionString.getConnection());
                    //    com1.ExecuteNonQuery();
                    //}
                    if (PhoneNo != "")
                    {
                        string query = "UPDATE `tbl_organizationdetails` set `ContactNo` = '" + PhoneNo + "' WHERE `UserId` = '" + user.UserId + "';";
                        MySqlCommand com1 = new MySqlCommand(query, connectionString.getConnection());
                        com1.ExecuteNonQuery();
                    }
                    if (address != "")
                    {
                        string query = "UPDATE `tbl_organizationdetails` set `Address` = '" + address + "' WHERE `UserId` = '" + user.UserId + "';";
                        MySqlCommand com1 = new MySqlCommand(query, connectionString.getConnection());
                        com1.ExecuteNonQuery();
                    }
                    if (city != "")
                    {
                        string query = "UPDATE `tbl_organizationdetails` set `City` = '" + city + "' WHERE `UserId` = '" + user.UserId + "';";
                        MySqlCommand com1 = new MySqlCommand(query, connectionString.getConnection());
                        com1.ExecuteNonQuery();
                    }
                    if (country != "")
                    {
                        string query = "UPDATE `tbl_organizationdetails` set `Country` = '" + country + "' WHERE `UserId` = '" + user.UserId + "';";
                        MySqlCommand com1 = new MySqlCommand(query, connectionString.getConnection());
                        com1.ExecuteNonQuery();
                    }
                }
                else
                {
                    string time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    string st = "Insert into `tbl_organizationdetails`(`UserId`,`OrgName`,`ContactNo`,`CreationDate`,`Address`,`City`,`Country`) Values ('" + user.UserId + "','" + Name + "','" + PhoneNo + "', '" + time + "','" + address + "','" + city + "','" + country + "');";
                    MySqlCommand com1 = new MySqlCommand(st, connectionString.getConnection());
                    com1.ExecuteNonQuery();
                }
            }
            if (rlid == 4)
            {
                DataTable dt = new DataTable();
                string getuser = "select * from `tbl_translatordetails` where UserId = '" + user.UserId + "'";
                MySqlDataAdapter da = new MySqlDataAdapter(getuser, connectionString.getConnection());
                da.Fill(dt);
                int id = Convert.ToInt16(dt.Rows[0][0]);
                if (Name != "")
                {
                    string query = "UPDATE `tbl_translatordetails` set `TransltrName` = '" + Name + "'  WHERE `UserId` = " + ID + ";";
                    MySqlCommand com1 = new MySqlCommand(query, connectionString.getConnection());
                    com1.ExecuteNonQuery();
                }
                if (Designation != "")
                {
                    string query = "UPDATE `tbl_translatordetails` set `Designation` = '" + Designation + "'  WHERE  `UserId` = " + ID + ";";
                    MySqlCommand com1 = new MySqlCommand(query, connectionString.getConnection());
                    com1.ExecuteNonQuery();
                }
                if (PhoneNo != "")
                {
                    string query = "UPDATE `tbl_translatordetails` set `ContactNo` = '" + PhoneNo + "' WHERE `UserId` = " + ID + ";";
                    MySqlCommand com1 = new MySqlCommand(query, connectionString.getConnection());
                    com1.ExecuteNonQuery();
                }
                if (address != "")
                {
                    string query = "UPDATE `tbl_translatordetails` set `Address` = '" + address + "' WHERE `UserId` = '" + user.UserId + "';";
                    MySqlCommand com1 = new MySqlCommand(query, connectionString.getConnection());
                    com1.ExecuteNonQuery();
                }
                if (city != "")
                {
                    string query = "UPDATE `tbl_translatordetails` set `City` = '" + city + "' WHERE `UserId` = '" + user.UserId + "';";
                    MySqlCommand com1 = new MySqlCommand(query, connectionString.getConnection());
                    com1.ExecuteNonQuery();
                }
                if (country != "")
                {
                    string query = "UPDATE `tbl_translatordetails` set `Country` = '" + country + "' WHERE `UserId` = '" + user.UserId + "';";
                    MySqlCommand com1 = new MySqlCommand(query, connectionString.getConnection());
                    com1.ExecuteNonQuery();
                }
                //if (Email != "")
                //{
                //    string query = "UPDATE `tbl_translatordetails` set `EmailId` = '" + Email + "'  WHERE `UserId` = " + ID + ";";
                //    MySqlCommand com1 = new MySqlCommand(query, connectionString.getConnection());
                //    com1.ExecuteNonQuery();
                //}
                if (Description != "")
                {
                    string query = "UPDATE `tbl_translatordetails` set `Description` = '" + Description + "' WHERE `UserId` = " + ID + ";";
                    MySqlCommand com1 = new MySqlCommand(query, connectionString.getConnection());
                    com1.ExecuteNonQuery();
                }
                if (Source[0] != "" || Destination[0] != "")
                {
                    for (int i = 0; i < Source.Length; i++)
                    {
                        string insertdata = "insert into tbl_transltrlangmap (TransltrId, LangId, Type) values (" + id + ",'" + Source[i] + "','S');";
                        MySqlCommand com2 = new MySqlCommand(insertdata, connectionString.getConnection());
                        com2.ExecuteNonQuery();
                    }
                    for (int j = 0; j < Destination.Length; j++)
                    {
                        string insertdata = "insert into tbl_transltrlangmap (TransltrId, LangId, Type) values (" + id + ",'" + Destination[j] + "','T');";
                        MySqlCommand com2 = new MySqlCommand(insertdata, connectionString.getConnection());
                        com2.ExecuteNonQuery();
                    }
                }

            }

            if (rlid == 3)
            {
                if (Name != "")
                {
                    string query = "UPDATE `tbl_agencydetails` set `AgencyName` = '" + Name + "'  WHERE `UserId` = " + ID + ";";
                    MySqlCommand com1 = new MySqlCommand(query, connectionString.getConnection());
                    com1.ExecuteNonQuery();
                }
                if (Designation != "")
                {
                    string query = "UPDATE `tbl_agencydetails` set `City` = '" + Designation + "'  WHERE  `UserId` = " + ID + ";";
                    MySqlCommand com1 = new MySqlCommand(query, connectionString.getConnection());
                    com1.ExecuteNonQuery();
                }
                if (PhoneNo != "")
                {
                    string query = "UPDATE `tbl_agencydetails` set `ContactNo` = '" + PhoneNo + "' WHERE `UserId` = " + ID + ";";
                    MySqlCommand com1 = new MySqlCommand(query, connectionString.getConnection());
                    com1.ExecuteNonQuery();
                }
                if (address != "")
                {
                    string query = "UPDATE `tbl_agencydetails` set `Address` = '" + address + "' WHERE `UserId` = '" + user.UserId + "';";
                    MySqlCommand com1 = new MySqlCommand(query, connectionString.getConnection());
                    com1.ExecuteNonQuery();
                }
                if (city != "")
                {
                    string query = "UPDATE `tbl_agencydetails` set `City` = '" + city + "' WHERE `UserId` = '" + user.UserId + "';";
                    MySqlCommand com1 = new MySqlCommand(query, connectionString.getConnection());
                    com1.ExecuteNonQuery();
                }
                if (country != "")
                {
                    string query = "UPDATE `tbl_agencydetails` set `Country` = '" + country + "' WHERE `UserId` = '" + user.UserId + "';";
                    MySqlCommand com1 = new MySqlCommand(query, connectionString.getConnection());
                    com1.ExecuteNonQuery();
                }
                //if (Email != "")
                //{
                //    string query = "UPDATE `tbl_agencydetails` set `EmailId` = '" + Email + "'  WHERE `UserId` = " + ID + ";";
                //    MySqlCommand com1 = new MySqlCommand(query, connectionString.getConnection());
                //    com1.ExecuteNonQuery();
                //}
                if (Description != "")
                {
                    string query = "UPDATE `tbl_agencydetails` set `Country` = '" + Description + "' WHERE `UserId` = " + ID + ";";
                    MySqlCommand com1 = new MySqlCommand(query, connectionString.getConnection());
                    com1.ExecuteNonQuery();
                }

            }

            return null;
        }

        // GET: /appviews/timeline
        public ActionResult TimeLine()
        {
            return View();
        }

        // GET: /appviews/gallery
        public ActionResult Gallery()
        {
            return View();
        }
        public ActionResult GetLoginDetails()
        {
            AccountLoginModel accmodel = TempData["AccountLoginModel"] as AccountLoginModel;
            return View(accmodel);
        }

        // GET: /appviews/ProjectUpload
        [HttpGet]
        [AllowAnonymous]
        public ActionResult ProjectUpload()
        {
            IdentityUser user = System.Web.HttpContext.Current.Session.GetDataFromSession<IdentityUser>("User");

            DataSet ds = new DataSet();
            ds = getConfigureTaskNames(user);

            List<SelectListItem> obj = new List<SelectListItem>();
            int j = 1;
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                obj.Add(new SelectListItem { Text = ds.Tables[0].Rows[i][1].ToString(), Value = ds.Tables[0].Rows[i][0].ToString() });
                j++;
            }
            ++j;
            ViewBag.LoadAgency = obj;
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult ProjectUpload(ProjectUpload model)
        {
            int fcount = 0, lcount = 0, flag = 0;
            try
            {
                string path = string.Empty;
                //model.LangId = Convert.ToInt32(model.Source);
                if (ModelState.IsValid)
                {
                    if (model.File != null && model.File.ContentLength > 0)
                    {
                        try
                        {
                            path = Path.Combine(Server.MapPath("Doc/"),
                                                       Path.GetFileName(model.File.FileName));
                            model.File.SaveAs(path);
                            //ViewBag.Message = "File uploaded successfully";
                        }
                        catch (Exception ex)
                        {
                            ViewBag.Message = "ERROR:" + ex.Message.ToString();
                        }
                    }
                    else
                    {
                        ViewBag.Message = "You must select a file.";
                    }
                    IdentityUser user = System.Web.HttpContext.Current.Session.GetDataFromSession<IdentityUser>("User");
                    if (user == null)
                    {
                        return RedirectToAction("Login", "Account");
                    }
                    string expdate = model.ExpDate.ToString();
                    string ext = Path.GetExtension(path);
                    if (ext == ".zip" || ext == ".rar")
                    {
                        string zipPath = Server.MapPath("Doc/");
                        if (model.File == null)
                        {
                            _val = fileupload(user.UserId, model.ProjectName, model.Source, model.Destination, null, model.ExpDate);
                        }
                        else
                        {


                            using (ZipArchive archive = System.IO.Compression.ZipFile.OpenRead(path))
                            {
                                fcount = archive.Entries.Count;
                                foreach (ZipArchiveEntry entry in archive.Entries)
                                {
                                    if (entry.FullName.EndsWith(".resx", StringComparison.OrdinalIgnoreCase))
                                    {
                                        _val = fileupload(user.UserId, model.ProjectName, model.Source, model.Destination, model.File.FileName, model.ExpDate);
                                        string _file = Server.MapPath("Doc/") + entry.FullName;
                                        string _filename = getNextFileName(_file);
                                        string childpath = Path.GetFileNameWithoutExtension(_filename);
                                        entry.ExtractToFile(Path.Combine(zipPath, childpath + ".resx"));
                                        //ZipFile.ExtractToDirectory(path, zipPath);
                                        string fname = Path.GetFileNameWithoutExtension(_file);

                                        // Reading resx file
                                        DataSet dset = new DataSet();
                                        DataSet dt = new DataSet();
                                        dt = getSourceLang(_val);
                                        dset = GetLangInfo(_val, user.UserId);
                                        _fname = Path.GetFileNameWithoutExtension(_file);
                                        for (int i = 0; i < dset.Tables[0].Rows.Count; i++)
                                        {
                                            string slang = dt.Tables[0].Rows[0][0].ToString();
                                            string lang = dset.Tables[0].Rows[i][2].ToString();
                                            int sid = Convert.ToInt32(dt.Tables[0].Rows[0][1]);
                                            int tid = Convert.ToInt32(dset.Tables[0].Rows[i][1]);
                                            string filename = Server.MapPath("Doc/") + _fname + "_" + lang + ".resx";
                                            string _childfilename = getNextFileName(filename);
                                            System.IO.File.Copy(_file, _childfilename);
                                            string childpath1 = Path.GetFileNameWithoutExtension(_childfilename);
                                            ResXResourceReader rsxr = new ResXResourceReader(_childfilename);
                                            IDictionaryEnumerator id = rsxr.GetEnumerator();
                                            List<string> _key = new List<string>();
                                            List<string> _str = new List<string>();
                                            List<string> _valueDuplicate = new List<string>();
                                            List<string> _valueMT = new List<string>();
                                            List<string> _valueTR = new List<string>();
                                            string _st = string.Empty;
                                            foreach (DictionaryEntry d in rsxr)
                                            {
                                                DataSet ds = new DataSet();
                                                if (_str.Exists(element => element == d.Value.ToString()))
                                                {
                                                    _rep = _rep + 1;
                                                    // insert in local list
                                                    _valueDuplicate.Add(d.Value.ToString());
                                                    // insert in DB with DuP
                                                }

                                                //string valueFromTM = getValueFromTM(d.Value.ToString());
                                                if (Check_TM(d.Value.ToString(), ref ds) == true)
                                                {
                                                    _countTM = _countTM + 1;
                                                    //  insert in TM list
                                                    _valueMT.Add(d.Value.ToString());

                                                    //InsertItemPosition in DB with MT status
                                                }
                                                else
                                                {
                                                    // insert in TR LIST
                                                    _valueTR.Add(d.Value.ToString());
                                                    // inssrert in DB with TR star=tus
                                                }
                                                _key.Add(d.Key.ToString());
                                                _str.Add(d.Value.ToString());


                                            }
                                            _count = _key.Count;
                                            //WordCount(_str);
                                            //_count = _count + WordCount(_st);
                                            //_rep = _rep + RepetionWord(_st);
                                            rsxr.Close();
                                            _total = (_count - (_rep + _countTM));
                                            int _fid = insChildProjInfo(_val, fname, fname + "_" + lang, _count, _rep, _countTM, _total, sid, tid, model.ExpDate);
                                            bool _result = insTransInfo(_fid, _key, _str, slang, lang);

                                            CalulateKey(_fid, _str, _valueDuplicate, "D");
                                            CalulateKey(_fid, _str, _valueMT, "MT");
                                            CalulateKey(_fid, _str, _valueTR, "RT");
                                            _count = 0;
                                            _rep = 0;
                                        }
                                    }
                                    else
                                    {
                                        lcount++;
                                        if (fcount == lcount)
                                        {
                                            flag = 1;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        if (model.File == null)
                        {
                            _val = fileupload(user.UserId, model.ProjectName, model.Source, model.Destination, null, model.ExpDate);
                        }
                        else
                        {
                            _val = fileupload(user.UserId, model.ProjectName, model.Source, model.Destination, model.File.FileName, model.ExpDate);

                            // Reading resx file
                            DataSet dset = new DataSet();
                            DataSet dt = new DataSet();
                            dt = getSourceLang(_val);
                            dset = GetLangInfo(_val, user.UserId);
                            _fname = Path.GetFileNameWithoutExtension(path);
                            for (int i = 0; i < dset.Tables[0].Rows.Count; i++)
                            {
                                string slang = dt.Tables[0].Rows[0][0].ToString();
                                string lang = dset.Tables[0].Rows[i][2].ToString();
                                int sid = Convert.ToInt32(dt.Tables[0].Rows[0][1]);
                                int tid = Convert.ToInt32(dset.Tables[0].Rows[i][1]);
                                string filename = Server.MapPath("Doc/") + _fname + "_" + lang + ".resx";
                                string _childfilename = getNextFileName(filename);
                                System.IO.File.Copy(path, _childfilename);
                                string childpath = Path.GetFileNameWithoutExtension(_childfilename);
                                ResXResourceReader rsxr = new ResXResourceReader(_childfilename);
                                IDictionaryEnumerator id = rsxr.GetEnumerator();
                                //string[] _key = new string[500];
                                List<string> _key = new List<string>();
                                List<string> _valueDuplicate = new List<string>();
                                List<string> _valueMT = new List<string>();
                                List<string> _valueTR = new List<string>();
                                List<string> _str = new List<string>();
                                int c = 0, Tc = 0;
                                foreach (DictionaryEntry d in rsxr)
                                {
                                    DataSet ds1 = new DataSet();
                                    if (_str.Exists(element => element == d.Value.ToString()))
                                    {
                                        _rep = _rep + 1;
                                        // insert in local list
                                        _valueDuplicate.Add(d.Value.ToString());
                                        // insert in DB with DuP
                                    }

                                    //string valueFromTM = getValueFromTM(d.Value.ToString());
                                    if (Check_TM(d.Value.ToString(), ref ds1) == true)
                                    {
                                        _countTM = _countTM + 1;
                                        //  insert in TM list
                                        _valueMT.Add(d.Value.ToString());

                                        //InsertItemPosition in DB with MT status
                                    }
                                    else
                                    {
                                        // insert in TR LIST
                                        _valueTR.Add(d.Value.ToString());
                                        // inssrert in DB with TR star=tus
                                    }
                                    _key.Add(d.Key.ToString());
                                    _str.Add(d.Value.ToString());


                                }
                                _count = _key.Count;
                                //WordCount(_str);
                                //_count = _count + WordCount(_st);
                                //_rep = _rep + RepetionWord(_st);
                                rsxr.Close();
                                _total = (_count - (_rep + _countTM));
                                int _fid = insChildProjInfo(_val, _fname, _fname + "_" + lang, _count, _rep, _countTM, _total, sid, tid, model.ExpDate);
                                bool _result = insTransInfo(_fid, _key, _str, slang, lang);

                                CalulateKey(_fid, _str, _valueDuplicate, "D");
                                CalulateKey(_fid, _str, _valueMT, "MT");
                                CalulateKey(_fid, _str, _valueTR, "RT");
                                _count = 0;
                                _rep = 0;
                            }
                        }
                    }
                }
                if (flag == 0)
                {
                    ViewBag.Message = "1";
                }
                else
                {
                    ViewBag.Message = "-1";
                }

            }
            catch
            {
                ViewBag.Message = "0";
            }


            return View();
        }

        public int fileupload(int uid, string projectname, int source, int[] destination, string filepath, DateTime Expdate)
        {
            //bool retVal = false;
            int val = 0;
            try
            {
                string time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                string edate = Expdate.ToString("yyyy-MM-dd");
                //int sourcelang = checkLang(source);
                string strQry = "INSERT INTO `tbl_project` (`OwnerId`,`projectname`, `SubmitionDate`, `LangId`, `FilePath`, `Status`, `ExpectedDate`) VALUES ( " + uid + ", '" + projectname + "' , '" + time + "', " + source + ",'" + filepath + "', 'New', '" + edate + "');";
                connectionString.connectionOpen();


                MySqlCommand com = new MySqlCommand(strQry, connectionString.getConnection());
                com.ExecuteNonQuery();
                long _uid = com.LastInsertedId;

                for (int i = 0; i < destination.Length; i++)
                {
                    string str = "Insert into `tbl_projectlangmap` (`ProjectId`,`LangId`) values (" + Convert.ToInt32(_uid) + ", " + destination[i] + ");";
                    MySqlCommand com1 = new MySqlCommand(str, connectionString.getConnection());
                    com1.ExecuteNonQuery();
                }

                val = Convert.ToInt32(_uid);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connectionString.connectionClose();
            }
            return val;
        }
        public DataSet getSourceLang(int pid)
        {
            DataSet ds = new DataSet();
            try
            {
                connectionString.connectionOpen();


                string getStr = "SELECT l.LangISOName, l.LangId from `tbl_project` p, `tbl_langmaster` l WHERE `ProjectId` = " + pid + " and l.LangId = p.LangId;";
                MySqlDataAdapter da = new MySqlDataAdapter(getStr, connectionString.getConnection());
                da.Fill(ds);
            }
            catch
            {

            }
            finally
            {
                connectionString.connectionClose();
            }
            return ds;
        }

        public string updateprojectname(string projName, string pid)
        {
            IdentityUser user = System.Web.HttpContext.Current.Session.GetDataFromSession<IdentityUser>("User");
            string _value = string.Empty;
            if (projName == "")
            {

            }
            else
            {
                string oldprojectname = string.Empty;
                try
                {
                    DataSet ds = new DataSet(); DataSet ds1 = new DataSet();
                    connectionString.connectionOpen();


                    string getStr1 = "SELECT distinct `ProjectName` FROM `tbl_project`  where `ProjectId` = " + Convert.ToInt16(pid) + ";";
                    MySqlDataAdapter da1 = new MySqlDataAdapter(getStr1, connectionString.getConnection());
                    da1.Fill(ds1);
                    if (ds1.Tables[0].Rows.Count > 0)
                    {
                        oldprojectname = ds1.Tables[0].Rows[0][0].ToString();
                    }

                    string getStr = "SELECT distinct `ProjectName` FROM `tbl_project` WHERE `ProjectName` ='" + projName + "' and OwnerId = " + user.UserId + "";
                    MySqlDataAdapter da = new MySqlDataAdapter(getStr, connectionString.getConnection());
                    da.Fill(ds);

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        _value = "2";
                    }
                    else
                    {
                        string str = "Update `tbl_project` set `ProjectName` = '" + projName + "' where `ProjectId` = " + Convert.ToInt16(pid) + ";";
                        MySqlCommand com = new MySqlCommand(str, connectionString.getConnection());
                        com.ExecuteNonQuery();
                        NotificationHandler nh = new NotificationHandler();
                        nh.ProjectRenamed(projName, oldprojectname, pid);
                        //notification
                        _value = "1";
                    }
                }
                catch
                {
                    _value = "0";
                }
                finally
                {
                    connectionString.connectionClose();
                }
            }

            return _value;
        }

        public bool Check_TM(string _value, ref DataSet ds1)
        {
            connectionString.connectionOpen();

            DataSet ds = new DataSet();

            //string str = _value[i];
            string getStr = "SELECT distinct `Name`, `Value` FROM tbl_translationmem WHERE Name ='" + _value + "'";
            MySqlDataAdapter da = new MySqlDataAdapter(getStr, connectionString.getConnection());
            da.Fill(ds);
            ds1 = ds;

            connectionString.connectionClose();
            if (ds.Tables[0].Rows.Count > 0)
            {
                return true;
            }
            else
                return false;
        }

        public int insChildProjInfo(int projid, string parentprojname, string childprojname, int totalword, int repeatedword, int TMword, int trasnword, int sLang, int tLang, DateTime ExpDate)
        {
            int _res = 0;
            try
            {
                string edate = ExpDate.ToString("yyyy-MM-dd");
                int i = 0;
                string strQry = "INSERT INTO `tbl_filedetails` (`ParentFileName`, `ChildFileName`, `ProjectId`, `TotalWord`, `TMWordCount`,`RepeatedWord`,`TranslationRequired`,`Source_lang`,`Target_lang`, `CompletionDate`, `Status`) VALUES ('" + parentprojname + "', '" + childprojname + "', " + projid + ", " + totalword + ", " + TMword + ", " + repeatedword + ", " + trasnword + "," + sLang + "," + tLang + ", '" + edate + "', 'Newly Uploaded');";

                connectionString.connectionOpen();

                MySqlCommand com = new MySqlCommand(strQry, connectionString.getConnection());

                i = com.ExecuteNonQuery();
                long _uid = com.LastInsertedId;
                _res = Convert.ToInt32(_uid);
            }
            catch (Exception ex1)
            {
                _res = 0;
            }
            finally
            {
                connectionString.connectionClose();
            }
            return _res;
        }

        public bool insTransInfo(int pid, List<string> _key, List<string> _value, string source, string target)
        {
            bool _res = false;
            try
            {
                string time = DateTime.Now.ToString("yyyy-MM-dd");
                int i = 0;
                for (int j = 0; j < _key.Count; j++)
                {
                    string strQry = "INSERT INTO `tbl_projectassignment` (`FileId`, `KeyName`, `Value`, `CreateDate`, `Source`, `Target`) VALUES (" + pid + ",'" + _key[j] + "','" + _value[j] + "','" + time + "', '" + source + "', '" + target + "');";
                    connectionString.connectionOpen();

                    MySqlCommand com = new MySqlCommand(strQry, connectionString.getConnection());

                    i = com.ExecuteNonQuery();
                }
                //foreach (string keyname in _key)
                //{
                //    string strQry = "INSERT INTO `tbl_projectassignment` (`FileId`, `KeyName`, `Value`) VALUES (" + pid + ",'"+ keyname +"');";
                //    connectionString.connectionOpen();

                //    MySqlCommand com = new MySqlCommand(strQry, connectionString.getConnection());
                //    
                //    i = com.ExecuteNonQuery();
                //}
                _res = true;
            }
            catch (Exception ex1)
            {
                _res = false;
            }
            finally
            {
                connectionString.connectionClose();
            }
            return _res;
        }

        public void CalulateKey(int fid, List<string> mainList, List<string> newList, string colname)
        {
            string getval = string.Empty;
            List<string> getListrValue = new List<string>();
            if (colname == "D")
            {
                for (int k = 0; k < newList.Count; k++)
                {
                    if (k == 0)
                    {
                        getval = getval + "'" + newList[k].ToString() + "'";
                    }
                    else
                    {
                        getval = getval + ",'" + newList[k].ToString() + "'";
                    }
                }
            }
            else if (colname == "MT")
            {
                getListrValue = newList.ToList();
            }
            else if (colname == "RT")
            {
                getListrValue = newList.Distinct().ToList();
            }

            connectionString.connectionOpen();

            string query = string.Empty;
            if (colname == "D")
            {
                if (getval != "")
                {
                    query = "UPDATE `tbl_projectassignment` SET `D` = 1  where `FileId` = " + fid + " and `Value` in (" + getval + ") and ID NOT IN ( SELECT * FROM (SELECT MIN(ID) FROM tbl_projectassignment where `FileId` = " + fid + "  GROUP BY `Value`) AS X) ;";
                    MySqlCommand com = new MySqlCommand(query, connectionString.getConnection());
                    com.ExecuteNonQuery();
                }
            }
            else
            {
                for (int i = 0; i < mainList.Count; i++)
                {

                    for (int j = 0; j < getListrValue.Count; j++)
                    {


                        if (colname == "MT")
                        {
                            query = "UPDATE `tbl_projectassignment` SET `" + colname + "` = 1  where `FileId` = " + fid + " and `Value` = '" + getListrValue[j] + "';";

                        }
                        if (colname == "RT")
                        {

                            query = "UPDATE `tbl_projectassignment` SET `" + colname + "` = 1  where `FileId` = " + fid + " and `Value` = '" + getListrValue[j] + "' and ID NOT IN ( SELECT * FROM (SELECT ID FROM tbl_projectassignment where `D` = 1 Or `MT` = 1 and `FileId` = " + fid + ") AS X) ;";

                        }
                        MySqlCommand com = new MySqlCommand(query, connectionString.getConnection());
                        com.ExecuteNonQuery();
                    }
                }
            }
            connectionString.connectionClose();
        }

        public DataSet GetLangList()
        {
            DataSet ds = new DataSet();
            try
            {
                string str = "SELECT `LangId`, `LangEnglishName` from tbl_langmaster order by `LangEnglishName`";
                connectionString.connectionOpen();
                MySqlDataAdapter da = new MySqlDataAdapter(str, connectionString.getConnection());

                da.Fill(ds);

            }
            catch (Exception ex)
            {

            }
            finally
            {
                connectionString.connectionClose();
            }
            return ds;
        }
        //GET
        [HttpGet]
        public String GetLangList(string TransltrId)
        {
            DataSet ds = new DataSet();
            try
            {
                string query = string.Empty;
                if (string.IsNullOrEmpty(TransltrId))//populate the whole list of language...
                    query = "SELECT `LangId`, `LangEnglishName` from tbl_langmaster order by `LangEnglishName`";
                else
                    query = "SELECT langmaster.LangId, langmaster.LangEnglishName from tbl_langmaster langmaster left join tbl_transltrlangmap translangmap on langmaster.LangId = translangmap.LangId where translangmap.TransltrId = " + TransltrId + " order by langmaster.`LangEnglishName`";

                connectionString.connectionOpen();
                MySqlDataAdapter da = new MySqlDataAdapter(query, connectionString.getConnection());

                da.Fill(ds);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connectionString.connectionClose();
            }

            return DataTableToJSONWithJavaScriptSerializerDS(ds);
        }

        public DataSet getProjectInfo(int uid)
        {
            DataSet ds = new DataSet();
            try
            {
                connectionString.connectionOpen();


                string getStr = "SELECT p.ProjectId, p.OwnerId, p.ProjectName, p.SubmitionDate, l.LangId, l.LangISOName from `tbl_project` p, `tbl_langmaster` l WHERE `OwnerId` = " + uid + " and l.LangId = p.LangId;";
                MySqlDataAdapter da = new MySqlDataAdapter(getStr, connectionString.getConnection());
                da.Fill(ds);
            }
            catch
            {

            }
            finally
            {
                connectionString.connectionClose();
            }
            return ds;
        }

        public int WordCount(string _value)
        {
            string trimmed_text = _value.Trim();
            string[] split_text = trimmed_text.Split(' ', '\n', ',');
            int word_count = 0;
            var d = new Dictionary<string, bool>();
            _rep = d.Count;
            foreach (string _word in split_text)
            {
                if (_word == "")
                {

                }
                else
                {
                    word_count++;
                    if (Check_TM(_word) == true)
                    {
                        if (!d.ContainsKey(_word))
                        {
                            d.Add(_word, true);
                        }
                        else
                        {

                        }
                        _countTM = d.Count;
                    }
                }
            }
            return word_count;
        }
        public int RepetionWord(string _value)
        {
            string trimmed_text = _value.Trim();
            string[] split_text = trimmed_text.Split(' ', '\n', ',');
            var d = new Dictionary<string, bool>();
            int repetition = 0;
            foreach (string txt in split_text)
            {
                string _word = txt.ToLower();
                if (_word == "")
                {

                }
                else
                {
                    if (!d.ContainsKey(_word))
                    {
                        d.Add(_word, true);
                        repetition++;
                    }
                    else
                    {
                        repetition++;
                    }

                }
            }
            return (repetition - d.Count);
        }

        public bool Check_TM(string _value)
        {
            string getStr = "SELECT distinct Name FROM tbl_translationmem WHERE Name ='" + _value + "'";
            connectionString.connectionOpen();
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(getStr, connectionString.getConnection());

            da.Fill(ds);
            connectionString.connectionClose();
            if (ds.Tables[0].Rows.Count > 0)
            {
                return true;
            }
            else
                return false;
        }

        public DataSet GetLangInfo(int pid, int ownerid)
        {
            DataSet ds = new DataSet();
            try
            {
                string str = "select m.ProjectId, m.LangId, l.LangISOName from tbl_projectlangmap m join tbl_project p on p.ProjectId = m.ProjectId join tbl_langmaster l on l.LangId = m.LangId where p.OwnerId = " + ownerid + " and m.ProjectId = " + pid + ";";
                connectionString.connectionOpen();
                MySqlDataAdapter da = new MySqlDataAdapter(str, connectionString.getConnection());

                da.Fill(ds);

            }
            catch (Exception ex)
            {

            }
            finally
            {
                connectionString.connectionClose();
            }
            return ds;
        }

        private string getNextFileName(string fileName)
        {
            string extension = Path.GetExtension(fileName);

            int i = 0;
            while (System.IO.File.Exists(fileName))
            {
                if (i == 0)
                    fileName = fileName.Replace(extension, "(" + ++i + ")" + extension);
                else
                    fileName = fileName.Replace("(" + i + ")" + extension, "(" + ++i + ")" + extension);
            }

            return fileName;
        }

        public DataSet getProjectInfobyOwner(IdentityUser user)
        {
            DataSet ds = new DataSet();
            try
            {
                connectionString.connectionOpen();


                string commandText = "SELECT tbl_project.ProjectId,tbl_project.ProjectName from `tbl_project` inner join `tbl_users` on tbl_users.UserId = tbl_project.OwnerId  WHERE tbl_project.OwnerId = " + user.UserId + ";";
                MySqlDataAdapter da = new MySqlDataAdapter(commandText, connectionString.getConnection());
                da.Fill(ds);
            }
            catch
            {

            }
            finally
            {
                connectionString.connectionClose();
            }
            return ds;
        }

        public DataSet getAgency(IdentityUser user)
        {
            DataSet ds = new DataSet();
            try
            {
                connectionString.connectionOpen();


                string commandText = "SELECT tbl_agencydetails.AgencyId as AgencyId,tbl_agencydetails.AgencyName as AgencyName from `tbl_agencydetails` where `UserId` IS NOT NULL and `AgencyName` IS NOT NULL and `AgencyName` !='';";
                MySqlDataAdapter da = new MySqlDataAdapter(commandText, connectionString.getConnection());
                da.Fill(ds);
            }
            catch
            {

            }
            finally
            {
                connectionString.connectionClose();
            }
            return ds;
        }
        public string getAllAgency()
        {
            string _val = string.Empty;
            DataTable ds = new DataTable();

            try
            {
                connectionString.connectionOpen();


                IdentityUser user = System.Web.HttpContext.Current.Session.GetDataFromSession<IdentityUser>("User");

                string commandText = "SELECT ag.AgencyId, ag.AgencyName, ag.EmailId FROM tbl_agencydetails ag LEFT JOIN tbl_assignagencytranslator aat ON aat.AgencyID = ag.AgencyId WHERE ag.UserId = '" + user.UserId + "' OR aat.UserID = '" + user.UserId + "';";
                MySqlDataAdapter da = new MySqlDataAdapter(commandText, connectionString.getConnection());
                da.Fill(ds);
                ds.TableName = "data";
                _val = DataTableToJSONWithJavaScriptSerializerDT(ds);
            }
            catch
            {

            }
            finally
            {
                connectionString.connectionClose();
            }
            return _val;

        }

        public string getTM()
        {
            string _val = string.Empty;
            DataTable ds = new DataTable();

            connectionString.connectionOpen();


            IdentityUser user = System.Web.HttpContext.Current.Session.GetDataFromSession<IdentityUser>("User");

            string commandText = "SELECT TMID, Name FROM tm_master WHERE CreatedBy = '" + user.UserId + "';";
            MySqlDataAdapter da = new MySqlDataAdapter(commandText, connectionString.getConnection());
            da.Fill(ds);
            ds.TableName = "data";
            _val = DataTableToJSONWithJavaScriptSerializerDT(ds);

            connectionString.connectionClose();

            return _val;
        }

        public DataSet getTranslator(IdentityUser user)
        {
            DataSet ds = new DataSet();
            try
            {
                connectionString.connectionOpen();


                string commandText = "SELECT tbl_translatordetails.TransltrId,tbl_translatordetails.TransltrName from `tbl_translatordetails`;";
                MySqlDataAdapter da = new MySqlDataAdapter(commandText, connectionString.getConnection());
                da.Fill(ds);
            }
            catch
            {

            }
            finally
            {
                connectionString.connectionClose();
            }
            return ds;
        }

        long assignpId = 0;
        public bool assignprojecttouser(AssignProjectModel model)
        {
            bool retVal = false;
            try
            {
                connectionString.connectionOpen();

                IdentityUser user = System.Web.HttpContext.Current.Session.GetDataFromSession<IdentityUser>("User");
                DataTable dt = new DataTable();
                string getfileid = "select Id from `tbl_filedetails` where ProjectId = '" + model.projectid + "'";
                MySqlDataAdapter da = new MySqlDataAdapter(getfileid, connectionString.getConnection());
                da.Fill(dt);

                DataTable dtt = new DataTable();
                string gettranslatorid = "select `TransltrId`, `userid` from `tbl_translatordetails` where EmailId = '" + model.email + "'";
                MySqlDataAdapter daa = new MySqlDataAdapter(gettranslatorid, connectionString.getConnection());
                daa.Fill(dtt);

                string userid = Convert.ToString(dtt.Rows[0][1]);
                for (var i = 0; i < dt.Rows.Count; i++)
                {
                    string str = "Insert into `tbl_assignproject` (`ownerid`,`assignto`,`useremail`,`projectid`,`status`,`assigndate`,`userid`,`fileid`) values (" + model.ownerid + ", '" + userid + "','" + model.email + "', " + model.projectid + ", '" + model.status + "', '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','" + userid + "','" + dt.Rows[i][0] + "');";
                    MySqlCommand com1 = new MySqlCommand(str, connectionString.getConnection());
                    com1.ExecuteNonQuery();
                    assignpId = com1.LastInsertedId;
                }
                retVal = true;
            }
            catch (Exception ex)
            {
                retVal = false;
            }
            finally
            {
                connectionString.connectionClose();
            }
            return retVal;
        }

        public string ProjectSummaryHelper(string pid)
        {
            DataTable dt = new DataTable();

            string qry_costsummary = "select * from tbl_filedetails fd INNER JOIN tbl_currencymaster cm on fd.CurrencyId = cm.CurrencyId where ProjectId = " + pid;
            connectionString.connectionOpen();
            MySqlDataAdapter da = new MySqlDataAdapter(qry_costsummary, connectionString.getConnection());

            da.Fill(dt);
            connectionString.connectionClose();
            dt.TableName = "data";
            string costsummary = DataTableToJSONWithJavaScriptSerializerDT(dt);

            return costsummary;
        }

        public string GetFileCostDetails(string fileId)
        {
            DataTable dt = new DataTable();

            string qry_costsummary = "select * from tbl_filedetails where Id = " + fileId;
            connectionString.connectionOpen();
            MySqlDataAdapter da = new MySqlDataAdapter(qry_costsummary, connectionString.getConnection());

            da.Fill(dt);
            connectionString.connectionClose();
            dt.TableName = "data";
            string costsummary = DataTableToJSONWithJavaScriptSerializerDT(dt);

            return costsummary;
        }

        // GET: /appviews/OrganizationProject
        public ActionResult OrganizationProject()
        {
            DataSet ds = new DataSet();
            IdentityUser user = System.Web.HttpContext.Current.Session.GetDataFromSession<IdentityUser>("User");
            if (user == null)
            {
                return RedirectToAction("Login", "Account");
            }
            ProjectViewModel model = new ProjectViewModel();

            List<ProjectModel> projects = new List<ProjectModel>();
            model.Projects = projects;
            string commandText = "SELECT p.ProjectId, p.OwnerId, p.ProjectName, p.SubmitionDate, l.LangId , l.LangISOName from `tbl_project` p, `tbl_langmaster` l WHERE `OwnerId` = " + user.UserId + " and l.LangId = p.LangId;";


            Dictionary<string, object> parameters = new Dictionary<string, object>() { };

            Dictionary<int, ProjectModel> tempList = new Dictionary<int, ProjectModel>();
            var rows = _database.Query(commandText, parameters);
            foreach (var row in rows)
            {
                var projInfo = new ProjectModel
                {
                    ProjectId = int.Parse(row["ProjectId"]),
                    ProjectName = row["ProjectName"],
                    StartData = row["SubmitionDate"],
                    Source = row["LangISOName"],
                    Destination = new Dictionary<int, string>()
                };

                projects.Add(projInfo);
                tempList.Add(projInfo.ProjectId, projInfo);
            }

            string str = "select m.ProjectId, m.LangId, l.LangISOName from tbl_projectlangmap m join tbl_project p on p.ProjectId = m.ProjectId join tbl_langmaster l on l.LangId = m.LangId where p.OwnerId = " + user.UserId + ";";

            var rows1 = _database.Query(str, parameters);
            foreach (var row in rows1)
            {
                int projid = int.Parse(row["ProjectId"]);

                if (tempList.ContainsKey(projid))
                {
                    ProjectModel proj = tempList[projid];

                    proj.Destination.Add(int.Parse(row["LangId"]), row["LangISOName"]);
                }
            }

            return View("OrganizationProject", projects);

        }
        public string SubmitAgencyNew(string AgencyEmail)
        {
            IdentityUser user = System.Web.HttpContext.Current.Session.GetDataFromSession<IdentityUser>("User");
            connectionString.connectionOpen();

            string returnValue = string.Empty;
            string query = string.Empty;
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[8];
            var random = new Random();
            DataSet ds = new DataSet();
            DataSet ds1 = new DataSet();
            int UserID = user.UserId;

            try
            {
                string str = "SELECT `UserId`, `Email` FROM tbl_users;";
                MySqlDataAdapter da = new MySqlDataAdapter(str, connectionString.getConnection());
                da.Fill(ds);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    string email = dr["Email"].ToString();

                    if (email.ToLower() == AgencyEmail.ToLower())
                    {
                        int id = Convert.ToInt32(dr["UserId"].ToString());

                        string str1 = "SELECT `AgencyId` FROM tbl_agencydetails WHERE EmailId = '" + email + "';";
                        MySqlDataAdapter da1 = new MySqlDataAdapter(str1, connectionString.getConnection());
                        da1.Fill(ds1);

                        if (ds1.Tables[0].Rows.Count > 0)
                        {
                            int AgencyID1 = Convert.ToInt32(ds1.Tables[0].Rows[0][0]);

                            string queryNew1 = "INSERT INTO tbl_assignagencytranslator (UserID, AgencyID) VALUES (" + UserID + ", " + AgencyID1 + ")";
                            MySqlCommand comNew1 = new MySqlCommand(queryNew1, connectionString.getConnection());
                            comNew1.ExecuteNonQuery();

                            return "exist";
                        }
                        else
                        {
                            return "Sorry, This Email Id is already Used.";
                        }
                    }
                }

                for (int i = 0; i < stringChars.Length; i++)
                {
                    stringChars[i] = chars[random.Next(chars.Length)];
                }

                var finalString = new String(stringChars);

                var auser = new ApplicationUser()
                {
                    UserName = AgencyEmail,
                    Email = AgencyEmail,
                    RoleId = 3,
                    LoginMode = 1
                };

                var result = _manager.CreateAsync(auser, finalString);

                bool isValid = result.Result.Succeeded;

                if (!isValid)
                {
                    return result.Result.Errors.FirstOrDefault();
                }

                var user2 = _manager.FindByEmail(AgencyEmail);

                query = "insert into tbl_agencydetails (EmailId,UserId) values ('" + AgencyEmail + "','" + user2.UserId + "')";
                MySqlCommand com = new MySqlCommand(query, connectionString.getConnection());
                com.ExecuteNonQuery();
                long _aid = com.LastInsertedId;

                int AgencyID = Convert.ToInt32(_aid);

                string queryNew = "INSERT INTO tbl_assignagencytranslator (UserID, AgencyID) VALUES (" + UserID + ", " + AgencyID + ")";
                MySqlCommand comNew = new MySqlCommand(queryNew, connectionString.getConnection());
                comNew.ExecuteNonQuery();

                string query1 = "insert into tbl_organizationagencymap (agencyid,organizationid) values (" + Convert.ToInt16(_aid) + ",'" + user.UserId + "')";
                MySqlCommand com1 = new MySqlCommand(query1, connectionString.getConnection());
                com1.ExecuteNonQuery();

                NotificationHandler nh = new NotificationHandler();
                nh.Invite("byOther", AgencyEmail, user.UserName, "Agency", "Agency");

                bool _res = false;
                mailsend objMail = new mailsend();
                _res = objMail.mailSend(user2.UserName, user2.Email, "0", null, 0, finalString);

                returnValue = "success";
            }
            catch
            {

            }
            finally
            {
                connectionString.connectionClose();
            }

            return returnValue;
        }
        public string SubmitTranslator(string translatorEmail, string sourceLanguage, string targetLanguages)
        {
            IdentityUser user = System.Web.HttpContext.Current.Session.GetDataFromSession<IdentityUser>("User");
            connectionString.connectionOpen();

            string translatorId = string.Empty;
            string query = string.Empty;
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[8];
            var random = new Random();
            DataSet ds = new DataSet();
            DataSet ds1 = new DataSet();
            int UserID = user.UserId;

            try
            {
                string str = "SELECT `UserId`, `Email` FROM tbl_users;";
                MySqlDataAdapter da = new MySqlDataAdapter(str, connectionString.getConnection());
                da.Fill(ds);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    string email = dr["Email"].ToString();

                    if (email.ToLower() == translatorEmail.ToLower())
                    {
                        int id = Convert.ToInt32(dr["UserId"].ToString());

                        string str1 = "SELECT `TransltrId` FROM tbl_translatordetails WHERE EmailId = '" + email + "';";
                        MySqlDataAdapter da1 = new MySqlDataAdapter(str1, connectionString.getConnection());
                        da1.Fill(ds1);

                        if (ds1.Tables[0].Rows.Count > 0)
                        {
                            int TranslatorID1 = Convert.ToInt32(ds1.Tables[0].Rows[0][0]);

                            string queryNew1 = "INSERT INTO tbl_assignagencytranslator (UserID, TranslatorID) VALUES (" + UserID + ", " + TranslatorID1 + ")";
                            MySqlCommand comNew1 = new MySqlCommand(queryNew1, connectionString.getConnection());
                            comNew1.ExecuteNonQuery();

                            return "exist";
                        }
                        else
                        {
                            return "Sorry, This Email Id is already used for Translator.";
                        }
                    }
                }

                for (int i = 0; i < stringChars.Length; i++)
                {
                    stringChars[i] = chars[random.Next(chars.Length)];
                }

                var finalString = new String(stringChars);

                var auser = new ApplicationUser()
                {
                    UserName = translatorEmail,
                    Email = translatorEmail,
                    RoleId = 4,
                    LoginMode = 1
                };

                var result = _manager.CreateAsync(auser, finalString);

                bool isValid = result.Result.Succeeded;

                if (!isValid)
                {
                    return result.Result.Errors.FirstOrDefault();
                }

                var user2 = _manager.FindByEmail(translatorEmail);

                query = "insert into tbl_translatordetails (EmailId,UserId) values ('" + translatorEmail + "','" + user2.UserId + "')";
                MySqlCommand com = new MySqlCommand(query, connectionString.getConnection());
                com.ExecuteNonQuery();
                long _aid = com.LastInsertedId;
                translatorId = _aid.ToString();

                int TranslatorID = Convert.ToInt32(_aid);

                string queryNew = "INSERT INTO tbl_assignagencytranslator (UserID, TranslatorID) VALUES (" + UserID + ", " + TranslatorID + ")";
                MySqlCommand comNew = new MySqlCommand(queryNew, connectionString.getConnection());
                comNew.ExecuteNonQuery();

                StringBuilder sCommand = new StringBuilder("INSERT INTO `tbl_transltrlangmap` (`TransltrId`, `LangId`, `Type`) VALUES ");
                List<string> Rows = new List<string>();
                Rows.Add(string.Format("('{0}','{1}','{2}')", Convert.ToInt16(translatorId), Convert.ToInt16(sourceLanguage), MySqlHelper.EscapeString("S")));

                foreach (string targetLanguage in targetLanguages.Split(','))
                    Rows.Add(string.Format("('{0}','{1}','{2}')", Convert.ToInt16(translatorId), Convert.ToInt16(targetLanguage), MySqlHelper.EscapeString("T")));

                sCommand.Append(string.Join(",", Rows));
                sCommand.Append(";");

                using (MySqlCommand myCmd = new MySqlCommand(sCommand.ToString(), connectionString.getConnection()))
                {
                    myCmd.CommandType = CommandType.Text;
                    myCmd.ExecuteNonQuery();
                }
                App_Helpers.NotificationHandler nh = new App_Helpers.NotificationHandler();
                nh.Invite("byOther", translatorEmail, user.UserName, "Translator", "Translator");

                bool _res = false;
                mailsend objMail = new mailsend();
                _res = objMail.mailSend(user2.UserName, user2.Email, "0", null, 0, finalString);

                translatorId = "success";
            }
            catch
            {

            }
            finally
            {
                connectionString.connectionClose();
            }

            return translatorId;
        }

        public string submitagencyOrTrans(string aemail, string _flag, string ddltype, string agencyname, string aname, int totalcnt, int count)
        {
            IdentityUser user = System.Web.HttpContext.Current.Session.GetDataFromSession<IdentityUser>("User");
            connectionString.connectionOpen();

            string returnValue = string.Empty;
            string query = string.Empty;
            try
            {
                if (ddltype == "Agency")
                {
                    if (_flag == "0")
                    {
                        query = "insert into tbl_organizationagencymap (agencyid,organizationid) values (" + Convert.ToInt16(agencyname) + ",'" + user.UserId + "')";
                        MySqlCommand com = new MySqlCommand(query, connectionString.getConnection());
                        com.ExecuteNonQuery();
                    }
                    else
                    {
                        query = "insert into tbl_agencydetails (AgencyName,EmailId) values ('" + aname + "','" + aemail + "')";
                        MySqlCommand com = new MySqlCommand(query, connectionString.getConnection());
                        com.ExecuteNonQuery();
                        long _aid = com.LastInsertedId;
                        string query1 = "insert into tbl_organizationagencymap (agencyid,organizationid) values (" + Convert.ToInt16(_aid) + ",'" + user.UserId + "')";
                        MySqlCommand com1 = new MySqlCommand(query1, connectionString.getConnection());
                        com1.ExecuteNonQuery();
                    }

                }
                else if (ddltype == "Translator")
                {
                    if (_flag == "0")
                    {
                        query = "insert into tbl_organizationtranslatormap (translatorId,organizationid) values (" + Convert.ToInt16(agencyname) + ",'" + user.UserId + "')";
                        MySqlCommand com = new MySqlCommand(query, connectionString.getConnection());
                        com.ExecuteNonQuery();
                    }
                    else
                    {
                        query = "insert into tbl_translatordetails (TransltrName,EmailId) values ('" + aname + "','" + aemail + "')";
                        MySqlCommand com = new MySqlCommand(query, connectionString.getConnection());
                        com.ExecuteNonQuery();
                        long _aid = com.LastInsertedId;
                        string query1 = "insert into tbl_organizationtranslatormap (translatorId,organizationid) values (" + Convert.ToInt16(_aid) + ",'" + user.UserId + "')";
                        MySqlCommand com1 = new MySqlCommand(query1, connectionString.getConnection());
                        com1.ExecuteNonQuery();
                    }
                }

                App_Code.mailsend obj = new App_Code.mailsend();
                obj.mailSend("Agency", aemail, ddltype, user.UserId.ToString(), 0);
                returnValue = "Agency added successfully";
            }
            catch (Exception e)
            {
                returnValue = "Some error occurred.";
            }
            finally
            {
                connectionString.connectionClose();
            }

            return returnValue;
        }

        //POST
        public string assignprojectmail(string email, string ProjectName)
        {
            IdentityUser user = System.Web.HttpContext.Current.Session.GetDataFromSession<IdentityUser>("User");
            DataSet ds = new DataSet();
            string _value = string.Empty;
            connectionString.connectionOpen();
            try
            {
                string str = "Select `UserName`,`UserId` from `tbl_users` where `Email` = '" + email + "';";
                MySqlDataAdapter da = new MySqlDataAdapter(str, connectionString.getConnection());

                da.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    App_Code.mailsend obj = new App_Code.mailsend();
                    obj.mailSend(ProjectName, email, "", user.UserId.ToString(), 0);
                }
                else
                {
                    App_Code.mailsend obj = new App_Code.mailsend();
                    obj.mailSend(ProjectName, email, "Developer", user.UserId.ToString(), 0);
                }
                _value = "1";
            }
            catch
            {
                _value = "0";
            }
            finally
            {
                connectionString.connectionClose();
            }
            return _value;
        }

        public string submitagency(string aname, string aemail, string _flag)
        {
            IdentityUser user = System.Web.HttpContext.Current.Session.GetDataFromSession<IdentityUser>("User");
            string returnValue = "";
            connectionString.connectionOpen();

            string query = "";

            try
            {
                if (_flag == "0")
                {
                    query = "insert into tbl_organizationagencymap (agencyid,organizationid) values (" + Convert.ToInt16(aname) + ",'" + user.UserId + "')";
                    MySqlCommand com = new MySqlCommand(query, connectionString.getConnection());
                    com.ExecuteNonQuery();


                }
                else
                {
                    query = "insert into tbl_agencydetails (AgencyName,EmailId) values ('" + aname + "','" + aemail + "')";
                    MySqlCommand com = new MySqlCommand(query, connectionString.getConnection());
                    com.ExecuteNonQuery();
                    long _aid = com.LastInsertedId;
                    string query1 = "insert into tbl_organizationagencymap (agencyid,organizationid) values (" + Convert.ToInt16(_aid) + ",'" + user.UserId + "')";
                    MySqlCommand com1 = new MySqlCommand(query1, connectionString.getConnection());
                    com1.ExecuteNonQuery();
                }
                App_Code.mailsend obj = new App_Code.mailsend();
                obj.mailSend("Agency", aemail, "Agency", user.UserId.ToString(), 0);
                returnValue = "Agency added successfully";
            }
            catch
            {
                returnValue = "Some error occurred.";
            }
            finally
            {
                connectionString.connectionClose();
            }


            return returnValue;

        }
        //Get
        public string GetProjectFileCount(string pid)
        {
            string _count = "0";
            try
            {
                IdentityUser user = System.Web.HttpContext.Current.Session.GetDataFromSession<IdentityUser>("User");
                DataTable dt = new DataTable();

                string retTable = string.Empty;
                string getStr1 = "Select count(id)  from tbl_filedetails where ProjectId = " + Convert.ToInt16(pid) + ";";
                connectionString.connectionOpen();
                MySqlDataAdapter da = new MySqlDataAdapter(getStr1, connectionString.getConnection());

                da.Fill(dt);
                connectionString.connectionClose();
                dt.TableName = "data";
                _count = dt.Rows[0][0].ToString();
            }
            catch
            {
                _count = "0";
            }
            return _count;
        }
        public string GetSameLanguageFileCount(string pid, string langId)
        {
            string _count = "0";
            try
            {
                IdentityUser user = System.Web.HttpContext.Current.Session.GetDataFromSession<IdentityUser>("User");
                DataTable dt = new DataTable();

                string retTable = string.Empty;
                string getStr1 = "Select count(id)  from tbl_filedetails where ProjectId = " + Convert.ToInt16(pid) + ";";
                connectionString.connectionOpen();
                MySqlDataAdapter da = new MySqlDataAdapter(getStr1, connectionString.getConnection());

                da.Fill(dt);
                connectionString.connectionClose();
                dt.TableName = "data";
                _count = dt.Rows[0][0].ToString();
            }
            catch
            {
                _count = "0";
            }
            return _count;
        }

        public string GetFiles(int pid)
        {
            string str1;
            connectionString.connectionOpen();


            try
            {
                IdentityUser user = System.Web.HttpContext.Current.Session.GetDataFromSession<IdentityUser>("User");
                DataTable dt = new DataTable();

                string retTable = string.Empty;
                string getStr1 = "Select f.Target_lang, f.RelPath, f.repeatedWordUnitCost, f.newWordUnitCost, f.ProjectId,f.Id, f.TotalWord, f.RepeatedWord, f.TMWordCount, f.TranslationRequired, CONCAT_WS('', f.ChildFileName, f.FileType) as 'ChildFileName', f.Status, cm.Symbol, WP.Progress  from tbl_filedetails f, tbl_project p, v_Progress WP, tbl_currencymaster cm where p.ProjectId = f.ProjectId and f.ProjectId = " + pid + " and f.Id = WP.FileId and cm.CurrencyId = f.CurrencyId and f.ChildFileName not like '%+M%';";

                MySqlDataAdapter da = new MySqlDataAdapter(getStr1, connectionString.getConnection());
                da.Fill(dt);
                connectionString.connectionClose();
                dt.TableName = "data";
                str1 = DataTableToJSONWithJavaScriptSerializerDT(dt);
            }
            catch (Exception ex)
            {
                str1 = ex.Message;
            }
            return str1;
        }

        public string GetFiles1(int pid)
        {
            string str1;
            try
            {
                IdentityUser user = System.Web.HttpContext.Current.Session.GetDataFromSession<IdentityUser>("User");
                DataTable dt = new DataTable();

                string retTable = string.Empty;
                string getStr1 = "Select f.ProjectId,f.Id, f.TotalWord, f.RepeatedWord, f.TMWordCount, f.TranslationRequired, CONCAT_WS('', f.ChildFileName, f.FileType) as 'ChildFileName', f.Status, WP.Progress  from tbl_filedetails f, tbl_project p,v_Progress WP where p.ProjectId = f.ProjectId and f.ProjectId = " + pid + " and f.Id = WP.FileId;";
                connectionString.connectionOpen();
                MySqlDataAdapter da = new MySqlDataAdapter(getStr1, connectionString.getConnection());

                da.Fill(dt);
                connectionString.connectionClose();
                dt.TableName = "data";
                str1 = DataTableToJSONWithJavaScriptSerializerDT(dt);

            }
            catch (Exception ex)
            {
                str1 = ex.Message;
            }
            return str1;
        }

        //POST
        public Int32 GetFileId(int pid)
        {
            Int32 fileId = 0;

            IdentityUser user = System.Web.HttpContext.Current.Session.GetDataFromSession<IdentityUser>("User");
            DataTable dt = new DataTable();

            string retTable = string.Empty;
            string getStr1 = "Select f.ProjectId,f.Id, f.TotalWord, f.RepeatedWord, f.TMWordCount, f.TranslationRequired, f.ChildFileName, f.Status, WP.Progress  from tbl_filedetails f, tbl_project p,v_Progress WP where p.ProjectId = f.ProjectId and f.ProjectId = " + pid + " and f.Id = WP.FileId;";
            connectionString.connectionOpen();
            MySqlDataAdapter da = new MySqlDataAdapter(getStr1, connectionString.getConnection());

            da.Fill(dt);
            connectionString.connectionClose();
            dt.TableName = "data";
            if (dt.Rows.Count > 0)
                fileId = Convert.ToInt32(dt.Rows[0][1].ToString());

            return fileId;
        }

        public string DataTableToJSONWithJavaScriptSerializerDT(DataTable table)
        {
            JavaScriptSerializer jsSerializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> parentRow = new List<Dictionary<string, object>>();
            Dictionary<string, object> childRow;

            foreach (DataRow row in table.Rows)
            {
                childRow = new Dictionary<string, object>();
                foreach (DataColumn col in table.Columns)
                {
                    childRow.Add(col.ColumnName, row[col]);
                }
                parentRow.Add(childRow);
            }

            return jsSerializer.Serialize(parentRow);
        }

        public string DataTableToJSONWithJavaScriptSerializerDS(DataSet table)
        {
            JavaScriptSerializer jsSerializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> parentRow = new List<Dictionary<string, object>>();
            Dictionary<string, object> childRow;

            foreach (DataTable tbl in table.Tables)
            {
                foreach (DataRow row in tbl.Rows)
                {
                    childRow = new Dictionary<string, object>();
                    foreach (DataColumn col in tbl.Columns)
                    {
                        childRow.Add(col.ColumnName, row[col]);
                    }
                    parentRow.Add(childRow);
                }
            }
            return jsSerializer.Serialize(parentRow);
        }

        public string getTName(string fid)
        {
            string val = string.Empty;
            try
            {
                DataTable dt = new DataTable();

                string retTable = string.Empty;
                string getStr1 = "SELECT t.TransltrName FROM tbl_translatordetails t,tbl_assignproject a where a.assignto = t.UserId and a.fileid = " + fid + " and a.status = 'Y';";
                connectionString.connectionOpen();
                MySqlDataAdapter da = new MySqlDataAdapter(getStr1, connectionString.getConnection());

                da.Fill(dt);
                connectionString.connectionClose();


                val = dt.Rows[0][0].ToString();
            }
            catch (Exception ex)
            {
                val = ex.Message;
            }
            finally
            {
                connectionString.connectionClose();
            }
            return val;
        }

        public string getTrnslrTaskName(string fid)
        {
            string val = string.Empty;
            try
            {
                DataSet ds = new DataSet();

                string retTable = string.Empty;
                string getStr1 = "SELECT a.taskname, t.TransltrName FROM tbl_assignproject a INNER JOIN tbl_translatordetails t ON t.TransltrId = a.TAssignTo WHERE a.fileid = " + fid + " and a.TStatus = 'In Translation';";
                connectionString.connectionOpen();
                MySqlDataAdapter da = new MySqlDataAdapter(getStr1, connectionString.getConnection());

                da.Fill(ds);
                connectionString.connectionClose();

                foreach (DataRow item in ds.Tables[0].Rows)
                {
                    val = val + "<br /><b><u>" + item["taskname"] + ":</u></b> " + item["TransltrName"] + "<br />";
                }
            }
            catch (Exception ex)
            {
                val = ex.Message;
            }
            finally
            {
                connectionString.connectionClose();
            }
            return val;
        }

        public string GetChildFiles(string pid, string TargetLang)
        {
            string str1;
            try
            {
                IdentityUser user = System.Web.HttpContext.Current.Session.GetDataFromSession<IdentityUser>("User");
                DataTable dt = new DataTable();

                string retTable = string.Empty;
                string getStr1 = "Select f.Id, f.ProjectId, f.TotalWord, f.RepeatedWord, f.TMWordCount, f.TranslationRequired, f.ChildFileName, f.Status, WP.Progress, lm.LangISOName,f.Target_lang as TargetLanguageID, f.FileType, f.DeleteFile from tbl_filedetails f, tbl_project p,v_Progress WP, tbl_projectlangmap pl, tbl_langmaster lm where p.ProjectId = f.ProjectId and f.ProjectId = " + Convert.ToInt32(pid) + " and f.Id = WP.FileId and pl.LangId = f.Target_lang and f.ProjectId = pl.ProjectId and lm.LangId = pl.LangId and f.ChildFileName not like '%+M%';";

                connectionString.connectionOpen();
                MySqlDataAdapter da = new MySqlDataAdapter(getStr1, connectionString.getConnection());

                da.Fill(dt);
                connectionString.connectionClose();

                dt.TableName = "data";
                str1 = DataTableToJSONWithJavaScriptSerializerDT(dt);
            }
            catch (Exception ex)
            {
                str1 = ex.Message;
            }
            return str1;
        }

        public int GetTaskCount(string pid)
        {
            int cnt = 1;
            try
            {
                DataSet ds = new DataSet();

                string retTable = string.Empty;
                string getStr1 = "SELECT * FROM tbl_projecttask WHERE ProjectID = '" + pid + "';";
                connectionString.connectionOpen();
                MySqlDataAdapter da = new MySqlDataAdapter(getStr1, connectionString.getConnection());

                da.Fill(ds);
                connectionString.connectionClose();

                cnt = ds.Tables[0].Rows.Count;
            }
            catch
            {

            }
            return cnt;
        }

        //POST
        public string GetTranslatorFiles(int pid)
        {
            string str1;
            try
            {
                IdentityUser user = System.Web.HttpContext.Current.Session.GetDataFromSession<IdentityUser>("User");
                DataTable dt = new DataTable();

                string retTable = string.Empty;
                string getStr1 = "Select f.ProjectId, f.Cost, f.Id, f.TotalWord, f.TranslationRequired, f.RepeatedWord, f.newWordUnitCost, f.repeatedWordUnitCost, f.TMWordCount, f.ChildFileName, f.Status, WP.Progress  from tbl_filedetails f, tbl_project p,v_Progress WP where p.ProjectId = f.ProjectId and f.Id = " + pid + " and f.Id = WP.FileId;";
                connectionString.connectionOpen();
                MySqlDataAdapter da = new MySqlDataAdapter(getStr1, connectionString.getConnection());

                da.Fill(dt);
                connectionString.connectionClose();
                dt.TableName = "data";
                str1 = DataTableToJSONWithJavaScriptSerializerDT(dt);
            }
            catch (Exception ex)
            {
                str1 = ex.Message;
            }
            return str1;
        }

        //GET
        [HttpGet]
        public ActionResult ProjectForTranslation()
        {
            IdentityUser user = System.Web.HttpContext.Current.Session.GetDataFromSession<IdentityUser>("User");
            if (user == null)
            {
                return RedirectToAction("Login", "Account");
            }
            ProjectViewModel model = new ProjectViewModel();
            var ID = Request.RequestContext.RouteData.Values["id"];
            connectionString.connectionOpen();

            DataSet ds = new DataSet();
            string str = "SELECT tbl_filedetails.Id,tbl_filedetails.ParentFileName,tbl_filedetails.TotalWord, tbl_filedetails.RepeatedWord,tbl_filedetails.TMWordCount,tbl_filedetails.TranslationRequired,tbl_filedetails.`Status`,DATE_FORMAT(tbl_filedetails.CompletionDate, '%Y-%m-%d') as `CompletionDate`,lm.LangISOName SourceLang,lm2.LangISOName TargetLang,WP.Progress,tbl_filedetails.Cost FROM tbl_filedetails, tbl_langmaster lm,  tbl_langmaster lm2,v_Progress WP where tbl_filedetails.Source_lang = lm.LangId AND tbl_filedetails.Target_lang = lm2.LangId AND tbl_filedetails.Id = WP.FileId And tbl_filedetails.ProjectId = " + Convert.ToInt32(ID) + ";";
            MySqlDataAdapter da = new MySqlDataAdapter(str, connectionString.getConnection());
            da.Fill(ds);
            // ds.Tables[0].Columns.Add("Cost", typeof(string));
            connectionString.connectionClose();

            ViewBag.List = ds.Tables[0];
            return View();
        }

        //GET
        [HttpGet]
        public string FetchingCost(string ORG, string ProjId, string FileId)
        {
            IdentityUser user = System.Web.HttpContext.Current.Session.GetDataFromSession<IdentityUser>("User");
            ProjectViewModel model = new ProjectViewModel();
            var ID = Request.RequestContext.RouteData.Values["id"];
            connectionString.connectionOpen();

            DataTable ds = new DataTable();


            DataSet dss = new DataSet();
            string strr = "Select `UserId` from `tbl_users` where `UserName` = '" + ORG + "';";
            MySqlDataAdapter daa = new MySqlDataAdapter(strr, connectionString.getConnection());
            daa.Fill(dss);
            int id = Convert.ToInt32(dss.Tables[0].Rows[0][0]);

            //DataSet dsss = new DataSet();
            //string strrr = "Select `Id` from `tbl_filedetails` where `ChildFileName` = '" + Filename + "';";
            //MySqlDataAdapter daaa = new MySqlDataAdapter(strr, connectionString.getConnection());
            //daaa.Fill(dsss);
            //int Fileid = Convert.ToInt32(dss.Tables[0].Rows[0][0]);

            string str = "SELECT tbl_filedetails.Id,tbl_filedetails.ParentFileName,tbl_filedetails.TotalWord, tbl_filedetails.RepeatedWord,tbl_filedetails.TMWordCount,tbl_filedetails.TranslationRequired, tbl_filedetails.`Status`,tbl_filedetails.CompletionDate,lm.LangISOName SourceLang, lm2.LangISOName TargetLang,WP.Progress, (((tbl_filedetails.RepeatedWord)*(duplicateWords.cost)) + ((tbl_filedetails.TranslationRequired)*(NewTranlation.cost))) Cost, tbl_currencymaster.Symbol FROM tbl_filedetails, tbl_langmaster lm, tbl_langmaster lm2,v_Progress WP, (Select tbl_costusermap.rateperunit cost from tbl_costusermap where costid = 1 AND tbl_costusermap.userid = " + id + " ) NewTranlation,(Select tbl_costusermap.rateperunit cost from tbl_costusermap where costid = 3 AND tbl_costusermap.userid = " + id + ") duplicateWords, tbl_currencymaster,tbl_costusermap where tbl_filedetails.Source_lang = lm.LangId AND tbl_filedetails.Target_lang = lm2.LangId AND tbl_filedetails.Id = WP.FileId And tbl_filedetails.ProjectId = " + Convert.ToInt32(ProjId) + " and tbl_filedetails.Id = '" + FileId + "' And tbl_currencymaster.CurrencyId = tbl_costusermap.CurrencyId group by tbl_currencymaster.Symbol; ";
            MySqlDataAdapter da = new MySqlDataAdapter(str, connectionString.getConnection());
            da.Fill(ds);
            ViewBag.isCost = "t";

            connectionString.connectionClose();
            string str1;
            DataTable dtt = new DataTable();
            dtt.Columns.Add("Cost");
            dtt.Columns.Add("Symbol");
            DataRow dr = dtt.NewRow();
            dr["Cost"] = ds.Rows[0][11];
            dr["Symbol"] = ds.Rows[0][12];
            dtt.Rows.Add(dr);
            //if (ds.Rows[0][11].ToString() != null || ds.Rows[0][11].ToString() != "")
            //{
            //    string cost = Convert.ToString(ds.Rows[0][11]);
            //    string symbol = Convert.ToString(ds.Rows[0][12]);
            //    str1 = symbol + cost;
            //}
            //else
            //{
            //    str1 = "";
            //}
            dtt.TableName = "data";
            str1 = DataTableToJSONWithJavaScriptSerializerDT(dtt);

            return str1;
        }

        //POST
        [HttpPost]
        [AllowAnonymous]
        public string ProjectSendForTranslation(int Id, string Source, string Destination, string PreferredAgency, string AgencyName, string TranslatorName, string CompletionDate, string CostValue, string CostSymbol, ProjectViewModel model)
        {
            string _value = string.Empty;
            try
            {
                connectionString.connectionOpen();

                DateTime Date = DateTime.Parse(CompletionDate, CultureInfo.InvariantCulture);
                string completedate = Date.ToString("yyyy-MM-dd HH:mm:ss");
                IdentityUser user = System.Web.HttpContext.Current.Session.GetDataFromSession<IdentityUser>("User");
                DataSet dsss = new DataSet();
                string strrr = "select `Id` from `tbl_filedetails` where `ProjectId`=" + Id + " and `ChildFileName` like '%" + Destination + "' ;";
                connectionString.connectionOpen();
                MySqlDataAdapter daaa = new MySqlDataAdapter(strrr, connectionString.getConnection());

                daaa.Fill(dsss);
                if (dsss.Tables[0].Rows.Count == 0)
                {
                    _value = "-1";
                }
                else
                {
                    string st = "Update `tbl_project` set `Status` = 'Project Send' where `ProjectId` = " + Id + ";";
                    MySqlCommand com = new MySqlCommand(st, connectionString.getConnection());
                    com.ExecuteNonQuery();
                    for (int i = 0; i < dsss.Tables[0].Rows.Count; i++)
                    {
                        var FileId = dsss.Tables[0].Rows[i][0];

                        DataSet dst = new DataSet();
                        string strg = "select `CurrencyId` from `tbl_currencymaster` where `Symbol`= '" + CostSymbol + "';";
                        MySqlDataAdapter dad = new MySqlDataAdapter(strg, connectionString.getConnection());
                        dad.Fill(dst);
                        var CurrencyId = dst.Tables[0].Rows[0][0];

                        //if (PreferredAgency != "Select")
                        //{
                        //    DataSet ds = new DataSet();
                        //    string str = "select `AgencyId` from `tbl_agencydetails` where `AgencyName` = '" + PreferredAgency + "';";
                        //    connectionString.connectionOpen();
                        //    MySqlDataAdapter da = new MySqlDataAdapter(str, connectionString.getConnection());
                        //    
                        //    da.Fill(ds);
                        //    var prfrdAgencyId = ds.Tables[0].Rows[0][0];

                        //    string query = "UPDATE `tbl_projectassignment` SET `AgencyId` = " + prfrdAgencyId + " , `AssignDate`='" + DateTime.Now.ToString("yyyy-MM-dd") + "', `CompletionDate`= '" + CompletionDate + "' where `FileId` = " + FileId + ";";
                        //    MySqlCommand com1 = new MySqlCommand(query, connectionString.getConnection());
                        //    com1.ExecuteNonQuery();

                        //    string query1 = "UPDATE `tbl_filedetails` SET `Status` = 'Project Send' where `Id` = " + FileId + ";";
                        //    MySqlCommand com2 = new MySqlCommand(query1, connectionString.getConnection());
                        //    com2.ExecuteNonQuery();
                        //}
                        if (AgencyName != null && AgencyName != "")
                        {
                            DataSet ds = new DataSet();
                            string str = "select `EmailId`, `UserId` from `tbl_agencydetails` where `AgencyId` = '" + AgencyName + "';";
                            MySqlDataAdapter da = new MySqlDataAdapter(str, connectionString.getConnection());
                            da.Fill(ds);
                            var email = ds.Tables[0].Rows[0][0];
                            var userid = ds.Tables[0].Rows[0][1];

                            DataSet dss = new DataSet();
                            string strr = "select `ProjectId` from `tbl_filedetails` where `Id` = '" + FileId + "';";
                            MySqlDataAdapter daa = new MySqlDataAdapter(strr, connectionString.getConnection());
                            daa.Fill(dss);
                            var projectid = dss.Tables[0].Rows[0][0];

                            string query = "UPDATE `tbl_projectassignment` SET `AgencyId` = " + AgencyName + " , `AssignDate`='" + DateTime.Now.ToString("yyyy-MM-dd") + "',  `CompletionDate`= '" + completedate + "' where `FileId` = " + FileId + ";";
                            MySqlCommand com1 = new MySqlCommand(query, connectionString.getConnection());
                            com1.ExecuteNonQuery();

                            string query1 = "UPDATE `tbl_filedetails` SET `Status` = 'Project Send', `Cost`='" + CostValue + "', `CurrencyId` = '" + Convert.ToInt32(CurrencyId) + "' where `Id` = " + FileId + ";";
                            MySqlCommand com2 = new MySqlCommand(query1, connectionString.getConnection());
                            com2.ExecuteNonQuery();

                            string query2 = "Insert into `tbl_assignproject` (`ownerid`,`assignto`,`useremail`,`projectid`,`status`,`assigndate`,`userid`,`fileid`) values (" + user.UserId + ", '" + userid + "','" + email + "', " + projectid + ", 'N', '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','" + userid + "','" + FileId + "');";
                            MySqlCommand com3 = new MySqlCommand(query2, connectionString.getConnection());
                            com3.ExecuteNonQuery();
                        }
                        if (TranslatorName != null)
                        {
                            DataSet ds = new DataSet();
                            string str = "select `EmailId`, `UserId` from `tbl_translatordetails` where `TransltrId` = '" + TranslatorName + "';";
                            MySqlDataAdapter da = new MySqlDataAdapter(str, connectionString.getConnection());
                            da.Fill(ds);
                            var email = ds.Tables[0].Rows[0][0];
                            var userid = ds.Tables[0].Rows[0][1];

                            DataSet dss = new DataSet();
                            string strr = "select `ProjectId` from `tbl_filedetails` where `Id` = '" + FileId + "';";
                            MySqlDataAdapter daa = new MySqlDataAdapter(strr, connectionString.getConnection());
                            daa.Fill(dss);
                            var projectid = dss.Tables[0].Rows[0][0];

                            string query = "UPDATE `tbl_projectassignment` SET `TranslatorId` = " + TranslatorName + " , `AssignDate`='" + DateTime.Now.ToString("yyyy-MM-dd") + "',  `CompletionDate`= '" + completedate + "' where `FileId` = " + FileId + ";";
                            MySqlCommand com1 = new MySqlCommand(query, connectionString.getConnection());
                            com1.ExecuteNonQuery();

                            string query1 = "UPDATE `tbl_filedetails` SET `Status` = 'Project Send', `Cost`='" + CostValue + "', `CurrencyId` = '" + Convert.ToInt32(CurrencyId) + "' where `Id` = " + FileId + ";";
                            MySqlCommand com2 = new MySqlCommand(query1, connectionString.getConnection());
                            com2.ExecuteNonQuery();

                            string query2 = "Insert into `tbl_assignproject` (`ownerid`,`assignto`,`useremail`,`projectid`,`status`,`assigndate`,`userid`,`fileid`) values (" + user.UserId + ", '" + userid + "','" + email + "', " + projectid + ", 'N', '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','" + userid + "','" + FileId + "');";
                            MySqlCommand com3 = new MySqlCommand(query2, connectionString.getConnection());
                            com3.ExecuteNonQuery();
                        }
                    }

                    ViewBag.Message = true;
                    _value = "1";
                }

            }
            catch (Exception ex)
            {
                _value = "0";
                return ex.Message;
            }
            finally
            {
                connectionString.connectionClose();
            }
            return _value;
        }

        public string checkTNameExist(int Id, string TranslatorName)
        {
            string _value = "N";

            connectionString.connectionOpen();


            var tn = TranslatorName.Split('-');

            if (TranslatorName != null && TranslatorName != "0")
            {
                DataSet dss = new DataSet();
                string strr = "SELECT * FROM tbl_assignproject where TAssignTo = '" + tn[1] + "' and fileid = '" + Id + "' and TStatus = 'In Translation';";
                MySqlDataAdapter daa = new MySqlDataAdapter(strr, connectionString.getConnection());
                daa.Fill(dss);

                int cnt = dss.Tables[0].Rows.Count;

                if (cnt > 0)
                {
                    _value = "Y";
                }
            }

            return _value;
        }

        //POST
        [HttpPost]
        [AllowAnonymous]
        public string TranslationProjectSend(int Id, string TranslatorName, string CompletionDate, int IncrementValue)
        {
            string _value = string.Empty;
            string AssignDate = string.Empty;

            connectionString.connectionOpen();

            try
            {
                AssignDate = DateTime.Now.ToString("yyyy-MM-dd");
            }
            catch (Exception ex)
            {
                _value = ex.Message + "1";
            }

            IdentityUser user = System.Web.HttpContext.Current.Session.GetDataFromSession<IdentityUser>("User");

            var tn = TranslatorName.Split('-');

            if (TranslatorName == "0")
            {
                return "1";
            }


            //Utility.Common common = new Utility.Common();
            //int srno = common.getValue(tn[0], IncrementValue);
            int srno = IncrementValue;

            if (TranslatorName != null)
            {
                DataSet ds = new DataSet();
                string str = "select `EmailId`, `UserId` from `tbl_translatordetails` where `TransltrId` = '" + tn[1] + "';";
                MySqlDataAdapter da = new MySqlDataAdapter(str, connectionString.getConnection());
                da.Fill(ds);
                var email = ds.Tables[0].Rows[0][0];
                var userid = ds.Tables[0].Rows[0][1];

                DataSet dss = new DataSet();
                string strr = "select `ProjectId` from `tbl_filedetails` where `Id` = '" + Id + "';";
                MySqlDataAdapter daa = new MySqlDataAdapter(strr, connectionString.getConnection());
                daa.Fill(dss);
                var projectid = dss.Tables[0].Rows[0][0];

                string query = "UPDATE `tbl_projectassignment` SET `TranslatorId` = " + tn[1] + " , `AssignDate`='" + AssignDate + "' where `FileId` = " + Id + ";";
                try
                {
                    MySqlCommand com1 = new MySqlCommand(query, connectionString.getConnection());
                    com1.ExecuteNonQuery();
                    _value = "1";
                }
                catch (Exception ex)
                {
                    _value = ex.Message + query;
                }

                string query1 = "UPDATE `tbl_projecttask` SET `AssignTo` = " + tn[1] + " WHERE ProjectID = " + projectid + " AND Task = '" + tn[0] + "';";
                try
                {
                    MySqlCommand com2 = new MySqlCommand(query1, connectionString.getConnection());
                    com2.ExecuteNonQuery();
                    _value = "1";
                }
                catch (Exception ex)
                {
                    _value = ex.Message + query;
                }

                string query2 = "Insert into `tbl_assignproject` (`ownerid`,`assignto`,`useremail`,`projectid`,`status`,`assigndate`,`userid`,`fileid`,`taskname`,`TAssignTo`,`SequenceNo`,`TaskID`) values (" + user.UserId + ", '" + userid + "','" + email + "', " + projectid + ", 'N', '" + AssignDate + "','" + userid + "','" + Id + "','" + tn[0] + "','" + tn[1] + "','" + srno + "','" + tn[2] + "');";
                try
                {
                    MySqlCommand com3 = new MySqlCommand(query2, connectionString.getConnection());
                    com3.ExecuteNonQuery();
                    _value = "1";
                }
                catch (Exception ex)
                {
                    _value = ex.Message + query2;
                }
                connectionString.connectionClose();
                NotificationHandler nh = new NotificationHandler();
                nh.AgencyAssignedToTranslatorNotification("assigned", user.UserId.ToString(), user.UserName, user.Email, projectid.ToString(), tn[1]);
            }
            return _value;
        }

        //POST
        [HttpPost]
        public string filecancel(string comment, string fid)
        {
            string _value = string.Empty;
            connectionString.connectionOpen();
            try
            {

                string str = "Update `tbl_filedetails` set `Comment` = '" + comment + "', `Status`= 'Canceled' where `Id` = " + Convert.ToInt16(fid) + ";";
                MySqlCommand com = new MySqlCommand(str, connectionString.getConnection());
                com.ExecuteNonQuery();
                _value = "1";
            }
            catch
            {
                _value = "0";
            }
            finally
            {
                connectionString.connectionClose();
            }
            return _value;
        }

        //GET
        [HttpGet]
        public string getTranslatorNames(string Source, string Destination)
        {
            IdentityUser user = System.Web.HttpContext.Current.Session.GetDataFromSession<IdentityUser>("User");

            DataSet ds = new DataSet();
            string str = "SELECT `LangId` from `tbl_langmaster` where `LangISOName` = '" + Source + "';";
            connectionString.connectionOpen();
            MySqlDataAdapter da = new MySqlDataAdapter(str, connectionString.getConnection());

            da.Fill(ds);
            var srcLangId = ds.Tables[0].Rows[0][0];

            DataSet dss = new DataSet();
            string strr = "SELECT `LangId` from `tbl_langmaster` where `LangISOName` = '" + Destination + "';";
            MySqlDataAdapter daa = new MySqlDataAdapter(strr, connectionString.getConnection());
            daa.Fill(dss);
            var destLangId = dss.Tables[0].Rows[0][0];

            DataSet dsQuery = new DataSet();

            string query = "SELECT t.TransltrId, t.TransltrName FROM tbl_translatordetails t LEFT JOIN tbl_transltrlangmap tm ON tm.TransltrId = t.TransltrId LEFT JOIN tbl_transltrlangmap tm1 ON tm1.TransltrId = t.TransltrId LEFT JOIN tbl_assignagencytranslator aat ON aat.TranslatorID = t.TransltrId WHERE aat.UserID = '" + user.UserId + "' AND ((tm.LangId = '" + srcLangId + "' AND tm.Type = 'S') AND (tm1.LangId = '" + destLangId + "' AND tm1.Type = 'T'));";
            MySqlDataAdapter daQuery = new MySqlDataAdapter(query, connectionString.getConnection());
            daQuery.Fill(dsQuery);

            List<ListItem> ddl = new List<ListItem>();

            string constr = ConfigurationManager.ConnectionStrings["loginConn"].ToString();
            using (MySqlConnection conn = new MySqlConnection(constr))
            {
                using (MySqlCommand cmd = new MySqlCommand(query))
                {

                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    conn.Open();
                    using (MySqlDataReader sdr = cmd.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            ddl.Add(new ListItem
                            {
                                Value = sdr["TransltrId"].ToString(),
                                Text = sdr["TransltrName"].ToString()
                            });
                        }
                    }
                    conn.Close();
                    JavaScriptSerializer jSearializer = new JavaScriptSerializer();
                    return jSearializer.Serialize(ddl);
                }
            }
        }

        public int setTranslator(string pid)
        {
            int val = 0;

            DataSet ds = new DataSet();
            string str = "SELECT TAssignTo FROM tbl_assignproject WHERE projectid = '" + pid + "' AND TAssignTo != 0 ORDER BY Id DESC LIMIT 1;";
            connectionString.connectionOpen();
            MySqlDataAdapter da = new MySqlDataAdapter(str, connectionString.getConnection());

            da.Fill(ds);

            if (ds.Tables[0].Rows.Count > 0)
            {
                val = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
            }

            return val;
        }

        //GET
        [HttpGet]
        public string getTranslatorNames1(string Source, string Destination)
        {
            string finalresult = string.Empty;
            DataSet dsFinal = new DataSet();
            DataSet ds = new DataSet();
            string str = "SELECT `LangId` from `tbl_langmaster` where `LangISOName` = '" + Source + "';";
            connectionString.connectionOpen();
            MySqlDataAdapter da = new MySqlDataAdapter(str, connectionString.getConnection());

            da.Fill(ds);
            var srcLangId = ds.Tables[0].Rows[0][0];

            DataSet dss = new DataSet();
            string strr = "SELECT `LangId` from `tbl_langmaster` where `LangISOName` = '" + Destination + "';";

            MySqlDataAdapter daa = new MySqlDataAdapter(strr, connectionString.getConnection());

            daa.Fill(dss);
            var destLangId = dss.Tables[0].Rows[0][0];
            string query = string.Empty;
            query = "Select Source.TransltrId, tbl_translatordetails.TransltrName from (Select TransltrId from tbl_transltrlangmap where Type = 'S' and LangId = '" + srcLangId + "') Source,(Select TransltrId from tbl_transltrlangmap where Type = 'T' and LangId ='" + destLangId + "') Target,tbl_translatordetails where Source.TransltrId = Target.TransltrId AND Source.TransltrId = tbl_translatordetails.TransltrId";


            MySqlDataAdapter daa1 = new MySqlDataAdapter(query, connectionString.getConnection());

            daa1.Fill(dsFinal);

            connectionString.connectionClose();

            finalresult = string.Empty;
            return finalresult;

        }

        //get data
        public string getData(string ddlid, string Source, string Destination)
        {
            DataSet ds = new DataSet();
            string str = "SELECT `LangId` from `tbl_langmaster` where `LangISOName` = '" + Source + "';";
            connectionString.connectionOpen();
            MySqlDataAdapter da = new MySqlDataAdapter(str, connectionString.getConnection());

            da.Fill(ds);
            var srcLangId = ds.Tables[0].Rows[0][0];

            DataSet dss = new DataSet();
            string strr = "SELECT `LangId` from `tbl_langmaster` where `LangISOName` = '" + Destination + "';";
            connectionString.connectionOpen();
            MySqlDataAdapter daa = new MySqlDataAdapter(strr, connectionString.getConnection());

            daa.Fill(dss);
            var destLangId = dss.Tables[0].Rows[0][0];

            List<ListItem> ddl = new List<ListItem>();
            string query = string.Empty;
            if (ddlid == "Agency")
            {
                query = "SELECT `AgencyName`,`AgencyId` from tbl_agencydetails where `UserId` IS NOT NULL and `AgencyName` IS NOT NULL and `AgencyName` !='';";
            }
            else if (ddlid == "Translator")
            {
                query = "Select Source.TransltrId, tbl_translatordetails.TransltrName from (Select TransltrId from tbl_transltrlangmap where Type = 'S' and LangId = '" + srcLangId + "') Source,(Select TransltrId from tbl_transltrlangmap where Type = 'T' and LangId ='" + destLangId + "') Target,tbl_translatordetails where Source.TransltrId = Target.TransltrId AND Source.TransltrId = tbl_translatordetails.TransltrId and tbl_translatordetails.UserId IS NOT NULL and tbl_translatordetails.TransltrName IS NOT NULL and tbl_translatordetails.TransltrName !=''";
            }
            else
            {
                return null;
            }
            string constr = ConfigurationManager.ConnectionStrings["loginConn"].ToString();
            using (MySqlConnection conn = new MySqlConnection(constr))
            {
                using (MySqlCommand cmd = new MySqlCommand(query))
                {

                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    conn.Open();
                    using (MySqlDataReader sdr = cmd.ExecuteReader())
                    {
                        if (ddlid == "Translator")
                            while (sdr.Read())
                            {
                                ddl.Add(new ListItem
                                {
                                    Value = sdr["TransltrId"].ToString(),
                                    Text = sdr["TransltrName"].ToString()
                                });
                            }

                        else
                            while (sdr.Read())
                            {
                                ddl.Add(new ListItem
                                {
                                    Value = sdr["AgencyId"].ToString(),
                                    Text = sdr["AgencyName"].ToString()
                                });
                            }
                    }
                    conn.Close();
                    System.Web.Script.Serialization.JavaScriptSerializer jSearializer =
                   new System.Web.Script.Serialization.JavaScriptSerializer();
                    return jSearializer.Serialize(ddl);
                }
            }
        }
        //get getdataforTranslation
        public string getdataforTranslation(string ddlid, string Source, string Destination)
        {
            DataSet ds = new DataSet();
            string str = "SELECT `LangId` from `tbl_langmaster` where `LangISOName` = '" + Source + "';";
            connectionString.connectionOpen();
            MySqlDataAdapter da = new MySqlDataAdapter(str, connectionString.getConnection());

            da.Fill(ds);
            var srcLangId = ds.Tables[0].Rows[0][0];

            DataSet dss = new DataSet();
            string strr = "SELECT `LangId` from `tbl_langmaster` where `LangISOName` = '" + Destination + "';";
            connectionString.connectionOpen();
            MySqlDataAdapter daa = new MySqlDataAdapter(strr, connectionString.getConnection());

            daa.Fill(dss);
            var destLangId = dss.Tables[0].Rows[0][0];

            List<ListItem> ddl = new List<ListItem>();
            string query = string.Empty;
            if (ddlid == "Agency")
            {
                query = "SELECT `AgencyName` from tbl_agencydetails";
            }
            else if (ddlid == "Translator")
            {
                query = "Select Source.TransltrId, tbl_translatordetails.TransltrName from (Select TransltrId from tbl_transltrlangmap where Type = 'S' and LangId = '" + srcLangId + "') Source,(Select TransltrId from tbl_transltrlangmap where Type = 'T' and LangId ='" + destLangId + "') Target,tbl_translatordetails where Source.TransltrId = Target.TransltrId AND Source.TransltrId = tbl_translatordetails.TransltrId";
            }
            else
            {
                return null;
            }
            string constr = ConfigurationManager.ConnectionStrings["loginConn"].ToString();
            using (MySqlConnection conn = new MySqlConnection(constr))
            {
                using (MySqlCommand cmd = new MySqlCommand(query))
                {

                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    conn.Open();
                    using (MySqlDataReader sdr = cmd.ExecuteReader())
                    {
                        if (ddlid == "Translator")
                            while (sdr.Read())
                            {
                                ddl.Add(new ListItem
                                {
                                    Value = sdr["TransltrName"].ToString(),
                                    Text = sdr["TransltrName"].ToString()
                                });
                            }

                        else
                            while (sdr.Read())
                            {
                                ddl.Add(new ListItem
                                {
                                    Value = sdr["AgencyName"].ToString(),
                                    Text = sdr["AgencyName"].ToString()
                                });
                            }
                    }
                    conn.Close();
                    System.Web.Script.Serialization.JavaScriptSerializer jSearializer =
                   new System.Web.Script.Serialization.JavaScriptSerializer();
                    return jSearializer.Serialize(ddl);
                }
            }
        }

        public void DownloadKeyCalculation(int NewKey = 0, int DeleteKey = 0, int UpdateKey = 0)
        {
            iTextSharp.text.Document document = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4, 20f, 20f, 20f, 20f);

            try
            {
                iTextSharp.text.pdf.PdfWriter.GetInstance(document, new FileStream(Server.MapPath("~/appviews/") + Guid.NewGuid() + ".pdf", FileMode.Create));

                iTextSharp.text.pdf.PdfPTable table = new iTextSharp.text.pdf.PdfPTable(3);
                table.TotalWidth = 400f;
                table.LockedWidth = true;
                float[] widths = new float[] { 4f, 4f, 4f };
                table.SetWidths(widths);
                table.HorizontalAlignment = 0;
                table.SpacingBefore = 20f;
                table.SpacingAfter = 30f;

                table.AddCell("Newly Added Keys");
                table.AddCell("Deleted Keys");
                table.AddCell("Update Keys");
                table.AddCell(NewKey.ToString());
                table.AddCell(DeleteKey.ToString());
                table.AddCell(UpdateKey.ToString());
                document.Open();
                document.Add(table);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                document.Close();
            }
        }

        public string getCalculateWithKey(string PID, string FileName)
        {
            var httpRequest = System.Web.HttpContext.Current.Request;
            List<string> lstFirst = new List<string>();
            List<string> lstSecond = new List<string>();
            string fn;
            string newFullPath;
            int newkey = 0;
            int delkey = 0;
            int chngkey = 0;

            foreach (string file in httpRequest.Files)
            {
                if (FileName.Contains(".resx"))
                {
                    string fileRepoPath = Server.MapPath("~/appviews/Doc");
                    newFullPath = Path.Combine(fileRepoPath, PID, FileName);

                    ResXResourceReader reader1 = new ResXResourceReader(newFullPath);
                    foreach (DictionaryEntry de in reader1)
                        if (!string.IsNullOrWhiteSpace(de.Key.ToString()))
                            lstFirst.Add(de.Value.ToString());
                    reader1.Close();

                    var postedFile = httpRequest.Files[file];
                    fn = Path.GetFileName(postedFile.FileName);
                    newFullPath = Path.Combine(Server.MapPath("~/appviews/"), fn);

                    if (System.IO.File.Exists(newFullPath))
                    {
                        System.IO.File.Delete(newFullPath);
                    }

                    postedFile.SaveAs(newFullPath);

                    ResXResourceReader reader = new ResXResourceReader(newFullPath);
                    foreach (DictionaryEntry de in reader)
                        if (!string.IsNullOrWhiteSpace(de.Key.ToString()))
                            lstSecond.Add(de.Value.ToString());
                    reader.Close();
                }
                if (FileName.Contains(".docx"))
                {
                    string[] lineSaparator = new string[] { "\n", ". ", "\r" };
                    newFullPath = Path.Combine(Server.MapPath("~/appviews/Doc/"), FileName);
                    DocX d1 = DocX.Load(newFullPath);
                    String[] l1 = null;
                    for (int paragraphCnt = 0; paragraphCnt < d1.Paragraphs.Count; paragraphCnt++)
                    {
                        l1 = d1.Paragraphs[paragraphCnt].Text.Split(lineSaparator, StringSplitOptions.RemoveEmptyEntries);
                        for (int lineCnt = 0; lineCnt < l1.Length; lineCnt++)
                        {
                            if (!string.IsNullOrWhiteSpace(l1[lineCnt]))
                            {
                                lstFirst.Add(l1[lineCnt]);
                            }
                        }
                    }
                    d1.Dispose();

                    var postedFile = httpRequest.Files[file];
                    fn = Path.GetFileName(postedFile.FileName);
                    newFullPath = Path.Combine(Server.MapPath("~/appviews/"), fn);

                    if (System.IO.File.Exists(newFullPath))
                    {
                        System.IO.File.Delete(newFullPath);
                    }

                    postedFile.SaveAs(newFullPath);

                    DocX d2 = DocX.Load(newFullPath);
                    String[] l2 = null;
                    for (int paragraphCnt = 0; paragraphCnt < d2.Paragraphs.Count; paragraphCnt++)
                    {
                        l2 = d2.Paragraphs[paragraphCnt].Text.Split(lineSaparator, StringSplitOptions.RemoveEmptyEntries);
                        for (int lineCnt = 0; lineCnt < l2.Length; lineCnt++)
                        {
                            if (!string.IsNullOrWhiteSpace(l2[lineCnt]))
                            {
                                lstSecond.Add(l2[lineCnt]);
                            }
                        }
                    }
                    d1.Dispose();
                }
                if (FileName.Contains(".properties"))
                {
                    string fileRepoPath = Server.MapPath("~/appviews/Doc");
                    newFullPath = Path.Combine(fileRepoPath, PID, FileName);

                    foreach (var row in System.IO.File.ReadAllLines(newFullPath))
                        lstFirst.Add(string.Join("=", row.Split('=').Skip(1).ToArray()));

                    var postedFile = httpRequest.Files[file];
                    fn = Path.GetFileName(postedFile.FileName);
                    newFullPath = Path.Combine(Server.MapPath("~/appviews/"), fn);

                    if (System.IO.File.Exists(newFullPath))
                    {
                        System.IO.File.Delete(newFullPath);
                    }

                    postedFile.SaveAs(newFullPath);

                    foreach (var row in System.IO.File.ReadAllLines(newFullPath))
                        lstSecond.Add(string.Join("=", row.Split('=').Skip(1).ToArray()));
                }
                if (FileName.Contains(".json"))
                {
                    string fileRepoPath = Server.MapPath("~/appviews/Doc");
                    newFullPath = Path.Combine(fileRepoPath, PID, FileName);

                    KeyPairGenerator keypairgen = new KeyPairGenerator
                    {
                        filePath = newFullPath
                    };

                    NameValueCollection keyVal_FileContent = keypairgen.LoadFile();

                    var items = keyVal_FileContent.AllKeys.SelectMany(keyVal_FileContent.GetValues, (k, v) => new { key = k, value = v });
                    foreach (var item in items)
                        lstFirst.Add(item.value);

                    var postedFile = httpRequest.Files[file];
                    fn = Path.GetFileName(postedFile.FileName);
                    newFullPath = Path.Combine(Server.MapPath("~/appviews/"), fn);

                    if (System.IO.File.Exists(newFullPath))
                    {
                        System.IO.File.Delete(newFullPath);
                    }

                    postedFile.SaveAs(newFullPath);

                    KeyPairGenerator keypairgen2 = new KeyPairGenerator
                    {
                        filePath = newFullPath
                    };

                    NameValueCollection keyVal_FileContent2 = keypairgen2.LoadFile();

                    var items2 = keyVal_FileContent2.AllKeys.SelectMany(keyVal_FileContent2.GetValues, (k, v) => new { key = k, value = v });
                    foreach (var item in items2)
                        lstSecond.Add(item.value);
                }
            }

            foreach (var item1 in lstFirst)
            {
                foreach (var item2 in lstSecond)
                {
                    if (item1 == item2)
                    {
                        chngkey++;
                    }
                }
            }
            newkey = lstSecond.Count - chngkey;
            delkey = lstFirst.Count - chngkey;

            return newkey + "-" + delkey + "-" + chngkey;
        }

        public string checkFileExist(int PID, string FileName)
        {
            string isExist = "F";

            try
            {
                DataSet ds = new DataSet();
                string str = "SELECT * FROM tbl_filedetails WHERE ProjectId = " + PID;
                connectionString.connectionOpen();

                MySqlDataAdapter da = new MySqlDataAdapter(str, connectionString.getConnection());
                da.Fill(ds);

                foreach (DataRow item in ds.Tables[0].Rows)
                {
                    string fileName = item["ParentFileName"].ToString() + item["FileType"].ToString();

                    if (FileName == fileName)
                    {
                        isExist = "T";
                        break;
                    }
                }

                return isExist;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int getSplitCount(string FileID)
        {
            DataSet ds = new DataSet();
            string str = "SELECT * FROM tbl_projectassignment WHERE D = 0 AND FileId = " + FileID;
            connectionString.connectionOpen();

            MySqlDataAdapter da = new MySqlDataAdapter(str, connectionString.getConnection());
            da.Fill(ds);

            return ds.Tables[0].Rows.Count;
        }
        private string getuploadfolder()
        {
            string root = Server.MapPath("~");
            string parent = Path.GetDirectoryName(root);
            string grandParent = Path.GetDirectoryName(parent);
            return grandParent + uploadkey;
        }
        public string splitFile(string PID, string FileID, string FileName, string SplitCount, string FileType)
        {
            string strVal = string.Empty;
            int spCnt = Convert.ToInt32(SplitCount);
            int i1 = 0;
            int i2 = 0;
            string fileNameOnly = Path.GetFileNameWithoutExtension(FileName);

            DataSet ds = new DataSet();
            string str = "SELECT * FROM tbl_projectassignment WHERE D = 0 AND FileId = " + FileID;
            connectionString.connectionOpen();

            MySqlDataAdapter da = new MySqlDataAdapter(str, connectionString.getConnection());
            da.Fill(ds);

            string targetLang = (ds.Tables[0].Rows[0][8]).ToString();

            string fileRepoPath = Server.MapPath("~/appviews/Doc");
            string targetDirPath = Path.Combine(fileRepoPath, PID);
            if (!Directory.Exists(targetDirPath))
            {
                Directory.CreateDirectory(targetDirPath);
            }

            int totRec = ds.Tables[0].Rows.Count;

            int sp = Convert.ToInt32(Math.Ceiling((double)totRec / spCnt));

            foreach (DataRow item in ds.Tables[0].Rows)
            {
                i2++;
                strVal += (i1 + 1) + "," + item["KeyName"] + "," + item["Value"] + "|";
                if (i2 == sp)
                {
                    i1++;
                    i2 = 0;
                }
            }

            strVal = strVal.Remove(strVal.Length - 1);
            string[] strArr = strVal.Split('|');

            for (int i = 1; i <= spCnt; i++)
            {
                if (FileType.Contains(".resx"))
                {
                    using (ResXResourceWriter resx = new ResXResourceWriter(targetDirPath + "\\" + fileNameOnly + "_" + i + ".resx"))
                    {
                        for (int j = 0; j < strArr.Length; j++)
                        {
                            string[] strInnerArr = strArr[j].Split(',');
                            if (i == Convert.ToInt32(strInnerArr[0]))
                            {
                                resx.AddResource(strInnerArr[1].ToString(), strInnerArr[2].ToString());
                            }
                        }
                    }
                }
                else if (FileType.Contains(".docx"))
                {
                    string fileName = targetDirPath + "\\" + fileNameOnly + "_" + i + ".docx";
                    var doc = DocX.Create(fileName);
                    for (int j = 0; j < strArr.Length; j++)
                    {
                        string[] strInnerArr = strArr[j].Split(',');
                        if (i == Convert.ToInt32(strInnerArr[0]))
                        {
                            doc.InsertParagraph(strInnerArr[2].ToString());
                        }
                    }
                    doc.Save();
                }
                else if (FileType.Contains(".properties"))
                {
                    string fileName = targetDirPath + "\\" + fileNameOnly + "_" + i + ".properties";
                    using (StreamWriter sw = System.IO.File.CreateText(fileName))
                    {
                        for (int j = 0; j < strArr.Length; j++)
                        {
                            string[] strInnerArr = strArr[j].Split(',');
                            if (i == Convert.ToInt32(strInnerArr[0]))
                            {
                                sw.WriteLine(strInnerArr[1].ToString() + "=" + strInnerArr[2].ToString());
                            }
                        }

                        sw.Close();
                    }
                }
                else if (FileType.Contains(".json"))
                {
                    string fileName = targetDirPath + "\\" + fileNameOnly + "_" + i + ".json";

                    for (int j = 0; j < strArr.Length; j++)
                    {
                        string[] strInnerArr = strArr[j].Split(',');
                        if (i == Convert.ToInt32(strInnerArr[0]))
                        {
                            string[] key = strInnerArr[1].Split('.');
                        }
                    }
                }
            }

            string strvalue = "Update `tbl_filedetails` set `Status` = 'Splitted' where `Id` = " + FileID + ";";
            MySqlCommand com = new MySqlCommand(strvalue, connectionString.getConnection());
            com.ExecuteNonQuery();

            IdentityUser user = System.Web.HttpContext.Current.Session.GetDataFromSession<IdentityUser>("User");

            DataSet ds2 = new DataSet();
            string commandText2 = "SELECT AgencyId from `tbl_agencydetails` WHERE UserId IS NOT NULL and UserId = " + user.UserId;
            MySqlDataAdapter da2 = new MySqlDataAdapter(commandText2, connectionString.getConnection());
            da2.Fill(ds2);

            int AID = 0;
            foreach (DataRow item in ds2.Tables[0].Rows)
            {
                AID = Convert.ToInt32(item["AgencyId"].ToString());
                break;
            }

            return user.UserId.ToString() + "," + AID.ToString() + "," + FileID + "," + targetLang;
        }

        public string isCompleteTask(string id = "", string taskname = "")
        {
            string status = "NO";


            DataSet ds = new DataSet();
            DataSet dsProj = new DataSet();
            DataSet dstaskId = new DataSet();

            string str = "SELECT * FROM tbl_assignproject WHERE fileid = " + id + " AND taskname is not null;";
            connectionString.connectionOpen();
            MySqlDataAdapter da = new MySqlDataAdapter(str, connectionString.getConnection());
            da.Fill(ds);

            string projectId = ds.Tables[0].Rows[0]["projectid"].ToString();

            //Checking Flag for Parallel Project Flow
            string sqlquery = "select chkParallelProject,OwnerId from tbl_project where projectid='" + projectId + "';";
            MySqlDataAdapter daProj = new MySqlDataAdapter(sqlquery, connectionString.getConnection());
            daProj.Fill(dsProj);
            string Checkproj = dsProj.Tables[0].Rows[0]["chkParallelProject"].ToString();
            if (Checkproj == "Yes")
            {
                return "project not";
            }

            int cnt = ds.Tables[0].Rows.Count;

            bool isFirst = true;
            string CompletedDate = "";

            foreach (DataRow item in ds.Tables[0].Rows)
            {
                if (isFirst)
                {
                    if (item["taskname"].ToString() == taskname)
                    {
                        status = "YES";
                        break;
                    }

                    isFirst = false;
                }

                if (CompletedDate != null && CompletedDate != "")
                {
                    if (item["taskname"].ToString() == taskname)
                    {
                        status = "YES";
                        break;
                    }
                }

                CompletedDate = item["CompletedDate"].ToString();
            }

            return status;
        }

        [HttpGet]
        public ActionResult KeyTranslatorPage(string id = "", string taskname = "", string filter = "All")
        {
            var FileId = Request.RequestContext.RouteData.Values["id"];

            if (id != "")
            {
                FileId = id;
            }

            DataSet ds = new DataSet();

            string str = "Select `ID`, `FileId`, `Value`, `ValueTarget`, `KeyName`, count(keyId) as keyCount, Source, Target, isChangeValue, GlossaryWord from `tbl_projectassignment` pa left  join `tbl_querymgmt` qm on pa.ID=qm.keyId ";
            string whereClause = "";
            if (filter == "All")
            {
                whereClause = "where `FileId` = " + FileId + " group by pa.Value ORDER BY ID; ";

            }
            else if (filter == "Blank")
            {
                whereClause = "where `FileId` = " + FileId + " AND (ValueTarget IS NULL OR TRIM(ValueTarget) = '') group by pa.Value ORDER BY ID; ";
            }
            else if (filter == "TM")
            {
                whereClause = "where `FileId` = " + FileId + "  AND TRIM(isChangeValue)='TM' group by pa.Value ORDER BY ID; ";
            }
            else if (filter == "TME")
            {
                whereClause = "where `FileId` = " + FileId + "  AND TRIM(isChangeValue)='TME'  group by pa.Value ORDER BY ID; ";
            }

            str = str + whereClause;

            connectionString.connectionOpen();

            MySqlDataAdapter da = new MySqlDataAdapter(str, connectionString.getConnection());
            da.Fill(ds);
            ViewBag.List = ds.Tables[0];

            AddUtilsInfo(FileId.ToString());

            //Fetch the Task ID from DB using EntityFramework, EntityModel.
            IdentityUser user = System.Web.HttpContext.Current.Session.GetDataFromSession<IdentityUser>("User");

            string userId = user.UserId.ToString();
            string TaskId = "No Task ID.";
            var dataTask = Configtask.tbl_customizeprojecttask.Where(x => (x.userId == userId || x.userId == "0") && x.ProjectTask_Name == taskname).FirstOrDefault();

            if (dataTask != null)
                if (dataTask.TaskTypeId != "" || !string.IsNullOrEmpty(dataTask.TaskTypeId))
                    TaskId = dataTask.TaskTypeId;

            ViewBag.TaskTypeId = TaskId;
            return View();
        }

        private void AddUtilsInfo(string FileId)
        {
            MySqlConnection connection = GetDBConnection();
            connection.Open();

            string query = "SELECT fd.ProjectId ProjectID,CONCAT( fd.ParentFileName, fd.FileType) originalName,fd.FileType as FileType, CONCAT( fd.ChildFileName, fd.FileType) as FileName ,CONCAT(lm1.LangISOName,' : ',lm1.LangEnglishName)  AS Source_lang , CONCAT(lm2.LangISOName,' : ',lm2.LangEnglishName) AS Target_lang FROM tbl_filedetails AS fd INNER JOIN tbl_langmaster AS lm1  ON fd.Source_lang = lm1.LangId INNER JOIN tbl_langmaster AS lm2  ON fd.Target_lang = lm2.LangId where id = " + FileId;
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader dataReader = command.ExecuteReader();
            dataReader.Read();

            ViewBag.FileType = dataReader["FileType"].ToString();
            ViewBag.Source_lang = dataReader["Source_lang"].ToString();
            ViewBag.Target_lang = dataReader["Target_lang"].ToString();
            ViewBag.FileName = dataReader["FileName"].ToString();

            string projectId = dataReader["ProjectID"].ToString();
            //projectId = "125";
            //string targetDirPath = Path.Combine(fileRepoPath, projectId);
            //childFilePath = targetDirPath + "\\" + childFileName + fileExtension;

            string urlOriginal = "http://docs.google.com/gview?url=http://54.186.6.13:81/appviews/Doc/" + projectId + "/" + dataReader["originalName"].ToString() + "&embedded=true";
            string urlTranslated = "http://docs.google.com/gview?url=http://54.186.6.13:81/appviews/Doc/" + projectId + "/" + dataReader["FileName"].ToString() + "&embedded=true";
            ViewBag.FilePathOriginal = urlOriginal;
            ViewBag.FilePathTranslated = urlTranslated;
            dataReader.Close();
            connection.Close();
        }

        [HttpPost]
        public ActionResult publishkeys(string[] sourceValue, string[] targetValue, string id, string taskname = "")
        {
            connectionString.connectionOpen();

            DateTime Date = DateTime.Now;
            string publisheddate = Date.ToString("yyyy-MM-dd HH:mm:ss");
            for (int i = 0; i < targetValue.Length; i++)
            {
                if (targetValue[i] != "")
                {
                    string query = "UPDATE `tbl_projectassignment` set `ValueTarget` = '" + targetValue[i] + "'  WHERE `Value` = '" + sourceValue[i] + "' and FileId = " + Convert.ToInt32(id) + ";";
                    MySqlCommand com1 = new MySqlCommand(query, connectionString.getConnection());
                    com1.ExecuteNonQuery();
                }
            }
            string query1 = "UPDATE `tbl_filedetails` set `Status`='Complete', `CompletedDate` = '" + publisheddate + "' where Id = " + Convert.ToInt32(id) + ";";
            MySqlCommand com2 = new MySqlCommand(query1, connectionString.getConnection());
            com2.ExecuteNonQuery();

            if (!string.IsNullOrEmpty(taskname))
            {
                string query2 = "UPDATE tbl_assignproject SET isPublish = '100', TStatus = 'Complete', CompletedDate = '" + publisheddate + "' WHERE fileid = " + Convert.ToInt32(id) + " AND taskname = '" + taskname + "';";
                MySqlCommand com3 = new MySqlCommand(query2, connectionString.getConnection());
                com3.ExecuteNonQuery();
            }

            changeprojectstatus(id);

            IdentityUser user = System.Web.HttpContext.Current.Session.GetDataFromSession<IdentityUser>("User");
            if (user == null)
            {
                return RedirectToAction("Login", "Account");
            }

            NotificationHandler nh = new NotificationHandler();
            nh.CreateTranslatorNotification("completed", user.UserId.ToString(), user.UserName, user.Email, id);

            DataSet ds2 = new DataSet();
            string str2 = "SELECT t.TransltrName, t.EmailId FROM tbl_assignproject a LEFT JOIN tbl_translatordetails t ON t.TransltrId = a.TAssignTo WHERE a.fileid = " + id + " AND a.SequenceNo != 0 AND a.TStatus != 'Complete' ORDER BY a.SequenceNo LIMIT 1;";
            MySqlDataAdapter da2 = new MySqlDataAdapter(str2, connectionString.getConnection());
            da2.Fill(ds2);

            if (ds2.Tables[0].Rows.Count == 1)
            {
                string RcvrName = ds2.Tables[0].Rows[0][0].ToString();
                string EmailID = ds2.Tables[0].Rows[0][1].ToString();

                nh.QCNotification(id, user.UserName, RcvrName, EmailID);
            }

            connectionString.connectionClose();
            return null;
        }

        private void changeprojectstatus(string id)
        {
            connectionString.connectionOpen();

            try
            {
                DataTable dt = new DataTable();
                DataTable dt1 = new DataTable();
                string str = "Select `ProjectId` from `tbl_filedetails` where Id = " + Convert.ToInt32(id) + ";";

                MySqlDataAdapter da = new MySqlDataAdapter(str, connectionString.getConnection());
                da.Fill(dt);
                string str1 = "Select * from `tbl_filedetails` where `ProjectId` = " + Convert.ToInt32(dt.Rows[0][0].ToString()) + ";";
                MySqlDataAdapter da1 = new MySqlDataAdapter(str1, connectionString.getConnection());
                da1.Fill(dt1);
                int _tcount = 0;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt1.Rows[i]["Status"].ToString() == "Complete")
                    {
                        _tcount = _tcount + 1;
                    }
                }
                if (_tcount > 0)
                {
                    string query1 = "UPDATE `tbl_projectassignment` set `Status`='Complete' where ProjectId = " + Convert.ToInt32(Convert.ToInt32(dt.Rows[0][0].ToString())) + ";";
                    MySqlCommand com2 = new MySqlCommand(query1, connectionString.getConnection());
                    com2.ExecuteNonQuery();
                }
            }
            catch
            {

            }
            finally
            {
                connectionString.connectionClose();
            }
        }

        public void updateKeyTranslator(string FileID, string Key, string value, string valueTarget, string srcLang, string targetLang, string taskname = "")
        {
            connectionString.connectionOpen();


            string tVal = string.Empty;

            if (taskname == "Translation")
            {
                DataSet ds = new DataSet();
                string query = "SELECT Value FROM tbl_translationmem WHERE Name = '" + value + "' AND SourceLang = '" + srcLang + "' AND TargetLang = '" + targetLang + "';";
                MySqlDataAdapter da = new MySqlDataAdapter(query, connectionString.getConnection());
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    tVal = ds.Tables[0].Rows[0][0].ToString();
                }

                DataSet ds2 = new DataSet();
                string query2 = "SELECT isChangeValue FROM tbl_projectassignment WHERE FileId = '" + FileID + "' AND KeyName = '" + Key + "' AND Value = '" + value + "';";
                MySqlDataAdapter da2 = new MySqlDataAdapter(query2, connectionString.getConnection());
                da2.Fill(ds2);
                if (ds2.Tables[0].Rows.Count > 0)
                {
                    string status = ds2.Tables[0].Rows[0][0].ToString();
                    if (status != "TM")
                    {
                        if (!string.IsNullOrEmpty(valueTarget))
                        {
                            string updateStatus = "UPDATE tbl_projectassignment SET isChangeValue = 'MT' WHERE FileId = '" + FileID + "' AND KeyName = '" + Key + "' AND Value = '" + value + "';";
                            MySqlCommand cmd = new MySqlCommand(updateStatus, connectionString.getConnection());
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
                if (!string.IsNullOrEmpty(tVal) && !string.IsNullOrEmpty(valueTarget))
                {
                    if (tVal != valueTarget)
                    {
                        DataSet ds1 = new DataSet();
                        string query1 = "SELECT isChangeValue FROM tbl_projectassignment WHERE FileId = '" + FileID + "' AND KeyName = '" + Key + "' AND Value = '" + value + "';";
                        MySqlDataAdapter da1 = new MySqlDataAdapter(query1, connectionString.getConnection());
                        da1.Fill(ds1);
                        if (ds1.Tables[0].Rows.Count > 0)
                        {
                            string status = ds1.Tables[0].Rows[0][0].ToString();
                            if (status == "TM")
                            {
                                string updateStatus = "UPDATE tbl_projectassignment SET isChangeValue = 'TME' WHERE FileId = '" + FileID + "' AND KeyName = '" + Key + "' AND Value = '" + value + "';";
                                MySqlCommand cmd = new MySqlCommand(updateStatus, connectionString.getConnection());
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }
                }
            }
            else if (taskname == "Proof Reading")
            {
                DataSet ds1 = new DataSet();
                string query1 = "SELECT ValueTarget FROM tbl_projectassignment WHERE FileId = '" + FileID + "' AND KeyName = '" + Key + "' AND Value = '" + value + "';";
                MySqlDataAdapter da1 = new MySqlDataAdapter(query1, connectionString.getConnection());
                da1.Fill(ds1);
                if (ds1.Tables[0].Rows.Count > 0)
                {
                    tVal = ds1.Tables[0].Rows[0][0].ToString();

                    if (tVal != valueTarget)
                    {
                        string updateStatus = "UPDATE tbl_projectassignment SET isChangeValue = 'PRMT' WHERE FileId = '" + FileID + "' AND KeyName = '" + Key + "' AND Value = '" + value + "';";
                        MySqlCommand cmd = new MySqlCommand(updateStatus, connectionString.getConnection());
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        [HttpPost]
        public string ApplyGlossary(string[] sourceValue, string[] targetValue, string id, string[] keyname, string[] changedKeyId, string srcLang, string targetLang)
        {
            string strVal = string.Empty;
            string childFilePath = string.Empty;
            MySqlConnection connection = null;
            try
            {
                connection = GetDBConnection();
                connection.Open();

                string query = "select FileType, ChildFileName, ProjectId from tbl_filedetails where id = " + id;
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = command.ExecuteReader();
                dataReader.Read();
                string fileExtension = dataReader["FileType"].ToString();
                string childFileName = dataReader["ChildFileName"].ToString();
                string ProjectId = dataReader["ProjectId"].ToString();
                dataReader.Close();

                string fileRepoPath = Server.MapPath("~/appviews/Doc");
                string targetDirPath = Path.Combine(fileRepoPath, ProjectId);
                childFilePath = targetDirPath + "\\" + childFileName + fileExtension;

                FileTranslator filetranslator = new FileTranslator();
                filetranslator.Initialize(childFilePath);

                string strDate = DateTime.Now.ToString("yyyy-MM-dd");

                command = new MySqlCommand();
                command.CommandText += "SET SQL_SAFE_UPDATES = 0;";

                query = "Select * from `tbl_projectassignment` where FileId = '" + id + "';";
                MySqlConnection proAssConn = connectionString.getConnection();
                proAssConn.Open();
                MySqlCommand proAssCmd = new MySqlCommand(query, proAssConn);

                DataSet ds = new DataSet();
                string filterstr = "SELECT * FROM tbl_glossery";
                MySqlDataAdapter da = new MySqlDataAdapter(filterstr, connection);
                da.Fill(ds);

                for (int indx = 0; indx < keyname.Length; indx++)
                {
                    foreach (DataRow item in ds.Tables[0].Rows)
                    {
                        string srcVal = sourceValue[indx].ToString();

                        string texttofind = string.Format(@"\b{0}\b", item["srcTerm"]);

                        var regex = new Regex(texttofind, RegexOptions.IgnoreCase);

                        string repVal = regex.Replace(srcVal, item["trgTerm"].ToString());

                        if (repVal != srcVal)
                        {
                            command.CommandText += string.Format("update tbl_projectassignment set ValueTarget = '{0}', TranslationDate = '{1}', Year = '{2}', Month = '{3}', Week = '{4}', Quarter = Quarter(CURDATE()), GlossaryWord = '{8}' where Value = '{5}' and FileId = '{6}' and KeyName = '{7}';", MySqlHelper.EscapeString(repVal), strDate, DateTime.Now.Year, GetMonthName(), GetWeekNumber(), MySqlHelper.EscapeString(sourceValue[indx]), Convert.ToInt32(id), keyname[indx], item["srcTerm"].ToString());

                            if (!string.IsNullOrWhiteSpace(repVal))
                                filetranslator.ReplaceFileContentWithTranslatedVal(GetSourceValKeys(sourceValue[indx], proAssCmd), repVal, sourceValue[indx]);
                        }
                    }
                }

                proAssConn.Close();
                dataReader.Close();

                filetranslator.FileTranslateFinalizer();

                command.Connection = connection;
                command.ExecuteNonQuery();

                strVal = "Apply Glossary Successfully.";
            }
            catch (Exception e)
            {
                strVal = "Error : " + e.Message;
            }
            finally
            {
                connection.Close();
            }

            return strVal;
        }

        [HttpPost]
        public string KeyTranslatorPage(string[] sourceValue, string[] targetValue, string id, string[] keyname, string[] changedKeyId, string srcLang, string targetLang, string taskname = "")
        {
            string passData = string.Empty;
            string childFilePath = string.Empty, message = string.Empty, dupFlag = string.Empty, mtVal = string.Empty, isMT = string.Empty;
            MySqlConnection connection = null;
            try
            {
                connection = GetDBConnection();
                connection.Open();

                string query = "select FileType, ChildFileName, ProjectId from tbl_filedetails where id = " + id;
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = command.ExecuteReader();
                dataReader.Read();
                string fileExtension = dataReader["FileType"].ToString();
                string childFileName = dataReader["ChildFileName"].ToString();
                string ProjectId = dataReader["ProjectId"].ToString();
                dataReader.Close();

                string fileRepoPath = Server.MapPath("~/appviews/Doc");
                string targetDirPath = Path.Combine(fileRepoPath, ProjectId);
                childFilePath = targetDirPath + "\\" + childFileName + fileExtension;

                FileTranslator filetranslator = new FileTranslator();
                filetranslator.Initialize(childFilePath);

                string strDate = DateTime.Now.ToString("yyyy-MM-dd");

                command = new MySqlCommand();
                command.CommandText += "SET SQL_SAFE_UPDATES = 0;";

                // Prasoon Code Review : Do we really need to load the whole translation Memory while saving translations ?
                query = "Select * from `tbl_translationmem` where SourceLang = '" + srcLang + "' AND TargetLang = '" + targetLang + "';";
                MySqlCommand cmdTM = new MySqlCommand(query, connection);

                // Prasoon Code Review :  Even this should not be required
                query = "Select * from `tbl_projectassignment` where FileId = '" + id + "';";

                // Prasoon Code Review : Isnt opening closing connection all the time expensive
                MySqlConnection proAssConn = connectionString.getConnection();
                proAssConn.Open();
                MySqlCommand proAssCmd = new MySqlCommand(query, proAssConn);
                int srcWC = 0;

                for (int indx = 0; indx < keyname.Length; indx++)
                {
                    srcWC = string.IsNullOrEmpty(targetValue[indx]) ? 0 : sourceValue[indx].Trim().Split().Length;

                    isMT = SetTMValue(cmdTM, sourceValue[indx].Trim(), targetValue[indx], srcLang, targetLang) ? "0" : "1";

                    command.CommandText += string.Format("update tbl_projectassignment set ValueTarget = '{0}', TranslationDate = '{1}', Year = '{2}', Month = '{3}', Week = '{4}', Quarter = Quarter(CURDATE()) , MT = '{5}', `TWC` = '{6}' where Value = '{7}' and FileId = '{8}' and KeyName = '{9}';", MySqlHelper.EscapeString(targetValue[indx]), strDate, DateTime.Now.Year, GetMonthName(), GetWeekNumber(), isMT, srcWC, sourceValue[indx], Convert.ToInt32(id), keyname[indx]);

                    if (changedKeyId != null && indx < changedKeyId.Length && changedKeyId[indx] != "")
                    {
                        command.CommandText += string.Format("update tbl_projectassignment set TranslationDate = '{0}', Year = '{1}', Month = '{2}', Week = '{3}', Quarter = Quarter(CURDATE()) where ID = {4};",
                        strDate, DateTime.Now.Year, GetMonthName(), GetWeekNumber(), changedKeyId[indx]);
                    }

                    if (!string.IsNullOrWhiteSpace(targetValue[indx]))
                        filetranslator.ReplaceFileContentWithTranslatedVal(GetSourceValKeys(sourceValue[indx], proAssCmd), targetValue[indx], sourceValue[indx]);

                    updateKeyTranslator(id, keyname[indx], sourceValue[indx], MySqlHelper.EscapeString(targetValue[indx]), srcLang, targetLang, taskname);
                }

                proAssConn.Close();
                dataReader.Close();

                filetranslator.FileTranslateFinalizer();

                command.Connection = connection;
                command.ExecuteNonQuery();

                if (sourceValue.Count(x => !string.IsNullOrEmpty(x)) == targetValue.Count(x => !string.IsNullOrEmpty(x)))
                {
                    MySqlCommand command1 = new MySqlCommand();
                    command1.CommandText += "SET SQL_SAFE_UPDATES = 0;";
                    command1.CommandText += "update tbl_filedetails set Status = 'Completed' where id = " + id;
                    command1.Connection = connection;
                    command1.ExecuteNonQuery();
                }

                command = new MySqlCommand(strQryTM, connection);
                command.ExecuteNonQuery();

                string qry = "select OriginalFileID from tbl_filedetails where Id = " + id;
                MySqlCommand cmd = new MySqlCommand(qry, connection);
                MySqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                int OriginalFileID = dr["OriginalFileID"] == null | dr["OriginalFileID"] == System.DBNull.Value ? 0 : Convert.ToInt32(dr["OriginalFileID"].ToString());
                dr.Close();

                string qry1 = "select * from tbl_projectassignment where D = 0 AND FileId = " + OriginalFileID;
                MySqlCommand cmd1 = new MySqlCommand(qry1, connection);
                MySqlDataReader dr1 = cmd1.ExecuteReader();

                command = new MySqlCommand();
                command.CommandText += "SET SQL_SAFE_UPDATES = 0;";
                while (dr1.Read())
                {
                    for (int indx = 0; indx < sourceValue.Length; indx++)
                    {
                        if (sourceValue[indx].Trim().ToString() == dr1.GetString("Value").Trim().ToString())
                        {
                            command.CommandText += string.Format("update tbl_projectassignment set ValueTarget = '{0}' where ID = {1};", targetValue[indx].ToString(), dr1.GetInt32("ID"));
                        }
                    }
                }
                dr1.Close();
                command.Connection = connection;
                command.ExecuteNonQuery();

                message = "Translation Saved.";
            }
            catch (Exception e)
            {
                message = "Error : " + e.Message;
            }
            finally
            {
                string updateBlankTargetValue = "SET SQL_SAFE_UPDATES = 0; update tbl_projectassignment set ValueTarget = null where ValueTarget = '' and fileid = " + id + "; SET SQL_SAFE_UPDATES = 0";
                MySqlCommand com = new MySqlCommand(updateBlankTargetValue, connection);
                com.ExecuteNonQuery();
                connection.Close();
            }

            ViewBag.fielSaveMgs = message;

            return null;
        }

        private List<string> GetSourceValKeys(string strSrc, MySqlCommand projectAssignmentcmd)
        {
            MySqlDataReader projectAssignmentReader = projectAssignmentcmd.ExecuteReader();
            List<string> keys = new List<string>();
            while (projectAssignmentReader.Read())
            {
                if (string.Equals(projectAssignmentReader.GetString("Value"), strSrc))
                {
                    keys.Add(projectAssignmentReader.GetString("KeyName"));
                    break;
                }
            }

            projectAssignmentReader.Close();

            return keys;
        }

        string strQryTM = string.Empty;
        private bool SetTMValue(MySqlCommand cmdTM, string forTranslation, string translatedVal, string srcLang, string targetLang)
        {
            MySqlDataReader reader = cmdTM.ExecuteReader();
            //Check if present in tbl_translationmem
            while (reader.Read())
            {
                if (string.Equals(forTranslation, reader.GetString("Name")))
                {
                    translatedVal = reader.GetString("Value").Trim();

                    //Update translated value if translatedVal is not empty
                    if (!string.IsNullOrEmpty(translatedVal))
                    {
                        strQryTM += "update tbl_translationmem set Value = '{0}' where Name = '{1}' and SourceLang = '{2}' and TargetLang = '{3}';";
                        strQryTM = string.Format(strQryTM, translatedVal, forTranslation, srcLang, targetLang);
                    }
                    reader.Close();
                    return false;
                }
            }

            reader.Close();

            //Make Entry in tbl_translationmem, if translatedVal is not empty;
            if (!string.IsNullOrEmpty(translatedVal))
            {
                strQryTM += "insert into tbl_translationmem (Name, Value, SourceLang, TargetLang) values ('{0}', '{1}', '{2}', '{3}');";
                strQryTM = string.Format(strQryTM, forTranslation, translatedVal, srcLang, targetLang);
            }

            return true;
        }

        private bool HasDuplicates(string[] arrayList, string search)
        {
            bool returnValue = false;
            foreach (string s in arrayList)
            {
                if (search.Contains(s.Trim()))
                {
                    returnValue = true;
                    break;
                }
            }

            return returnValue;
        }

        private MySqlConnection GetDBConnection()
        {
            string constr = ConfigurationManager.ConnectionStrings["loginConn"].ToString();
            MySqlConnection con = new MySqlConnection(constr);

            return con;
        }

        public int GetWeekNumber()
        {
            CultureInfo ciCurr = CultureInfo.CurrentCulture;
            int weekNum = ciCurr.Calendar.GetWeekOfYear(DateTime.Now, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
            return weekNum;
        }

        public string GetMonthName()
        {
            return CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(DateTime.Now.Month);
        }

        //Get
        [HttpGet]
        public string RunTM(string sourceValue)
        {
            DataSet ds = new DataSet();
            connectionString.connectionOpen();

            string[] words = sourceValue.Split(',');

            string query = "Select * from `tbl_translationmem` where `Name` = '" + sourceValue + "';";
            MySqlDataAdapter da = new MySqlDataAdapter(query, connectionString.getConnection());
            da.Fill(ds);
            connectionString.connectionClose();
            ViewBag.List = ds.Tables[0];

            if (ds.Tables[0].Rows.Count > 0)
            {
                return ds.Tables[0].Rows[0][2].ToString();
            }
            else
            {
                return "";
            }

        }

        //GET
        [HttpGet]
        [AllowAnonymous]
        public ActionResult AddFileInProject(string id)
        {
            var ID = Request.RequestContext.RouteData.Values["id"];
            DataSet ds = new DataSet();
            var model = new SmartAdminMvc.Models.FileUpload();
            IdentityUser user = System.Web.HttpContext.Current.Session.GetDataFromSession<IdentityUser>("User");
            if (user == null)
            {
                return RedirectToAction("Login", "Account");
            }
            try
            {
                string str = "SELECT `ProjectName` from tbl_project where `OwnerId` = " + user.UserId + " and `ProjectId` = '" + ID + "';";
                connectionString.connectionOpen();
                MySqlDataAdapter da = new MySqlDataAdapter(str, connectionString.getConnection());

                da.Fill(ds);
                model.ProjectId = Convert.ToInt16(ID);
                model.ProjectName = ds.Tables[0].Rows[0][0].ToString();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connectionString.connectionClose();
            }
            return View(model);
        }

        public DataSet ProjectList()
        {
            DataSet ds = new DataSet();
            IdentityUser user = System.Web.HttpContext.Current.Session.GetDataFromSession<IdentityUser>("User");
            try
            {
                string str = "SELECT `ProjectId`, `ProjectName` from tbl_project where `OwnerId` = " + user.UserId + ";";
                connectionString.connectionOpen();
                MySqlDataAdapter da = new MySqlDataAdapter(str, connectionString.getConnection());

                da.Fill(ds);

            }
            catch (Exception ex)
            {

            }
            finally
            {
                connectionString.connectionClose();
            }
            return ds;
        }

        //GET
        [HttpGet]
        public ActionResult ProjectAccepted()
        {
            IdentityUser user = System.Web.HttpContext.Current.Session.GetDataFromSession<IdentityUser>("User");
            if (user == null)
            {
                return RedirectToAction("Login", "Account");
            }
            ProjectViewModel model = new ProjectViewModel();

            Dictionary<int, ProjectModel> tempList = new Dictionary<int, ProjectModel>();
            List<ProjectModel> projects = new List<ProjectModel>();
            model.Projects = projects;

            DataTable dt = new DataTable();
            string getowner = "select * from `tbl_assignproject` where assignto = '" + user.UserId + "'";
            try
            {
                connectionString.connectionOpen();
                MySqlDataAdapter da = new MySqlDataAdapter(getowner, connectionString.getConnection());

                da.Fill(dt);
                connectionString.connectionClose();

                string commandText = "SELECT distinct p.ProjectId,u.UserName, p.OwnerId, p.ProjectName, DATE_FORMAT(p.StartDate, '%d-%m-%Y') as 'SubmitionDate', DATE_FORMAT(p.ExpectedDate,'%d-%m-%Y %H:%i') as 'ExpectedDate', p.FilePath, l.LangId ,  l.LangISOName, p.Status, DATE_FORMAT(p.SubmitionDate, '%d-%m-%Y') as 'CreatedDate',p.ProjectPriority from `tbl_project` p, `tbl_langmaster` l ,tbl_assignproject asp, tbl_users u WHERE asp.userid = " + user.UserId + " and l.LangId = p.LangId and p.ProjectId=asp.projectid and (p.Status != 'Assigned to Agency' and p.Status != 'Canceled') and p.OwnerId = u.UserId Order by p.ProjectId desc;";
                string str = "select distinct m.ProjectId, m.LangId, l.LangISOName,p.ProjectPriority from tbl_projectlangmap m join tbl_project p on p.ProjectId = m.ProjectId join tbl_langmaster l on l.LangId = m.LangId where p.OwnerId = " + dt.Rows[0][1] + " or  p.OwnerId = " + user.UserId + ";";

                Dictionary<string, object> parameters = new Dictionary<string, object>() { };
                var rows = _database.Query(commandText, parameters);
                AppViewsController objGetfid = new AppViewsController();
                foreach (var row in rows)
                {

                    var projInfo = new ProjectModel
                    {
                        CreatedDate = row["CreatedDate"],
                        FileId = objGetfid.GetFileId(int.Parse(row["ProjectId"])),
                        ProjectId = int.Parse(row["ProjectId"]),
                        ProjectName = row["ProjectName"],
                        StartData = row["SubmitionDate"],
                        Source = row["LangISOName"],
                        FileName = row["FilePath"],
                        Status = row["Status"],
                        ExpDate = row["ExpectedDate"],
                        SourceID = row["LangId"],
                        TargetLanguage = new Dictionary<string, string>(),
                        ownername = row["UserName"],
                        progress = totalprogress(row["ProjectId"]),
                        Cost = GetCostByPid(row["ProjectId"]),
                        ProjectPriority = row["ProjectPriority"]
                    };

                    projects.Add(projInfo);
                    tempList.Add(projInfo.ProjectId, projInfo);

                }
                var rows1 = _database.Query(str, parameters);
                foreach (var row in rows1)
                {
                    int projid = int.Parse(row["ProjectId"]);

                    if (tempList.ContainsKey(projid))
                    {
                        ProjectModel proj = tempList[projid];

                        proj.TargetLanguage.Add(row["LangId"].ToString(), row["LangISOName"]);

                    }
                }
            }
            catch
            {
                View(model);
            }
            finally
            {
                connectionString.connectionClose();
            }
            return View(model);
        }
        private string totalprogress(string pid)
        {
            string _val = "0";
            try
            {
                connectionString.connectionOpen();


                DataSet ds = new DataSet();
                string getProcess = "SELECT SUM(vp.Progress) / COUNT(vp.Progress) progress FROM tbl_filedetails f INNER JOIN v_progress vp ON vp.FileId = f.Id WHERE f.ProjectId = '" + pid + "';";
                MySqlDataAdapter da = new MySqlDataAdapter(getProcess, connectionString.getConnection());
                da.Fill(ds);

                _val = Convert.ToInt32(Math.Round(Convert.ToDouble(ds.Tables[0].Rows[0][0].ToString()))).ToString();

                if (_val.Contains("100"))
                {
                    string updateStatus = "UPDATE tbl_project SET Status = 'Completed' WHERE ProjectId = " + pid;
                    MySqlCommand command1 = new MySqlCommand(updateStatus, connectionString.getConnection());
                    command1.ExecuteNonQuery();
                }
            }
            catch
            {
                _val = "0";
            }
            finally
            {
                connectionString.connectionClose();
            }
            return _val;
        }

        [HttpGet]
        public ActionResult ProjectAcceptForTranslator()
        {
            ProjectAcceptForTranslatorMethod();

            //connectionString.connectionOpen();

            //IdentityUser user = System.Web.HttpContext.Current.Session.GetDataFromSession<IdentityUser>("User");
            ////Return the Data from DB for Company User Profile  Report
            //var objCompanyProfile = Configtask.tbl_companyprofile.Where(x => x.CreatorUserId == user.UserId).ToList();
            //ViewBag.CompanyProfile = objCompanyProfile;

            //DataSet dsOwnerProfile = new DataSet();
            //connectionString.connectionOpen();
            //string strCostReport = "select * from tbl_companyprofile where CreatorUserId in (select distinct ownerID from tbl_assignproject where projectid = " + pid + " and assignto = " + user.UserId + ")";
            //MySqlDataAdapter daOwnerProfile = new MySqlDataAdapter(strCostReport, connectionString.getConnection());
            //daOwnerProfile.Fill(dsOwnerProfile);
            //ViewBag.OwnerProfile = dsOwnerProfile.Tables[0];

            //DataSet dsWordDetails = new DataSet();
            //string strWordsReport = "select distinct fileDtls.ParentFileName,assgnPrj.taskname,l.LangISOName,(select LangISOName from tbl_langmaster l where l.LangId=fileDtls.Target_lang) as 'TargetLang',tblPrjt.ProjectNotes,fileDtls.TotalWord,RepeatedWord,TMWordCount,TranslationRequired from tbl_assignproject assgnPrj inner join tbl_filedetails fileDtls on assgnPrj.projectid=fileDtls.ProjectId inner join tbl_project tblPrjt on tblPrjt.ProjectId=assgnPrj.projectid inner join tbl_langmaster l on l.LangId = tblPrjt.LangId where assgnPrj.ProjectId = " + pid + ";";
            //MySqlDataAdapter daWordDetails = new MySqlDataAdapter(strWordsReport, connectionString.getConnection());
            //daWordDetails.Fill(dsWordDetails);
            //ViewBag.WordDetails = dsWordDetails.Tables[0];

            //DataSet dsCost = new DataSet();
            //string strCost = "select (select costtype from tbl_costmaster tbl_cstMtr where tbl_cstMtr.id=tbl_costumap.costid) as 'CostName',(select costunit from tbl_costmaster where tbl_costmaster.id=tbl_costumap.costid) as 'Unit', rateperunit, costid from tbl_costusermap tbl_costumap where userid = (select ownerID from tbl_assignproject where projectid = " + pid + " and assignto = " + user.UserId + ") and tbl_costumap.TargetUserId=" + user.UserId + ";";
            //MySqlDataAdapter daCost = new MySqlDataAdapter(strCost, connectionString.getConnection());
            //daCost.Fill(dsCost);
            //ViewBag.costrate = dsCost.Tables[0];

            //connectionString.connectionClose();
            return View();
        }

        private void ProjectAcceptForTranslatorMethod()
        {
            IdentityUser user = System.Web.HttpContext.Current.Session.GetDataFromSession<IdentityUser>("User");
            ProjectViewModel model = new ProjectViewModel();
            connectionString.connectionOpen();


            DataSet ds = new DataSet();
            string str = "SELECT p.AllowFileDownload, p.ExpectedDate, tbl_filedetails.ProjectId, tbl_filedetails.Id, tbl_filedetails.Cost, tbl_filedetails.RepeatedWord, tbl_filedetails.TranslationRequired, ap.TStatus, ap.CompletedDate, lm.LangISOName SourceLang, lm2.LangISOName TargetLang, WP.Progress, ap.status, p.ProjectId, p.ProjectName, tbl_filedetails.ProjectId, ap.taskname,ap.taskID, ap.isPublish, p.ProjectPriority FROM tbl_filedetails Inner join tbl_langmaster lm on tbl_filedetails.Source_lang = lm.LangId Inner join tbl_langmaster lm2 on tbl_filedetails.Target_lang = lm2.LangId Inner join v_Progress WP on tbl_filedetails.Id = WP.FileId inner join tbl_project p on p.ProjectId = tbl_filedetails.ProjectId inner join tbl_assignproject ap on ap.fileid = tbl_filedetails.Id where ap.status = 'Y' and ap.assignto = '" + user.UserId + "' Order by tbl_filedetails.Id desc;";

            MySqlDataAdapter da = new MySqlDataAdapter(str, connectionString.getConnection());
            da.Fill(ds);
            ViewBag.List = ds.Tables[0];
        }
        //GET
        public ActionResult ProjectAcc()
        {
            IdentityUser user = System.Web.HttpContext.Current.Session.GetDataFromSession<IdentityUser>("User");
            if (user == null)
            {
                return RedirectToAction("Login", "Account");
            }
            ProjectViewModel model = new ProjectViewModel();
            connectionString.connectionOpen();

            DataSet ds = new DataSet();
            string str = "SELECT tbl_filedetails.Id,tbl_filedetails.ParentFileName,tbl_filedetails.ChildFileName,tbl_filedetails.TotalWord, tbl_filedetails.RepeatedWord,tbl_filedetails.TMWordCount,tbl_filedetails.TranslationRequired,tbl_filedetails.`Status`,tbl_filedetails.CompletionDate,lm.LangISOName SourceLang,lm2.LangISOName TargetLang,WP.Progress, ap.status, p.ProjectId, p.ProjectName, tbl_filedetails.ProjectId FROM tbl_filedetails Inner join tbl_langmaster lm on tbl_filedetails.Source_lang = lm.LangId Inner join tbl_langmaster lm2 on tbl_filedetails.Target_lang = lm2.LangId Inner join v_Progress WP on tbl_filedetails.Id = WP.FileId inner join tbl_project p on p.ProjectId = tbl_filedetails.ProjectId inner join tbl_assignproject ap on ap.fileid = tbl_filedetails.Id where ap.status = 'Y' and ap.assignto = '" + user.UserId + "';";

            MySqlDataAdapter da = new MySqlDataAdapter(str, connectionString.getConnection());
            da.Fill(ds);

            ViewBag.List = ds.Tables[0];

            return View();
        }

        [HttpPost]
        public string ProjectAccepted(string FileName)
        {
            try
            {
                connectionString.connectionOpen();

                DataSet dsss = new DataSet();
                string strrr = "select Id from tbl_filedetails where ChildFileName = '" + FileName + "';";
                connectionString.connectionOpen();
                MySqlDataAdapter daaa = new MySqlDataAdapter(strrr, connectionString.getConnection());

                daaa.Fill(dsss);
                var FileId = dsss.Tables[0].Rows[0][0];

                string query = "UPDATE `tbl_filedetails` SET `Status` = 'Rejected' where `Id` = " + FileId + ";";
                MySqlCommand com1 = new MySqlCommand(query, connectionString.getConnection());
                com1.ExecuteNonQuery();

                ViewBag.Message = true;
                return "1";
            }
            catch (Exception ex)
            {
                ViewBag.Message = false;
                return ex.Message;
            }
            finally
            {
                connectionString.connectionClose();
            }


            //return null;
        }

        //GET
        [HttpGet]
        public ActionResult ManageCost()
        {
            DataSet ds = new DataSet();
            DataSet ds1 = new DataSet();
            IdentityUser user = System.Web.HttpContext.Current.Session.GetDataFromSession<IdentityUser>("User");
            if (user == null)
            {
                return RedirectToAction("Login", "Account");
            }
            managecost model = new managecost();
            //string str = "select cm.id, cm.costtype, cm.costunit, cu.rateperunit from `tbl_costmaster` cm LEFT OUTER JOIN `tbl_costusermap` cu on cm.id = cu.costid and cu.userid = '" + Convert.ToInt16(user.UserId) + "' and cu.TargetUserId = 0;";
            string str = "select cm.id, cm.costtype, cm.costunit from `tbl_costmaster` cm;";
            string str1 = "select * from tbl_currencymaster;";
            //string str2 = "SELECT * FROM tbl_costusermap where userid=" + user.UserId + " and TargetUserId is null;";
            connectionString.connectionOpen();

            MySqlDataAdapter da = new MySqlDataAdapter(str, connectionString.getConnection());
            MySqlDataAdapter da1 = new MySqlDataAdapter(str1, connectionString.getConnection());
            da.Fill(ds);
            da1.Fill(ds1);
            connectionString.connectionClose();

            List<SelectListItem> obj = new List<SelectListItem>();
            obj.Add(new SelectListItem { Text = "Select Currency", Value = "0" });
            for (int i = 0; i < ds1.Tables[0].Rows.Count; i++)
            {
                obj.Add(new SelectListItem { Text = ds1.Tables[0].Rows[i][1].ToString(), Value = ds1.Tables[0].Rows[i][0].ToString() });
            }

            ViewBag.LoadCurrency = obj;
            ViewBag.List = ds.Tables[0];

            DataSet ds3 = new DataSet();
            ds3 = GetLangList();
            List<SelectListItem> obj2 = new List<SelectListItem>();
            //obj2.Add(new SelectListItem { Text = "Select Language", Value = "0" });
            for (int i = 0; i < ds3.Tables[0].Rows.Count; i++)
            {
                obj2.Add(new SelectListItem { Text = ds3.Tables[0].Rows[i][1].ToString(), Value = ds3.Tables[0].Rows[i][0].ToString() });
            }

            ViewBag.LoadLang = obj2;

            //ViewBag.roleId = user.RoleId;
            return View();

        }

        //POST
        [HttpPost]
        public string ManageCost(string[] _id, string[] _ctype, string[] _unit, string[] _rate, string _curid, string usertype, string otheruserid, string langId)
        {
            IdentityUser user = System.Web.HttpContext.Current.Session.GetDataFromSession<IdentityUser>("User");
            string query = string.Empty, costUpdateQuery = string.Empty;
            string returnvalue = string.Empty;
            string valuetype = usertype;
            int userid = 0;
            int _orgid = 0;
            DataSet d = new DataSet();
            connectionString.connectionOpen();

            try
            {
                if (usertype == "Agency")
                {
                    string st = "Select `UserId` from `tbl_agencydetails` where `AgencyId` = '" + otheruserid + "';";
                    MySqlDataAdapter da = new MySqlDataAdapter(st, connectionString.getConnection());
                    da.Fill(d);
                    userid = Convert.ToInt16(d.Tables[0].Rows[0][0].ToString());
                }
                else if (usertype == "Translator")//Set Own cost
                {
                    string st = "Select `UserId` from `tbl_translatordetails` where `TransltrId` = '" + otheruserid + "';";
                    MySqlDataAdapter da = new MySqlDataAdapter(st, connectionString.getConnection());
                    da.Fill(d);
                    userid = Convert.ToInt16(d.Tables[0].Rows[0][0].ToString());
                }

                if (usertype == "Set Own cost")
                {
                    userid = Convert.ToInt16(otheruserid);
                    _orgid = Convert.ToInt16(otheruserid);
                    for (int i = 0; i < _rate.Length; i++)
                    {
                        if (_rate[i] != "")
                        {
                            string str = "select * from tbl_costusermap where `userid` = " + userid + " and `costid` = " + _id[i] + " and `TargetUserId` = '" + user.UserId + "' and `CurrencyId` = '" + Convert.ToInt16(_curid) + "' and `LangId` = '" + Convert.ToInt16(langId) + "';";
                            DataSet ds = new DataSet();
                            MySqlDataAdapter da = new MySqlDataAdapter(str, connectionString.getConnection());

                            da.Fill(ds);
                            if (ds.Tables[0].Rows.Count > 0)
                            {
                                query = "UPDATE `tbl_costusermap` set `rateperunit` = '" + _rate[i] + "' WHERE `userid` = " + userid + " and `costid` = " + _id[i] + " and `TargetUserId` = '" + user.UserId + "' and `CurrencyId` = '" + Convert.ToInt16(_curid) + "' and `LangId` = '" + Convert.ToInt16(langId) + "';";
                            }
                            else
                            {
                                query = "insert into `tbl_costusermap` (`userid`,`costid`,`rateperunit`,`CurrencyId`,`TargetUserId`,`LangId`) values ( " + userid + ", " + _id[i] + ", '" + _rate[i] + "', '" + Convert.ToInt16(_curid) + "'," + user.UserId + ",'" + Convert.ToInt16(langId) + "');";
                            }
                            MySqlCommand com = new MySqlCommand(query, connectionString.getConnection());
                            com.ExecuteNonQuery();
                        }
                        else
                        {
                            query = "UPDATE `tbl_costusermap` set `rateperunit` = '' WHERE `userid` = " + userid + " and `costid` = " + _id[i] + " and `TargetUserId` = '" + user.UserId + "' and  `LangId` = " + Convert.ToInt16(langId) + " and `CurrencyId` = " + Convert.ToInt16(_curid) + ";";
                            MySqlCommand com1 = new MySqlCommand(query, connectionString.getConnection());
                            com1.ExecuteNonQuery();
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < _rate.Length; i++)
                    {
                        if (_rate[i] != "")
                        {
                            string str = "select * from tbl_costusermap where `userid` = " + user.UserId + " and `costid` = " + _id[i] + " and `TargetUserId` = '" + Convert.ToInt16(userid) + "' and `CurrencyId` = '" + Convert.ToInt16(_curid) + "' and `LangId` = '" + Convert.ToInt16(langId) + "';";
                            DataSet ds = new DataSet();
                            MySqlDataAdapter da = new MySqlDataAdapter(str, connectionString.getConnection());

                            da.Fill(ds);
                            if (ds.Tables[0].Rows.Count > 0)
                            {
                                query = "UPDATE `tbl_costusermap` set `rateperunit` = '" + _rate[i] + "' WHERE `userid` = " + user.UserId + " and `costid` = " + _id[i] + " and `TargetUserId` = '" + Convert.ToInt16(userid) + "' and `CurrencyId` = '" + Convert.ToInt16(_curid) + "' and `LangId` = '" + Convert.ToInt16(langId) + "';";
                            }
                            else
                            {
                                query = "insert into `tbl_costusermap` (`userid`,`costid`,`rateperunit`,`CurrencyId`,`TargetUserId`,`LangId`) values ( " + user.UserId + ", " + _id[i] + ", '" + _rate[i] + "', '" + Convert.ToInt16(_curid) + "'," + userid + ",'" + Convert.ToInt16(langId) + "');";
                            }
                            MySqlCommand com = new MySqlCommand(query, connectionString.getConnection());
                            com.ExecuteNonQuery();
                        }
                        else
                        {
                            query = "UPDATE `tbl_costusermap` set `rateperunit` = '' WHERE `userid` = " + user.UserId + " and `costid` = " + _id[i] + " and `TargetUserId` = " + Convert.ToInt16(userid) + " and  `LangId` = " + Convert.ToInt16(langId) + " and `CurrencyId` = " + Convert.ToInt16(_curid) + ";";
                            MySqlCommand com1 = new MySqlCommand(query, connectionString.getConnection());
                            com1.ExecuteNonQuery();
                        }

                        //Make cost entrie for newWordUnitCost, repeatedWordUnitCost & Cost to filedetails table...////////////////////////////////////////////////////////////////
                        costUpdateQuery = "UPDATE tbl_filedetails set {0} = {1} where id in (select distinct fileid from tbl_projectassignment where {2} = {3} and source = '{4}' and Target = '{5}');";

                        if (_id[i] == "1")
                            costUpdateQuery = String.Format(costUpdateQuery, "newWordUnitCost", _rate[i], "AgencyId", otheruserid, 14, langId);
                        if (_id[i] == "3")
                            costUpdateQuery = String.Format(costUpdateQuery, "repeatedWordUnitCost", _rate[i], "AgencyId", otheruserid, 14, langId);
                        MySqlCommand com2 = new MySqlCommand(costUpdateQuery, connectionString.getConnection());
                        if (_id[i] == "1" || _id[i] == "3")
                            com2.ExecuteNonQuery();
                    }
                }

                returnvalue = "1";
            }
            catch
            {
                returnvalue = "0";
            }
            finally
            {
                connectionString.connectionClose();
            }

            return returnvalue;
        }

        //GET
        [HttpGet]
        public ActionResult TranslatorManageCost()
        {
            DataSet ds = new DataSet();
            DataSet ds1 = new DataSet();
            IdentityUser user = System.Web.HttpContext.Current.Session.GetDataFromSession<IdentityUser>("User");
            if (user == null)
            {
                return RedirectToAction("Login", "Account");
            }
            managecost model = new managecost();
            //string str = "select cm.id, cm.costtype, cm.costunit, cu.rateperunit from `tbl_costmaster` cm LEFT OUTER JOIN `tbl_costusermap` cu on cm.id = cu.costid and cu.userid = '" + Convert.ToInt16(user.UserId) + "';";
            string str = "select cm.id, cm.costtype, cm.costunit, cu.rateperunit from `tbl_costmaster` cm LEFT OUTER JOIN `tbl_costusermap` cu on cm.id = cu.costid and cu.userid = '" + Convert.ToInt16(user.UserId) + "' and cu.TargetUserId = 0;";
            string str1 = "select * from tbl_currencymaster;";
            //string str2 = "SELECT * FROM tbl_costusermap where userid=" + user.UserId + " and TargetUserId is null;";
            connectionString.connectionOpen();

            MySqlDataAdapter da = new MySqlDataAdapter(str, connectionString.getConnection());
            MySqlDataAdapter da1 = new MySqlDataAdapter(str1, connectionString.getConnection());
            da.Fill(ds);
            da1.Fill(ds1);
            connectionString.connectionClose();

            List<SelectListItem> obj = new List<SelectListItem>();
            obj.Add(new SelectListItem { Text = "-Select-", Value = "0" });
            for (int i = 0; i < ds1.Tables[0].Rows.Count; i++)
            {
                obj.Add(new SelectListItem { Text = ds1.Tables[0].Rows[i][1].ToString(), Value = ds1.Tables[0].Rows[i][0].ToString() });
            }

            ViewBag.LoadCurrency = obj;
            ViewBag.List = ds.Tables[0];

            DataSet ds2 = new DataSet();
            ds2 = GetAgency();
            List<SelectListItem> obj1 = new List<SelectListItem>();
            obj1.Add(new SelectListItem { Text = "Select Agency/Translator", Value = "0" });
            for (int i = 0; i < ds2.Tables[0].Rows.Count; i++)
            {
                obj1.Add(new SelectListItem { Text = ds2.Tables[0].Rows[i][1].ToString(), Value = ds2.Tables[0].Rows[i][0].ToString() });
            }

            ViewBag.LoadAgency = obj1;

            DataSet ds3 = new DataSet();
            ds3 = GetLangList();
            List<SelectListItem> obj2 = new List<SelectListItem>();
            //obj2.Add(new SelectListItem { Text = "Select Language", Value = "0" });
            for (int i = 0; i < ds3.Tables[0].Rows.Count; i++)
            {
                obj2.Add(new SelectListItem { Text = ds3.Tables[0].Rows[i][1].ToString(), Value = ds3.Tables[0].Rows[i][0].ToString() });
            }

            ViewBag.LoadLang = obj2;

            return View();
        }

        //POST
        [HttpPost]
        public string TranslatorCost(string[] _id, string[] _ctype, string[] _unit, string[] _rate, string _curid)
        {
            IdentityUser user = System.Web.HttpContext.Current.Session.GetDataFromSession<IdentityUser>("User");
            string query = string.Empty;
            string returnvalue = string.Empty;
            connectionString.connectionOpen();

            if (_rate == null || _curid == "0")
            {
                returnvalue = "0";
            }
            else
            {
                for (int i = 0; i < _rate.Length; i++)
                {
                    if (_rate[i] != "")
                    {
                        string str = "select * from tbl_costusermap where `userid` = " + user.UserId + " and `costid` = " + _id[i] + ";";
                        DataSet ds = new DataSet();
                        MySqlDataAdapter da = new MySqlDataAdapter(str, connectionString.getConnection());

                        da.Fill(ds);
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            query = "UPDATE `tbl_costusermap` set `rateperunit` = '" + _rate[i] + "', `CurrencyId` = '" + _curid + "'  WHERE `userid` = " + user.UserId + " and `costid` = " + _id[i] + ";";
                        }
                        else
                        {
                            query = "insert into `tbl_costusermap` (`userid`,`costid`,`rateperunit`,`CurrencyId`) values ( " + user.UserId + ", " + _id[i] + ", '" + _rate[i] + "', '" + _curid + "');";
                        }

                        MySqlCommand com1 = new MySqlCommand(query, connectionString.getConnection());
                        com1.ExecuteNonQuery();
                    }
                }

                connectionString.connectionClose();
                returnvalue = "1";
            }
            return returnvalue;
        }

        public string GetSymbol(string _id)
        {
            string symbol = string.Empty;
            try
            {
                if (_id == "0")
                {

                }
                else
                {
                    DataSet ds = new DataSet();
                    string str = "SELECT `Symbol` from `tbl_currencymaster` where `CurrencyId` = '" + _id + "' ;";
                    connectionString.connectionOpen();
                    MySqlDataAdapter da = new MySqlDataAdapter(str, connectionString.getConnection());

                    da.Fill(ds);
                    symbol = ds.Tables[0].Rows[0][0].ToString();
                }
            }
            catch (Exception e)
            {

            }
            finally
            {
                //connectionString.connectionClose();
            }
            return symbol;
        }

        [HttpGet]
        [AllowAnonymous]
        public ActionResult OrgManageCost()
        {
            DataSet ds = new DataSet();
            DataSet ds1 = new DataSet();
            IdentityUser user = System.Web.HttpContext.Current.Session.GetDataFromSession<IdentityUser>("User");
            if (user == null)
            {
                return RedirectToAction("Login", "Account");
            }
            managecost model = new managecost();
            string str = "select cm.id, cm.costtype, cm.costunit, cu.rateperunit from `tbl_costmaster` cm LEFT OUTER JOIN `tbl_costusermap` cu on cm.id = cu.costid and cu.userid = '" + Convert.ToInt16(user.UserId) + "' and cu.TargetUserId = 0;";
            string str1 = "select * from tbl_currencymaster;";
            //string str2 = "SELECT * FROM tbl_costusermap where userid=" + user.UserId + " and TargetUserId is null;";
            connectionString.connectionOpen();

            MySqlDataAdapter da = new MySqlDataAdapter(str, connectionString.getConnection());
            MySqlDataAdapter da1 = new MySqlDataAdapter(str1, connectionString.getConnection());
            da.Fill(ds);
            da1.Fill(ds1);
            connectionString.connectionClose();

            List<SelectListItem> obj = new List<SelectListItem>();
            obj.Add(new SelectListItem { Text = "Select Currency", Value = "0" });
            for (int i = 0; i < ds1.Tables[0].Rows.Count; i++)
            {
                obj.Add(new SelectListItem { Text = ds1.Tables[0].Rows[i][1].ToString(), Value = ds1.Tables[0].Rows[i][0].ToString() });
            }

            ViewBag.LoadCurrency = obj;
            ViewBag.List = ds.Tables[0];


            DataSet ds2 = new DataSet();
            ds2 = GetAgency();
            List<SelectListItem> obj1 = new List<SelectListItem>();
            obj1.Add(new SelectListItem { Text = "Select Agency/Translator", Value = "0" });
            for (int i = 0; i < ds2.Tables[0].Rows.Count; i++)
            {
                obj1.Add(new SelectListItem { Text = ds2.Tables[0].Rows[i][1].ToString(), Value = ds2.Tables[0].Rows[i][0].ToString() });
            }

            ViewBag.LoadAgency = obj1;

            DataSet ds3 = new DataSet();
            ds3 = GetLangList();
            List<SelectListItem> obj2 = new List<SelectListItem>();
            //obj2.Add(new SelectListItem { Text = "Select Language", Value = "0" });
            for (int i = 0; i < ds3.Tables[0].Rows.Count; i++)
            {
                obj2.Add(new SelectListItem { Text = ds3.Tables[0].Rows[i][1].ToString(), Value = ds3.Tables[0].Rows[i][0].ToString() });
            }

            ViewBag.LoadLang = obj2;

            DataSet dsCostReport = new DataSet();
            connectionString.connectionOpen();
            string strCostReport = "select cu.id,us.UserName as 'UserName',(select Name from tbl_roles where RoleId in (select RoleId from tbl_users where UserId=cu.userid)) as 'VendorName',cm.costtype,cmst.CurrencyName,cmst.Symbol,cm.costunit,cm.costtype,cu.rateperunit,lm.LangEnglishName as 'SourceLang',(select distinct LangEnglishName from tbl_langmaster where LangId=cu.destLangId) as 'DestLang',(select distinct UserName from tbl_users where userid=cu.TargetUserId) as 'TargetUserName' from tbl_costmaster cm inner join tbl_costusermap cu on cm.id = cu.costid inner join tbl_currencymaster cmst on cmst.CurrencyId = cu.CurrencyId inner join tbl_langmaster lm on cu.LangId=lm.LangId inner join tbl_users us on us.UserId=cu.userid where cu.userid=" + user.UserId + ";";
            MySqlDataAdapter daCostReport = new MySqlDataAdapter(strCostReport, connectionString.getConnection());
            daCostReport.Fill(dsCostReport);
            ViewBag.CostReport = dsCostReport.Tables[0];
            connectionString.connectionClose();

            return View();
        }

        //POST
        [HttpPost]
        public string OrgManageCost(string[] _id, string[] _ctype, string[] _unit, string[] _rate, string _curid, string agencyid, string langId, string destLangId, string vtype)
        {
            //Update tbl_costusermap and also file details table

            IdentityUser user = System.Web.HttpContext.Current.Session.GetDataFromSession<IdentityUser>("User");
            string query = string.Empty;
            string returnvalue = string.Empty, costUpdateQuery = string.Empty;
            int userid = 0;
            DataSet d = new DataSet();

            connectionString.connectionOpen();


            if (agencyid != null && agencyid != "0")
            {
                string st = string.Empty;
                if (vtype == "Translator")
                {
                    st = "Select `UserId` from `tbl_translatordetails` where `TransltrId` = '" + agencyid + "';";
                }
                else
                {
                    st = "Select `UserId` from `tbl_agencydetails` where `AgencyId` = '" + agencyid + "';";
                }


                MySqlDataAdapter da = new MySqlDataAdapter(st, connectionString.getConnection());
                da.Fill(d);
                userid = Convert.ToInt16(d.Tables[0].Rows[0][0].ToString());
            }
            else
            {
                userid = user.UserId;
                agencyid = Convert.ToString(userid);
            }


            try
            {
                for (int i = 0; i < _rate.Length; i++)
                {
                    if (_rate[i] != "")
                    {
                        string str = "select * from tbl_costusermap where `userid` = " + user.UserId + " and `costid` = " + _id[i] + " and `TargetUserId` = " + Convert.ToInt16(userid) + " and  `LangId` = " + Convert.ToInt16(langId) + " and  `destLangId` = " + Convert.ToInt16(destLangId) + " and `CurrencyId` = " + Convert.ToInt16(_curid) + ";";
                        DataSet ds = new DataSet();
                        MySqlDataAdapter da1 = new MySqlDataAdapter(str, connectionString.getConnection());
                        da1.Fill(ds);
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            query = "UPDATE `tbl_costusermap` set `rateperunit` = '" + _rate[i] + "' WHERE `userid` = " + user.UserId + " and `costid` = " + _id[i] + " and `TargetUserId` = " + Convert.ToInt16(userid) + " and  `LangId` = " + Convert.ToInt16(langId) + " and  `destLangId` = " + Convert.ToInt16(destLangId) + " and `CurrencyId` = " + Convert.ToInt16(_curid) + ";";
                        }
                        else
                        {
                            query = "insert into `tbl_costusermap` (`userid`,`costid`,`rateperunit`,`CurrencyId`,`TargetUserId`,`LangId`,`destLangId`) values ( " + user.UserId + ", " + _id[i] + ", '" + _rate[i] + "', " + Convert.ToInt16(_curid) + "," + Convert.ToInt16(userid) + ", " + Convert.ToInt16(langId) + ", " + Convert.ToInt16(destLangId) + ");";
                        }

                        MySqlCommand com1 = new MySqlCommand(query, connectionString.getConnection());
                        com1.ExecuteNonQuery();
                    }
                    else
                    {
                        query = "UPDATE `tbl_costusermap` set `rateperunit` = '' WHERE `userid` = " + user.UserId + " and `costid` = " + _id[i] + " and `TargetUserId` = " + Convert.ToInt16(userid) + " and  `LangId` = " + Convert.ToInt16(langId) + " and  `destLangId` = " + Convert.ToInt16(destLangId) + " and `CurrencyId` = " + Convert.ToInt16(_curid) + ";";
                        MySqlCommand com1 = new MySqlCommand(query, connectionString.getConnection());
                        com1.ExecuteNonQuery();
                    }
                }

                returnvalue = "1";
            }
            catch (Exception ex)
            {
                string exception = ex.Message.ToString();
                returnvalue = "0";
            }
            finally
            {
                connectionString.connectionClose();
            }

            return returnvalue;
        }

        public DataSet GetAgency()
        {
            DataSet ds = new DataSet();
            connectionString.connectionOpen();
            try
            {
                string str = "Select `AgencyId`,`AgencyName` from `tbl_agencydetails` where `AgencyId` IS NOT NULL and `AgencyId` !='' and `UserId` IS NOT NULL;";
                MySqlDataAdapter da = new MySqlDataAdapter(str, connectionString.getConnection());

                da.Fill(ds);
            }
            catch
            {

            }
            finally
            {
                connectionString.connectionClose();
            }
            return ds;
        }

        //GET
        [HttpGet]
        public string LoadCostInfo(string curid, string targetUserRole, string targetUserId, string langId, string destLangId)
        {
            IdentityUser user = System.Web.HttpContext.Current.Session.GetDataFromSession<IdentityUser>("User");

            string query = string.Empty;
            string _val = string.Empty;
            DataTable dt = new DataTable();
            connectionString.connectionOpen();

            int userid = 0;

            if (!string.IsNullOrWhiteSpace(targetUserId))
            {
                DataSet d = new DataSet();
                string st = "Select `UserId` from `tbl_" + targetUserRole + "details` where `" + (targetUserRole == "Translator" ? "Transltr" : targetUserRole) + "Id` = '" + targetUserId + "';";
                MySqlDataAdapter da = new MySqlDataAdapter(st, connectionString.getConnection());
                da.Fill(d);
                userid = Convert.ToInt16(d.Tables[0].Rows[0][0].ToString());
            }
            else
            {
                targetUserId = Convert.ToString(user.UserId);
                userid = user.UserId;
            }

            try
            {
                query = "Select `costid`, `rateperunit` from `tbl_costusermap` where `userid` = '" + user.UserId + "' and `CurrencyId` = " + curid + " and `TargetUserId` = " + userid + " and  `LangId` = " + langId + " and `destLangId` = " + destLangId + " ;";
                MySqlDataAdapter da1 = new MySqlDataAdapter(query, connectionString.getConnection());
                da1.Fill(dt);
                dt.TableName = "data";
                _val = DataTableToJSONWithJavaScriptSerializerDT(dt);
            }
            catch
            {
                _val = "";
            }
            finally
            {
                connectionString.connectionClose();
            }
            return _val;
        }

        //GET
        [HttpGet]
        public string GetCostInfo(string curid, string type, string langId, string typename)
        {
            IdentityUser user = System.Web.HttpContext.Current.Session.GetDataFromSession<IdentityUser>("User");
            string query = string.Empty;
            string _val = string.Empty;
            int userid = 0;
            DataTable dt = new DataTable();
            DataSet d = new DataSet();
            connectionString.connectionOpen();

            try
            {
                if (type == "Agency")
                {
                    string st = "Select `UserId` from `tbl_agencydetails` where `AgencyId` = '" + typename + "';";
                    MySqlDataAdapter da = new MySqlDataAdapter(st, connectionString.getConnection());
                    da.Fill(d);
                    userid = Convert.ToInt16(d.Tables[0].Rows[0][0].ToString());
                }
                else if (type == "Translator")//Set Own cost
                {
                    string st = "Select `UserId` from `tbl_translatordetails` where `TransltrId` = '" + typename + "';";
                    MySqlDataAdapter da = new MySqlDataAdapter(st, connectionString.getConnection());
                    da.Fill(d);
                    userid = Convert.ToInt16(d.Tables[0].Rows[0][0].ToString());
                }
                else if (type == "Set Own cost")
                {
                    userid = Convert.ToInt16(typename);
                }

                if (type == "Set Own cost")
                {
                    query = "Select `costid`, `rateperunit` from `tbl_costusermap` where `userid` = " + userid + " and `CurrencyId` = " + curid + " and `TargetUserId` = '" + user.UserId + "' and  `LangId` = " + langId + ";";
                }
                else
                {
                    query = "Select `costid`, `rateperunit` from `tbl_costusermap` where `userid` = '" + user.UserId + "' and `CurrencyId` = " + curid + " and `TargetUserId` = " + userid + " and  `LangId` = " + langId + ";";
                }

                MySqlDataAdapter da1 = new MySqlDataAdapter(query, connectionString.getConnection());
                da1.Fill(dt);
                dt.TableName = "data";
                _val = DataTableToJSONWithJavaScriptSerializerDT(dt);
            }
            catch
            {
                _val = "";
            }
            finally
            {
                connectionString.connectionClose();
            }

            return _val;
        }

        //GET
        [HttpGet]
        public string getEmailInfo(string aid, string ddltype)
        {
            string _value = string.Empty;
            DataSet ds = new DataSet();
            connectionString.connectionOpen();

            try
            {
                if (ddltype == "Agency")
                {
                    string str = "Select `EmailId` from `tbl_agencydetails` where `AgencyId` = " + Convert.ToInt16(aid) + ";";
                    MySqlDataAdapter da = new MySqlDataAdapter(str, connectionString.getConnection());
                    da.Fill(ds);
                }
                if (ddltype == "Translator")
                {
                    string str = "Select `EmailId` from `tbl_translatordetails` where `TransltrId` = " + Convert.ToInt16(aid) + ";";
                    MySqlDataAdapter da = new MySqlDataAdapter(str, connectionString.getConnection());
                    da.Fill(ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    _value = ds.Tables[0].Rows[0][0].ToString();
                }
                else
                {
                    return null;
                }
            }
            catch
            {
                return null;
            }
            finally
            {
                connectionString.connectionClose();
            }
            return _value;
        }

        [HttpPost]
        public string DeleteProjectById(string projId)
        {
            string _value = string.Empty;
            try
            {
                connectionString.connectionOpen();


                DataTable dt = new DataTable();
                string getStr1 = "SELECT * FROM tbl_filedetails WHERE ProjectId = '" + Convert.ToInt16(projId) + "';";
                MySqlDataAdapter da = new MySqlDataAdapter(getStr1, connectionString.getConnection());
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    string str = "Delete tf , tp from `tbl_project` tp,`tbl_filedetails` tf where tp.`ProjectId` = '" + Convert.ToInt16(projId) + "' and tf.`ProjectId` = '" + Convert.ToInt16(projId) + "';";
                    MySqlCommand com1 = new MySqlCommand(str, connectionString.getConnection());
                    com1.ExecuteNonQuery();
                }
                else
                {
                    string str = "SET SQL_SAFE_UPDATES = 0;Delete from `tbl_project` where `ProjectId` = '" + Convert.ToInt16(projId) + "';SET SQL_SAFE_UPDATES = 1;";
                    MySqlCommand com1 = new MySqlCommand(str, connectionString.getConnection());
                    com1.ExecuteNonQuery();
                }

                _value = "1";
            }
            catch
            {
                _value = "0";
            }
            finally
            {
                connectionString.connectionClose();
            }
            return _value;
        }
        public string DeleteFileById(string fid)
        {
            string _value = string.Empty;
            try
            {
                connectionString.connectionOpen();

                string str = "Delete tf from `tbl_filedetails` tf where tf.`Id` = '" + Convert.ToInt16(fid) + "';";
                MySqlCommand com1 = new MySqlCommand(str, connectionString.getConnection());
                com1.ExecuteNonQuery();
                _value = "1";
            }
            catch
            {
                _value = "0";
            }
            finally
            {
                connectionString.connectionClose();
            }
            return _value;
        }
        //POST
        [HttpPost]
        public string projectcancel(string comment, string pid)
        {
            string _value = string.Empty;
            connectionString.connectionOpen();
            try
            {

                string str = "Update `tbl_filedetails` set `Comment` = '" + comment + "', `Status`= 'Canceled' where `ProjectId` = " + Convert.ToInt16(pid) + ";";
                MySqlCommand com = new MySqlCommand(str, connectionString.getConnection());
                com.ExecuteNonQuery();
                string str1 = "Update `tbl_project` set `Status`= 'Canceled' where `ProjectId` = " + Convert.ToInt16(pid) + ";";
                MySqlCommand com1 = new MySqlCommand(str1, connectionString.getConnection());
                com1.ExecuteNonQuery();
                _value = "1";
            }
            catch
            {
                _value = "0";
            }
            finally
            {
                connectionString.connectionClose();
            }
            return _value;
        }

        //POST
        [HttpPost]
        public string IndiProjectTraslation(int fid, string Source, string Destination, string PreferredAgency, string AgencyName, string TranslatorName, string CompletionDate, string CostValue, string CostSymbol)
        {
            string _value = string.Empty;
            try
            {
                connectionString.connectionOpen();

                DateTime Date = DateTime.Parse(CompletionDate, CultureInfo.InvariantCulture);
                string completedate = Date.ToString("yyyy-MM-dd HH:mm:ss");
                IdentityUser user = System.Web.HttpContext.Current.Session.GetDataFromSession<IdentityUser>("User");

                if (fid == null)
                {
                    _value = "-1";
                }
                else
                {
                    DataSet dss = new DataSet();
                    string strr = "select `ProjectId` from `tbl_filedetails` where `Id` = '" + fid + "';";
                    MySqlDataAdapter daa = new MySqlDataAdapter(strr, connectionString.getConnection());
                    daa.Fill(dss);
                    var projId = dss.Tables[0].Rows[0][0];

                    string st = "Update `tbl_project` set `Status` = 'Assigned to Agency' where `ProjectId` = " + projId + ";";
                    MySqlCommand com = new MySqlCommand(st, connectionString.getConnection());
                    com.ExecuteNonQuery();

                    DataSet dst = new DataSet();
                    string strg = "select `CurrencyId` from `tbl_currencymaster` where `Symbol`= '" + CostSymbol + "';";
                    MySqlDataAdapter dad = new MySqlDataAdapter(strg, connectionString.getConnection());
                    dad.Fill(dst);
                    var CurrencyId = dst.Tables[0].Rows[0][0];
                    if (AgencyName != null && AgencyName != "")
                    {
                        DataSet ds = new DataSet();
                        string str = "select `EmailId`, `UserId` from `tbl_agencydetails` where `AgencyId` = '" + AgencyName + "';";
                        MySqlDataAdapter da = new MySqlDataAdapter(str, connectionString.getConnection());
                        da.Fill(ds);
                        var email = ds.Tables[0].Rows[0][0];
                        var userid = ds.Tables[0].Rows[0][1];

                        string query = "UPDATE `tbl_projectassignment` SET `AgencyId` = " + AgencyName + " , `AssignDate`='" + DateTime.Now.ToString("yyyy-MM-dd") + "',  `CompletionDate`= '" + completedate + "' where `FileId` = " + fid + ";";
                        MySqlCommand com1 = new MySqlCommand(query, connectionString.getConnection());
                        com1.ExecuteNonQuery();

                        string query1 = "UPDATE `tbl_filedetails` SET `Status` = 'Assigned to Agency', `Cost`='" + CostValue + "', `CurrencyId` = '" + Convert.ToInt32(CurrencyId) + "' where `Id` = " + fid + ";";
                        MySqlCommand com2 = new MySqlCommand(query1, connectionString.getConnection());
                        com2.ExecuteNonQuery();

                        string query2 = "Insert into `tbl_assignproject` (`ownerid`,`assignto`,`useremail`,`projectid`,`status`,`assigndate`,`userid`,`fileid`) values (" + user.UserId + ", '" + userid + "','" + email + "', " + projId + ", 'N', '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','" + userid + "','" + fid + "');";
                        MySqlCommand com3 = new MySqlCommand(query2, connectionString.getConnection());
                        com3.ExecuteNonQuery();
                    }
                    if (TranslatorName != null)
                    {
                        DataSet ds = new DataSet();
                        string str = "select `EmailId`, `UserId` from `tbl_translatordetails` where `TransltrId` = '" + TranslatorName + "';";
                        MySqlDataAdapter da = new MySqlDataAdapter(str, connectionString.getConnection());
                        da.Fill(ds);
                        var email = ds.Tables[0].Rows[0][0];
                        var userid = ds.Tables[0].Rows[0][1];

                        string query = "UPDATE `tbl_projectassignment` SET `TranslatorId` = " + TranslatorName + " , `AssignDate`='" + DateTime.Now.ToString("yyyy-MM-dd") + "',  `CompletionDate`= '" + completedate + "' where `FileId` = " + fid + ";";
                        MySqlCommand com1 = new MySqlCommand(query, connectionString.getConnection());
                        com1.ExecuteNonQuery();

                        string query1 = "UPDATE `tbl_filedetails` SET `Status` = 'Assigned to Agency', `Cost`='" + CostValue + "', `CurrencyId` = '" + Convert.ToInt32(CurrencyId) + "' where `Id` = " + fid + ";";
                        MySqlCommand com2 = new MySqlCommand(query1, connectionString.getConnection());
                        com2.ExecuteNonQuery();

                        string query2 = "Insert into `tbl_assignproject` (`ownerid`,`assignto`,`useremail`,`projectid`,`status`,`assigndate`,`userid`,`fileid`) values (" + user.UserId + ", '" + userid + "','" + email + "', " + projId + ", 'N', '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','" + userid + "','" + fid + "');";
                        MySqlCommand com3 = new MySqlCommand(query2, connectionString.getConnection());
                        com3.ExecuteNonQuery();
                    }

                    ViewBag.Message = true;
                    _value = "1";
                }

            }
            catch (Exception ex)
            {
                _value = "0";
                return ex.Message;
            }
            finally
            {
                connectionString.connectionClose();
            }
            return _value;
        }

        //POST
        [HttpPost]
        public string FullProjectTranslation(int pid, string AgencyName, string CompletionDate, string Completiontime, string CostValue)
        {
            string _val = string.Empty;
            IdentityUser user = System.Web.HttpContext.Current.Session.GetDataFromSession<IdentityUser>("User");
            try
            {
                string ProjectETime = Completiontime;
                string ProjectEDate = CompletionDate;
                DateTime edate = DateTime.ParseExact(ProjectEDate, "MM/dd/yyyy", null);
                DateTime combinedDate = edate.Add(TimeSpan.Parse(ProjectETime));
                //string timestr = ProjectETime.ToString("HH:mm");
                string eformatForMySql = combinedDate.ToString("yyyy-MM-dd HH:mm");

                connectionString.connectionOpen();

                string strvalue = "Update `tbl_project` set `Status` = 'Assigned to Agency' where `ProjectId` = " + pid + ";";
                MySqlCommand com = new MySqlCommand(strvalue, connectionString.getConnection());
                com.ExecuteNonQuery();
                DataSet d = new DataSet();
                string st = "Select `Id` from `tbl_filedetails` where `ProjectId` = " + pid + "";
                MySqlDataAdapter mda = new MySqlDataAdapter(st, connectionString.getConnection());
                mda.Fill(d);
                for (int i = 0; i < d.Tables[0].Rows.Count; i++)
                {
                    if (AgencyName != null && AgencyName != "")
                    {
                        int id = Convert.ToInt16(d.Tables[0].Rows[i][0]);
                        DataSet ds = new DataSet();
                        string str = "select `EmailId`, `UserId` from `tbl_agencydetails` where `AgencyId` = '" + AgencyName + "';";
                        MySqlDataAdapter da = new MySqlDataAdapter(str, connectionString.getConnection());
                        da.Fill(ds);
                        var email = ds.Tables[0].Rows[0][0];
                        var userid = ds.Tables[0].Rows[0][1];

                        string query = "UPDATE `tbl_projectassignment` SET `AgencyId` = " + AgencyName + " , `AssignDate`='" + DateTime.Now.ToString("yyyy-MM-dd") + "',  `CompletionDate`= '" + eformatForMySql + "' where `FileId` = " + Convert.ToInt16(d.Tables[0].Rows[i][0]) + ";";
                        MySqlCommand com1 = new MySqlCommand(query, connectionString.getConnection());
                        com1.ExecuteNonQuery();

                        string query1 = "UPDATE `tbl_filedetails` SET `Status` = 'Assigned to Agency', `Cost`='" + CostValue + "' where `Id` = " + Convert.ToInt16(d.Tables[0].Rows[i][0]) + ";";
                        MySqlCommand com2 = new MySqlCommand(query1, connectionString.getConnection());
                        com2.ExecuteNonQuery();

                        string query2 = "Insert into `tbl_assignproject` (`ownerid`,`assignto`,`useremail`,`projectid`,`status`,`assigndate`,`userid`,`fileid`) values (" + user.UserId + ", '" + userid + "','" + email + "', " + pid + ", 'N', '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','" + userid + "'," + Convert.ToInt16(d.Tables[0].Rows[i][0]) + ");";
                        MySqlCommand com3 = new MySqlCommand(query2, connectionString.getConnection());
                        com3.ExecuteNonQuery();
                    }
                }
                _val = "1";
            }
            catch
            {
                _val = "0";
            }
            finally
            {
                connectionString.connectionClose();
            }
            return _val;
        }

        [HttpPost]
        public string SaveQuery(string Id, string query, string _fid)
        {
            DataSet ds = new DataSet();
            string fquery = query;
            IdentityUser user = System.Web.HttpContext.Current.Session.GetDataFromSession<IdentityUser>("User");
            string returnValue = "";
            AccountController getrole = new AccountController();
            string rlname = getrole.getRoleName(user.UserId);
            Int32 keyId = Convert.ToInt32(Id);
            connectionString.connectionOpen();


            try
            {
                if (rlname == "Translator")
                {
                    try
                    {
                        query = "Translator # " + query;
                        query = "insert into tbl_querymgmt (querydescription,translatorId,keyId,alignment) values ( '" + query + "'," + user.UserId + "," + keyId + ",'left')";
                        MySqlCommand com = new MySqlCommand(query, connectionString.getConnection());
                        com.ExecuteNonQuery();

                        string str = "SELECT ownerid FROM tbl_assignproject where fileid = '" + _fid + "' order by id limit 1;";
                        MySqlDataAdapter da = new MySqlDataAdapter(str, connectionString.getConnection());
                        da.Fill(ds);
                        int oid = 0;
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            oid = Convert.ToInt16(ds.Tables[0].Rows[0][0].ToString());
                        }

                        string strNotification = "INSERT INTO `tbl_notifications`(`nid`,`fid`,`tid`,`oid`,`status`,`ndate`,`keyId`,querydescription) VALUES (1," + _fid + "," + oid + "," + user.UserId + ",1,'" + System.DateTime.Now.ToString("d") + "'," + keyId + ",'" + fquery + "'); ";

                        MySqlCommand com1 = new MySqlCommand(strNotification, connectionString.getConnection());
                        com1.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        string strNotification = "INSERT INTO `tbl_notifications`(querydescription) VALUES ('" + ex.Message + "'); ";

                        MySqlCommand com1 = new MySqlCommand(strNotification, connectionString.getConnection());
                        com1.ExecuteNonQuery();
                    }
                }
                else if (rlname == "Organization" || rlname == "Agency")
                {
                    try
                    {
                        query = "Organization # " + query;
                        query = "insert into tbl_querymgmt (querydescription,organizationId,keyId,alignment) values ('" + query + "'," + user.UserId + "," + keyId + ",'right')";
                        MySqlCommand com = new MySqlCommand(query, connectionString.getConnection());
                        com.ExecuteNonQuery();

                        string str = "SELECT assignto FROM tbl_assignproject where fileid =  '" + _fid + "'  order by id desc limit 1;";
                        MySqlDataAdapter da = new MySqlDataAdapter(str, connectionString.getConnection());
                        da.Fill(ds);
                        int oid = 0;
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            oid = Convert.ToInt16(ds.Tables[0].Rows[0][0].ToString());
                        }

                        string strNotification = "INSERT INTO `tbl_notifications`(`nid`,`fid`,`tid`,`oid`,`status`,`ndate`,`keyId`,querydescription) VALUES (1," + _fid + "," + oid + "," + user.UserId + ",1,'" + System.DateTime.Now.ToString("d") + "'," + keyId + ",'" + fquery + "'); ";

                        MySqlCommand com1 = new MySqlCommand(strNotification, connectionString.getConnection());
                        com1.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        string strNotification = "INSERT INTO `tbl_notifications`(querydescription) VALUES ('" + ex.Message + "'); ";

                        MySqlCommand com1 = new MySqlCommand(strNotification, connectionString.getConnection());
                        com1.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                returnValue = "Some error occurred.";
            }
            finally
            {
                connectionString.connectionClose();
            }

            return returnValue;
        }

        [HttpGet]
        public string getKeyId(int Id)
        {
            TranslatorViewModel model = new TranslatorViewModel();
            string _value = string.Empty;
            DataSet ds = new DataSet();
            string str = "Select `ID`, `FileId`,`Value`,`ValueTarget`, `KeyName` from `tbl_projectassignment` where `FileId` = " + Id + ";";
            connectionString.connectionOpen();

            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter(str, connectionString.getConnection());
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    _value = ds.Tables[0].Rows[0][0].ToString();
                }
                else
                {
                    return null;
                }
            }
            catch
            {
                return null;
            }
            finally
            {
                connectionString.connectionClose();
            }
            return _value;
        }

        [HttpGet]
        public string GetQuery(string Id)
        {
            Int32 keyId = Convert.ToInt32(Id);
            DataSet ds = new DataSet();
            List<ListItem> ddl = new List<ListItem>();
            connectionString.connectionOpen();

            try
            {
                string str = "Select `queryId`,`querydescription`,creationDate,`alignment` from `tbl_querymgmt` where `keyId` = " + keyId + ";";
                MySqlDataAdapter da = new MySqlDataAdapter(str, connectionString.getConnection());
                da.Fill(ds);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    DateTime todayDateTime = DateTime.Now;
                    DateTime creationDate = Convert.ToDateTime(dr["creationDate"].ToString());
                    TimeSpan ts = todayDateTime.Subtract(creationDate);
                    ddl.Add(new ListItem
                    {
                        Value = dr["alignment"].ToString(),
                        Text = dr["querydescription"].ToString() + "$" + todayDateTime.ToString("dd-MMM-yyyy hh:mm"),
                    });
                }
            }
            catch
            {
                return "Some error occurred.";
            }
            finally
            {
                connectionString.connectionClose();
            }

            JavaScriptSerializer jSearializer = new JavaScriptSerializer();
            return jSearializer.Serialize(ddl);
        }

        [HttpGet]
        public ActionResult ReferenceFile()
        {
            List<ReferenceFile> model = new List<ReferenceFile>();
            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();
            IdentityUser user = System.Web.HttpContext.Current.Session.GetDataFromSession<IdentityUser>("User");
            if (user == null)
            {
                return RedirectToAction("Login", "Account");
            }
            connectionString.connectionOpen();


            int roleid = Convert.ToInt32(Session["RoleId"]);
            string strQry = string.Empty;
            string strQry1 = string.Empty;
            if (roleid == 2)
            {
                strQry = @"SELECT * FROM tbl_project where OwnerId=" + user.UserId + ";";

                MySqlDataAdapter da = new MySqlDataAdapter(strQry, connectionString.getConnection());
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        model.Add(new ReferenceFile { UserID = Convert.ToInt32(user.UserId), ProjectId = Convert.ToInt32(dt.Rows[i][0]), ProjectName = dt.Rows[i][2].ToString() });
                    }
                }
                connectionString.connectionClose();
            }
            else
            {

                if (roleid == 3)
                {
                    strQry1 = @"select distinct projectid from tbl_assignproject where userid='" + user.UserId.ToString() + "' or  ownerid='" + user.UserId.ToString() + "';";
                }
                else
                {
                    strQry1 = @"select distinct projectid from tbl_assignproject where userid='" + user.UserId.ToString() + "';";
                }

                MySqlDataAdapter da1 = new MySqlDataAdapter(strQry1, connectionString.getConnection());
                da1.Fill(dt1);
                string str2 = string.Empty;
                for (int k = 0; k < dt1.Rows.Count; k++)
                {
                    if (k == 0)
                    {
                        str2 = str2 + Convert.ToInt32(dt1.Rows[k][0].ToString());
                    }
                    else
                    {
                        str2 = str2 + "," + Convert.ToInt32(dt1.Rows[k][0].ToString());
                    }



                }
                strQry = @"SELECT * FROM tbl_project where ProjectId in (" + str2 + ");";
                MySqlDataAdapter da = new MySqlDataAdapter(strQry, connectionString.getConnection());
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        model.Add(new ReferenceFile { UserID = Convert.ToInt32(user.UserId), ProjectId = Convert.ToInt32(dt.Rows[i][0]), ProjectName = dt.Rows[i][2].ToString() });
                    }
                }
                connectionString.connectionClose();

            }


            return View(model);
        }

        public string GetReferenceFiles(int fid)
        {
            string str1;
            try
            {
                IdentityUser user = System.Web.HttpContext.Current.Session.GetDataFromSession<IdentityUser>("User");
                DataTable dt = new DataTable();

                string retTable = string.Empty;
                int roleid = Convert.ToInt32(Session["RoleId"]);
                string getStr1 = string.Empty;
                if (roleid == 2)
                {
                    getStr1 = "Select *  from tbl_referencefileupload f, tbl_project a where f.ProjectId = a.ProjectId and a.ownerid = " + user.UserId + " and f.ProjectId = " + fid + ";";
                }
                else if (roleid == 3)
                {
                    getStr1 = "Select *  from tbl_referencefileupload f, tbl_project a where ( f.ProjectId = a.ProjectId and ( a.ownerid = " + user.UserId + " OR f.ProjectId = " + fid + " )) OR ( f.ProjectId = " + fid + " and f.StatusForAgency=1 );";
                    //getStr1 = "Select *  from tbl_referencefileupload where ( ProjectId = " + fid + " and StatusForAgency=1 ) OR  ;";
                }
                else
                {
                    getStr1 = "Select *  from tbl_referencefileupload where  ProjectId = " + fid + " and StatusForTranslator=1;";
                }
                connectionString.connectionOpen();
                MySqlDataAdapter da = new MySqlDataAdapter(getStr1, connectionString.getConnection());

                da.Fill(dt);
                connectionString.connectionClose();
                //System.Web.Script.Serialization.JavaScriptSerializer serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
                //List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
                //Dictionary<string, object> row;
                //foreach (DataRow dr in dt.Rows)
                //{
                //    row = new Dictionary<string, object>();
                //    foreach (DataColumn col in dt.Columns)
                //    {
                //        row.Add(col.ColumnName, dr[col]);
                //    }
                //    rows.Add(row);
                dt.TableName = "data";
                str1 = DataTableToJSONWithJavaScriptSerializerDT(dt);
                //}
            }
            catch (Exception ex)
            {
                str1 = ex.Message;
            }
            return str1;
        }
        public string UpdateReferenceFiles(int aval, int aid, string getroletype)
        {
            string msg = "";
            string sid = "";
            try
            {
                sid = getassigneeID(aid, getroletype);
                string str = string.Empty;

                if (getroletype == "a")
                {
                    str = "UPDATE `tbl_referencefileupload` SET  `StatusForAgency` = " + Convert.ToInt32(aval) + " WHERE ID = " + aid + ";";

                }
                else
                {
                    str = "UPDATE `tbl_referencefileupload` SET  `StatusForTranslator` = " + Convert.ToInt32(aval) + " WHERE ID = " + aid + ";";
                }
                connectionString.connectionOpen();

                MySqlCommand com = new MySqlCommand(str, connectionString.getConnection());
                com.ExecuteNonQuery();
                connectionString.connectionClose();
                msg = "Status Updated successfully";
            }
            catch
            {
                msg = "Error! Please try again later.";
            }
            return msg;
        }
        private string getassigneeID(int id, string getroletype)
        {
            string str = "";
            try
            {
                DataTable dt = new DataTable();
                DataTable dt1 = new DataTable();
                string str1 = "select ProjectId from tbl_referencefileupload where id=" + id + "";
                connectionString.connectionOpen();
                MySqlDataAdapter da = new MySqlDataAdapter(str1, connectionString.getConnection());

                da.Fill(dt);
                string str2 = "select userid from tbl_assignproject where projectid=" + Convert.ToInt32(dt.Rows[0][0].ToString()) + " order by id;";
                MySqlDataAdapter da1 = new MySqlDataAdapter(str2, connectionString.getConnection());
                da1.Fill(dt1);
                if (getroletype == "a")
                    str = dt1.Rows[0][0].ToString();
                else if (dt1.Rows.Count > 1 && getroletype != "a")
                    str = dt1.Rows[1][0].ToString();
                connectionString.connectionClose();
            }
            catch
            {

            }

            return str;
        }

        public string projectcreation(FormCollection collection)
        {
            string AID = "", AN = "", AE = "", AG = "", agID = "";
            string[] _AID = { }, _ANAME = { }, _AEMAIL = { };

            IdentityUser user = System.Web.HttpContext.Current.Session.GetDataFromSession<IdentityUser>("User");
            int ownerid = user.UserId;
            string _res = string.Empty;
            string ProjectName = collection["ProjectName"].ToString();
            string ProjectPriority = collection["ProjectPriority"].ToString();
            string ProjectCategory = collection["ProjectCategory"].ToString();
            string ProjectTask = collection["ProjectTask"].ToString();
            string ProjectOrder = collection["ProjectOrder"].ToString();
            string ProjectSDate = collection["ProjectSDate"].ToString();
            string ProjectEDate = collection["ProjectEDate"].ToString();
            string ProjectETime = collection["ProjectETime"].ToString();
            string Source = collection["Source"].ToString();
            string Destination = collection["Destination"].ToString();
            string fileName = collection["fileName"].ToString();
            string fileNamewoExn = collection["fileNamewoExn"].ToString();
            string AgencyID = collection["AgencyID"].ToString();
            string AgencyName = collection["AgencyName"].ToString();
            string AgencyEmail = collection["AgencyEmail"].ToString();
            int allowTransFileDownload = Convert.ToBoolean(collection["allowTransFileDownload"].ToString()) ? 1 : 0;

            string SubmitionDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm");

            DateTime sdate = DateTime.ParseExact(ProjectSDate, "MM/dd/yyyy", null);
            string sformatForMySql = sdate.ToString("yyyy-MM-dd");

            DateTime edate = DateTime.ParseExact(ProjectEDate, "MM/dd/yyyy", null);
            DateTime combinedDate = edate.Add(TimeSpan.Parse(ProjectETime));

            string eformatForMySql = combinedDate.ToString("yyyy-MM-dd HH:mm");
            string ProjectNotes = collection["ProjectNotes"].ToString();
            //string chkParallelProject = collection["chkParallelProject"].ToString();
                      
            _AID = AgencyID.Split(',');
            _ANAME = AgencyName.Split(',');
            _AEMAIL = AgencyEmail.Split(',');

            for (int i = 0; i < _AID.Length; i++)
            {
                AID = _AID[i].Trim().ToString();
                AN = _ANAME[i].Trim().ToString();
                AE = _AEMAIL[i].Trim().ToString();

                if (AID != "0")
                {
                    AG = getAgencyID(AID);
                }
                else if (AID == "0")
                {
                    AG = addAgencyNew(AN, AE);
                }

                agID = agID + AG + ",";

                if (AG.Contains("Error:") || AG == "Agency not exist in database.")
                {
                    return AG;
                }
            }

            agID = agID.Remove(agID.Length - 1);

            _res = createBaseProject(ownerid, ProjectName, ProjectOrder, "", Convert.ToInt16(Source), SubmitionDate, eformatForMySql, fileName, "New", sformatForMySql, ProjectTask, ProjectCategory, Destination, allowTransFileDownload, agID, ProjectNotes, chkParallelProject, ProjectPriority);

            _AID = agID.Split(',');

            return user.UserId + "/" + _AID[0] + "/" + _res;
        }
        private string createBaseProject(int OwnerId, string ProjectName, string ProjectOrder, string Description, int LangId, string SubmitionDate, string ExpectedDate, string FilePath, string Status, string StartDate, string ProjectTask, string ProjectCategory, string Destination, int allowTransFileDownload, string Agency_ID, string ProjectNotes, string chkParallelProject, string ProjectPriority)
        {
            string retVal = "0";
            try
            {
                // We dont have to insert values like this, We Should have use stored Procedures or Parameterised Queries-- AKASH.
                string strQry = "INSERT INTO `tbl_project` (`OwnerId`,`ProjectName`,`Description`,`LangId`,`SubmitionDate`,`ExpectedDate`,`FilePath`,`Status`,`StartDate`,`ProjectTask`,`ProjectCategory`, `AllowFileDownload`, `PO`, `ProjectNotes`, `chkParallelProject`, `ProjectPriority`) VALUES (" + OwnerId + ",'" + ProjectName + "','" + Description + "'," + LangId + ",'" + SubmitionDate + "','" + ExpectedDate + "','" + FilePath + "','" + Status + "','" + StartDate + "','" + ProjectTask + "','" + ProjectCategory + "','" + allowTransFileDownload + "', '" + ProjectOrder + "', '" + ProjectNotes + "', '" + chkParallelProject + "', '" + ProjectPriority + "');";
                connection();
                con.Open();

                MySqlCommand com = new MySqlCommand(strQry, con);
                com.ExecuteNonQuery();
                long _uid = com.LastInsertedId;
                string s = Destination;
                string[] values = s.Split(',');
                StringBuilder sCommand = new StringBuilder("Insert into `tbl_projectlangmap` (`ProjectId`,`LangId`) values ");
                List<string> Rows = new List<string>();

                for (int i = 0; i < values.Length; i++)
                {
                    Rows.Add(string.Format("('{0}','{1}')", MySqlHelper.EscapeString(_uid.ToString()), MySqlHelper.EscapeString(values[i])));
                }

                sCommand.Append(string.Join(",", Rows));
                sCommand.Append(";");
                using (MySqlCommand myCmd = new MySqlCommand(sCommand.ToString(), con))
                {
                    myCmd.CommandType = CommandType.Text;
                    myCmd.ExecuteNonQuery();
                }

                string[] splitProjectTask = ProjectTask.Split(',');
                string[] splitAssignAgency = Agency_ID.Split(',');
                sCommand = new StringBuilder("Insert into `tbl_projecttask` (`ProjectID`,`Task`,`TaskID`,`AssignAgency`) values ");
                Rows = new List<string>();

                for (int i = 0; i < splitProjectTask.Length; i++)
                {
                    DataSet ds = new DataSet();
                    string str = "SELECT `SlNo` FROM tbl_customizeprojecttask where ProjectTask_Values = '" + MySqlHelper.EscapeString(splitProjectTask[i]) + "' and userId = " + OwnerId + ";";
                    MySqlDataAdapter da = new MySqlDataAdapter(str, con);
                    da.Fill(ds);
                    string taskID = ds.Tables[0].Rows[0]["SlNo"].ToString();

                    Rows.Add(string.Format("('{0}','{1}','{2}','{3}')", MySqlHelper.EscapeString(_uid.ToString()), MySqlHelper.EscapeString(splitProjectTask[i]), taskID, MySqlHelper.EscapeString(splitAssignAgency[i])));
                }

                sCommand.Append(string.Join(",", Rows));
                sCommand.Append(";");
                using (MySqlCommand myCmd1 = new MySqlCommand(sCommand.ToString(), con))
                {
                    myCmd1.CommandType = CommandType.Text;
                    myCmd1.ExecuteNonQuery(); retVal = _uid.ToString();
                }
            }
            catch (Exception ex)
            {
                string msg = ex.Message.ToString();
                Logger.AddLog("AppViewsController", "createBaseProject", ex.Message);

                retVal = "0";
            }
            finally
            {
                con.Close();
            }
            return retVal;
        }
        private string getAgencyID(string AgencyID)
        {
            try
            {
                IdentityUser user = System.Web.HttpContext.Current.Session.GetDataFromSession<IdentityUser>("User");
                connectionString.connectionOpen();

                string query = "insert into tbl_organizationagencymap (agencyid,organizationid) values (" + Convert.ToInt16(AgencyID) + ",'" + user.UserId + "')";
                MySqlCommand com = new MySqlCommand(query, connectionString.getConnection());
                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Logger.AddLog("AppViewsController", "getAgencyID", ex.Message);
            }

            return AgencyID.ToString();
        }
        public string ProjectSummaryDetails(string pid)
        {
            DataTable dt = new DataTable();
            string qry_ProjectSummary = "select distinct tblProj.ProjectId,tblProj.ProjectName,tblProj.Description,DATE_FORMAT(tblProj.StartDate,'%d-%m-%y') AS StartDate,DATE_FORMAT(tblProj.SubmitionDate,'%d-%m-%y') as SubmitionDate,DATE_FORMAT(tblProj.ExpectedDate,'%d-%m-%y') as ExpectedDate,tblProj.Status,tblProj.PO,tblProj.ProjectTask,tblProj.ProjectCategory,tblProj.ProjectNotes,tblProj.chkParallelProject,tbl_fd.TotalWord,tbl_fd.RepeatedWord,tbl_fd.TMWordCount,tbl_fd.TranslationRequired,tbl_fd.Status,(select LangEnglishName from tbl_langmaster where LangId=tbl_fd.Source_lang) as 'Source_lang',(select LangEnglishName from tbl_langmaster where LangId=tbl_fd.Target_lang) as 'Target_lang',(SELECT SUM(vp.Progress) / COUNT(vp.Progress) progress FROM tbl_filedetails tbl_fd INNER JOIN v_progress vp ON vp.FileId = tbl_fd.Id WHERE tbl_fd.ProjectId = '" + pid + "') as 'Progress' from tbl_Project tblProj,tbl_filedetails tbl_fd,v_progress vp  where tblProj.projectId = tbl_fd.ProjectId and tblProj.projectId = " + pid;
            connection();
            MySqlDataAdapter da = new MySqlDataAdapter(qry_ProjectSummary, con);
            con.Open();
            da.Fill(dt);
            con.Close();
            dt.TableName = "data";
            string ProjectSummary = DataTableToJSONWithJavaScriptSerializer(dt);
            return ProjectSummary;
        }
        public string DataTableToJSONWithJavaScriptSerializer(DataTable table)
        {
            JavaScriptSerializer jsSerializer = new JavaScriptSerializer();

            List<Dictionary<string, object>> parentRow = new List<Dictionary<string, object>>();
            Dictionary<string, object> childRow;
            foreach (DataRow row in table.Rows)
            {
                childRow = new Dictionary<string, object>();
                foreach (DataColumn col in table.Columns)
                {
                    childRow.Add(col.ColumnName, row[col]);
                }
                parentRow.Add(childRow);
            }
            return jsSerializer.Serialize(parentRow);
        }
        private string addAgencyNew(string AgencyName, string AgencyEmail)
        {
            IdentityUser user = System.Web.HttpContext.Current.Session.GetDataFromSession<IdentityUser>("User");
            connectionString.connectionOpen();

            string returnValue = string.Empty;
            string query = string.Empty;
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[8];
            var random = new Random();
            DataSet ds = new DataSet();
            DataSet ds1 = new DataSet();
            int UserID = user.UserId;

            try
            {
                string str = "SELECT `UserId`, `Email` FROM tbl_users;";
                MySqlDataAdapter da = new MySqlDataAdapter(str, connectionString.getConnection());
                da.Fill(ds);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    string email = dr["Email"].ToString();

                    if (email.ToLower() == AgencyEmail.ToLower())
                    {
                        int id = Convert.ToInt32(dr["UserId"].ToString());

                        string str1 = "SELECT `AgencyId` FROM tbl_agencydetails WHERE UserId = '" + id + "';";
                        MySqlDataAdapter da1 = new MySqlDataAdapter(str1, connectionString.getConnection());
                        da1.Fill(ds1);

                        if (ds1.Tables[0].Rows.Count > 0)
                        {
                            int AgencyID = Convert.ToInt32(ds1.Tables[0].Rows[0][0]);

                            string queryNew1 = "INSERT INTO tbl_assignagencytranslator (UserID, AgencyID) VALUES (" + UserID + ", " + AgencyID + ")";
                            MySqlCommand comNew1 = new MySqlCommand(queryNew1, connectionString.getConnection());
                            comNew1.ExecuteNonQuery();

                            return AgencyID.ToString();
                        }
                        else
                        {
                            return "Agency not exist in database.";
                        }
                    }
                }

                for (int i = 0; i < stringChars.Length; i++)
                {
                    stringChars[i] = chars[random.Next(chars.Length)];
                }

                var finalString = new String(stringChars);

                var auser = new ApplicationUser()
                {
                    UserName = AgencyName,
                    Email = AgencyEmail,
                    RoleId = 3,
                    LoginMode = 1
                };

                var result = _manager.CreateAsync(auser, finalString);

                bool isValid = result.Result.Succeeded;

                if (!isValid)
                {
                    return "Error: " + result.Result.Errors.FirstOrDefault();
                }

                var user2 = _manager.FindByEmail(AgencyEmail);

                query = "insert into tbl_agencydetails (AgencyName,EmailId,UserId) values ('" + AgencyName + "','" + AgencyEmail + "','" + user2.UserId + "')";
                MySqlCommand com = new MySqlCommand(query, connectionString.getConnection());
                com.ExecuteNonQuery();
                long _aid = com.LastInsertedId;

                int Agency_ID = Convert.ToInt32(_aid);

                string queryNew = "INSERT INTO tbl_assignagencytranslator (UserID, AgencyID) VALUES (" + UserID + ", " + Agency_ID + ")";
                MySqlCommand comNew = new MySqlCommand(queryNew, connectionString.getConnection());
                comNew.ExecuteNonQuery();

                string query1 = "insert into tbl_organizationagencymap (agencyid,organizationid) values (" + Convert.ToInt16(_aid) + ",'" + user.UserId + "')";
                MySqlCommand com1 = new MySqlCommand(query1, connectionString.getConnection());
                com1.ExecuteNonQuery();

                NotificationHandler nh = new NotificationHandler();
                nh.Invite("byOther", AgencyEmail, user.UserName, "Agency", AgencyName);

                bool _res = false;
                mailsend objMail = new mailsend();
                _res = objMail.mailSend(user2.UserName, user2.Email, "0", null, 0, finalString);

                returnValue = _aid.ToString();
            }
            catch (Exception ex)
            {
                Logger.AddLog("AppViewsController", "addAgencyNew", ex.Message);
            }
            finally
            {
                connectionString.connectionClose();
            }
            return returnValue;
        }

        public string downloadAllFiles(string projectId)
        {
            string flist = GetFiles(Convert.ToInt32(projectId));
            flist = "{\"downloadfiles\":" + flist + "}";
            var result = JsonConvert.DeserializeObject<RootObject>(flist);
            var firstNames = result.downloadfiles.Select(p => new List<string> { p.ChildFileName, p.RelPath }).Distinct();
            string[] values = projectId.Split(',');
            string zipName;

            using (Ionic.Zip.ZipFile zip = new Ionic.Zip.ZipFile())
            {
                string root = Server.MapPath("~");
                string parent = Path.GetDirectoryName(root);
                string grandParent = Path.GetDirectoryName(parent);

                zip.AlternateEncodingUsage = ZipOption.AsNecessary;
                zip.AddDirectoryByName("Files");
                foreach (var fnames in firstNames)
                {
                    if (fnames[1] == "" || string.IsNullOrEmpty(fnames[1]))
                    {
                        var filePath = grandParent + uploadkey + projectId + "\\" + fnames[0];
                        zip.AddFile(filePath, "Files");
                    }
                    else
                    {
                        string rRelPath = fnames[1].Replace("/" + projectId + "/", "");

                        zip.AddDirectoryByName(rRelPath);

                        string fname = fnames[1].Substring(1, fnames[1].Length - 1);
                        fname = fname.Replace("/", "\\\\");
                        fname = fname + "\\\\" + fnames[0];

                        var filePath = grandParent + uploadkey + fname;

                        zip.AddFile(filePath, rRelPath);
                    }
                }
                Response.Clear();
                Response.BufferOutput = false;
                zipName = String.Format("Prudle_AllFiles_{0}.zip", DateTime.Now.ToString("yyyy-MMM-dd-HHmmss"));
                Response.ContentType = "application/zip";
                Response.AddHeader("content-disposition", "attachment; filename=" + zipName);
                zip.Save(Response.OutputStream);
            }

            return "";
        }
        public string GetSingleFileDetails(int fid)
        {
            string str1;
            try
            {
                IdentityUser user = System.Web.HttpContext.Current.Session.GetDataFromSession<IdentityUser>("User");
                DataTable dt = new DataTable();

                string retTable = string.Empty;
                string getStr1 = "Select  CONCAT_WS('', ChildFileName, FileType) as 'ChildFileName' from tbl_filedetails where Id = " + fid + ";";
                connectionString.connectionOpen();
                MySqlDataAdapter da = new MySqlDataAdapter(getStr1, connectionString.getConnection());

                da.Fill(dt);
                connectionString.connectionClose();
                dt.TableName = "data";
                str1 = DataTableToJSONWithJavaScriptSerializerDT(dt);
            }
            catch (Exception ex)
            {
                str1 = ex.Message;
            }
            return str1;
        }
        public FileResult downloadSingleFile(string fid, string pid = "", string fileName = "")
        {
            string relFilePath = string.IsNullOrEmpty(fileName) ? GetRelativeFilePath(fid) : fileName;

            string fileRepoPath = Server.MapPath("~/appviews/Doc");
            string targetDirPath = Path.Combine(fileRepoPath, pid);

            string filePath = Path.Combine(targetDirPath, relFilePath);

            byte[] fileBytes = System.IO.File.ReadAllBytes(filePath);
            return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, Path.GetFileName(filePath));
        }
        public FileResult downloadSingleFile1(string pid, string langId)
        {
            string relFilePath = string.IsNullOrEmpty(fileName) ? GetRelativeFilePathByPidAndLangId(pid, langId) : fileName;

            string fileRepoPath = Server.MapPath("~/appviews/Doc");
            string targetDirPath = Path.Combine(fileRepoPath, pid);

            string filePath = Path.Combine(targetDirPath, relFilePath);

            byte[] fileBytes = System.IO.File.ReadAllBytes(filePath);
            return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, Path.GetFileName(filePath));
        }
        private string GetRelativeFilePath(string fid)
        {
            string errorMsg = string.Empty;
            try
            {
                connectionString.connectionOpen();


                string strQry = "Select  CONCAT_WS('', ChildFileName, FileType) as 'ChildFileName' from tbl_filedetails where Id = " + fid + ";";

                MySqlCommand cmd = new MySqlCommand(strQry, connectionString.getConnection());
                cmd.Parameters.Add("?Parname", MySqlDbType.Int16).Value = Convert.ToInt16(fid); // Are you sure that the ID is Int? That's the first time I see anything like that!

                string ChildFileName = ((String)cmd.ExecuteScalar());

                return ChildFileName;
            }
            catch (Exception ex)
            {
                errorMsg = ex.Message;
            }
            finally
            {
                connectionString.connectionClose();
            }

            return errorMsg;
        }
        public string getProjectTaskForAgency(string PID)
        {
            DataTable dt = new DataTable();

            try
            {
                connectionString.connectionOpen();

                string commandText = "SELECT Task, taskID,AssignTo FROM tbl_projecttask WHERE ProjectID = '" + PID
                                + "' and AssignAgency = (Select AgencyId from tbl_agencydetails where UserId = " + loginUser.getUserID() + ")";
                MySqlDataAdapter da = new MySqlDataAdapter(commandText, connectionString.getConnection());
                da.Fill(dt);

                connectionString.connectionClose();
            }
            catch (Exception ex)
            {
                Logger.AddLog("AppViewsController", "getProjectTask", ex.Message);
            }

            return DataTableToJSONWithJavaScriptSerializerDT(dt);
        }
        private string GetRelativeFilePathByPidAndLangId(string pid, string langid)
        {
            string ChildFileName = string.Empty;

            try
            {
                connectionString.connectionOpen();

                string strQry = string.Empty;

                if (string.IsNullOrEmpty(langid))
                    strQry = "SELECT CONCAT_WS('', ChildFileName, FileType) as 'ChildFileName' FROM tbl_filedetails WHERE ProjectId = " + pid + ";";
                else
                    strQry = "SELECT CONCAT_WS('', ChildFileName, FileType) as 'ChildFileName' FROM tbl_filedetails WHERE ProjectId = " + pid + " AND Target_lang = " + langid + ";";

                MySqlCommand cmd = new MySqlCommand(strQry, connectionString.getConnection());

                ChildFileName = ((String)cmd.ExecuteScalar());

                connectionString.connectionClose();
            }
            catch (Exception ex)
            {
                Logger.AddLog("AppViewsController", "GetRelativeFilePathByPidAndLangId", ex.Message);
            }

            return ChildFileName;
        }

        public string downloadsamelangfile(string pid, string langId)
        {
            string zipName = string.Empty;

            try
            {
                string flist = GetLangFiles(Convert.ToInt32(pid), Convert.ToInt32(langId));
                flist = "{\"downloadfiles\":" + flist + "}";
                var result = JsonConvert.DeserializeObject<RootObject>(flist);

                var firstNames = result.downloadfiles.Select(p => p.ChildFileName).Distinct();

                string[] values = pid.Split(',');

                using (Ionic.Zip.ZipFile zip = new Ionic.Zip.ZipFile())
                {
                    string root = Server.MapPath("~");
                    string parent = Path.GetDirectoryName(root);
                    string grandParent = Path.GetDirectoryName(parent);
                    zip.AlternateEncodingUsage = ZipOption.AsNecessary;
                    zip.AddDirectoryByName("Files");
                    foreach (var fnames in firstNames)
                    {
                        var filePath = grandParent + uploadkey + fnames;
                        zip.AddFile(filePath, "Files");
                    }
                    Response.Clear();
                    Response.BufferOutput = false;
                    zipName = String.Format("PrudleStudio{0}.zip", DateTime.Now.ToString("yyyy-MMM-dd-HHmmss"));
                    Response.ContentType = "application/zip";
                    Response.AddHeader("content-disposition", "attachment; filename=" + zipName);
                    zip.Save(Response.OutputStream);
                }
            }
            catch (Exception ex)
            {
                Logger.AddLog("AppViewsController", "downloadsamelangfile", ex.Message);
            }

            return zipName;
        }

        public string GetLangFiles(int pid, int lid)
        {
            DataTable dt = new DataTable();

            try
            {
                connectionString.connectionOpen();

                string getStr = "SELECT f.ProjectId, f.TotalWord, f.RepeatedWord, f.TMWordCount, f.TranslationRequired, CONCAT_WS('', f.ChildFileName, f.FileType) as 'ChildFileName', f.Status, WP.Progress, f.Id as fileID, f.Target_lang as TargetLanguageID FROM tbl_filedetails f, tbl_project p, v_Progress WP WHERE p.ProjectId = f.ProjectId AND f.ProjectId = " + pid + " AND f.Id = WP.FileId AND f.Target_lang=" + lid + ";";
                MySqlDataAdapter da = new MySqlDataAdapter(getStr, connectionString.getConnection());
                da.Fill(dt);
                dt.TableName = "data";

                connectionString.connectionClose();
            }
            catch (Exception ex)
            {
                Logger.AddLog("AppViewsController", "GetLangFiles", ex.Message);
            }

            return DataTableToJSONWithJavaScriptSerializerDT(dt);
        }

        public string getallprojects(string pname)
        {
            DataTable dt = new DataTable();

            try
            {
                connectionString.connectionOpen();

                string commandText = "SELECT ProjectName FROM tbl_project WHERE OwnerId = " + loginUser.getUserID() + " AND ProjectName = '" + pname + "'";
                MySqlDataAdapter da = new MySqlDataAdapter(commandText, connectionString.getConnection());
                da.Fill(dt);

                connectionString.connectionClose();
            }
            catch (Exception ex)
            {
                Logger.AddLog("AppViewsController", "getallprojects", ex.Message);
            }

            return dt.Rows.Count.ToString();
        }

        public string OrgNotification(FormCollection collection)
        {
            NotificationHandler nh = new NotificationHandler();
            try
            {
                nh.CreateOrgNotification("assigned", collection, loginUser.userDetail().UserName);
            }
            catch (Exception ex)
            {
                Logger.AddLog("AppViewsController", "OrgNotification", ex.Message);
            }
            return "";
        }

        public string getProjectTask(string PID)
        {
            DataTable dt = new DataTable();

            try
            {
                connectionString.connectionOpen();

                string commandText = "SELECT Task, AssignTo FROM tbl_projecttask WHERE ProjectID = '" + PID + "'";
                MySqlDataAdapter da = new MySqlDataAdapter(commandText, connectionString.getConnection());
                da.Fill(dt);

                connectionString.connectionClose();
            }
            catch (Exception ex)
            {
                Logger.AddLog("AppViewsController", "getProjectTask", ex.Message);
            }

            return DataTableToJSONWithJavaScriptSerializerDT(dt);
        }

        public string getAssignToName(string AssingTo)
        {
            DataTable dt = new DataTable();

            try
            {
                connectionString.connectionOpen();

                string getStr = "SELECT TransltrName FROM tbl_translatordetails WHERE TransltrId = " + AssingTo + ";";
                MySqlDataAdapter da = new MySqlDataAdapter(getStr, connectionString.getConnection());
                da.Fill(dt);

                connectionString.connectionClose();
            }
            catch (Exception ex)
            {
                Logger.AddLog("AppViewsController", "getAssignToName", ex.Message);
            }

            return dt.Rows[0][0].ToString();
        }

        //using Entity Framework, inserting the Values.
        public string saveNewTask(string taskName, string tasktype, string tasktypeId)
        {
            IdentityUser user = System.Web.HttpContext.Current.Session.GetDataFromSession<IdentityUser>("User");
            try
            {

                //Checking for Unique Values using Entity Framework
                string userId = Convert.ToString(user.UserId);
                var existingValueCount = Configtask.tbl_customizeprojecttask.Where(x => x.ProjectTask_Name == taskName && (x.userId == userId || x.userId == "0")).Count();
                if ((existingValueCount > 0))
                {
                    return "This Task is Already Exist.";
                }
                else
                {
                    //Inserting the Values to the Database using EntityFramework.
                    tbl_customizeprojecttask tbl_ConfigTask = new EntityModel.tbl_customizeprojecttask()
                    {
                        userId = Convert.ToString(user.UserId),
                        ProjectTask_Name = taskName,
                        ProjectTask_Values = taskName,
                        TaskType = tasktype,
                        TaskTypeId = tasktypeId
                    };
                    Configtask.tbl_customizeprojecttask.Add(tbl_ConfigTask);
                    Configtask.SaveChanges();
                    return "Task has been added successfully.";
                }
            }
            catch (Exception ex)
            {
                string exception = ex.Message.ToString();
                return "Some Error occured.";
            }
        }

        [HttpGet]
        [AllowAnonymous]
        public ActionResult AddConfigureTask()
        {
            //Return the Values from DB to VIEW for Populate the table report using Entity Framework.
            IdentityUser user = System.Web.HttpContext.Current.Session.GetDataFromSession<IdentityUser>("User");
            string userId = user.UserId.ToString();
            var objData = Configtask.tbl_customizeprojecttask.Where(x => x.userId == "0" || x.userId == userId).ToList();
            var objgetTaskNames = Configtask.tbl_taskmaster.ToList();
            ViewBag.taskmaster = objgetTaskNames;
            return View(objData);
        }

        //Fill the Dropdown dynamically in PROJECT UPLOAD Page using ADO.net.
        public DataSet getConfigureTaskNames(IdentityUser user)
        {
            DataSet ds = new DataSet();
            try
            {
                connection();
                con.Open();

                string commandText = "select ProjectTask_Name,ProjectTask_Values from tbl_customizeprojecttask where `userId`=" + user.UserId + " or `userId`= " + 0 + "";
                MySqlDataAdapter da = new MySqlDataAdapter(commandText, con);
                da.Fill(ds);
            }
            catch
            {

            }
            finally
            {
                con.Close();
            }
            return ds;
        }

        //Delete the Configure Task, using Entity Framework.
        public ActionResult DeleteConfigureTaskName(long id = 0)
        {
            var objDeleteData = Configtask.tbl_customizeprojecttask.Where(x => x.SlNo == id).FirstOrDefault();
            if (objDeleteData != null)
            {
                Configtask.tbl_customizeprojecttask.Remove(objDeleteData);
                Configtask.SaveChanges();
            }
            else
            {

            }
            return RedirectToAction("AddConfigureTask");
        }
        //-----------------------------------

        public ActionResult OrgDefineUserRoles()
        {
            string strRoles = "";
            IdentityUser user = System.Web.HttpContext.Current.Session.GetDataFromSession<IdentityUser>("User");
            string userId = user.UserId.ToString();
            string userEmailId = user.Email.ToString();
            //Return the Roles Names / Assign Role to user.
            var objgetRoles = Configtask.tbl_organizationdefinedroles.Where(x => x.OrganizationUserId == userId).ToList();
            ViewBag.RoleNames = objgetRoles;
            if (objgetRoles != null && objgetRoles.Count() != 0)
            {
                foreach (var item in objgetRoles)
                {
                    strRoles = item.RoleId + "," + strRoles;
                }
                strRoles = strRoles.Remove(strRoles.Length - 1);
            }

            //Return the Permission Master values to the View from DB, Dropdown.
            var objgetPermission = Configtask.tbl_permissionmaster.ToList();
            ViewBag.PermissionNames = objgetPermission;

            //Return the ROLE Name to the View from DB for, Table Report Define Role Page.
            var obj_OrganizationDefinedRoles = Configtask.tbl_organizationdefinedroles.ToList();
            ViewBag.OrganizationDefinedRoles = obj_OrganizationDefinedRoles;

            DataSet ds = new DataSet();
            connectionString.connectionOpen();
            string str = "SELECT r.* FROM tbl_rolesassigntouser r INNER JOIN tbl_users u ON u.Email = r.UserId WHERE u.UserId = '" + loginUser.getUserID() + "' OR u.CreatorUserId = '" + loginUser.getUserID() + "';";
            MySqlDataAdapter da = new MySqlDataAdapter(str, connectionString.getConnection());
            da.Fill(ds);
            connectionString.connectionClose();

            var myData = ds.Tables[0].AsEnumerable().Select(r => new
            {
                SlNo = r.Field<int>("SlNo"),
                UserId = r.Field<string>("UserId"),
                RoleId = r.Field<string>("RoleId"),
                Description = r.Field<string>("Description"),
                RoleNames = r.Field<string>("RoleNames")
            });
            var list = myData.Select(x => new tbl_rolesassigntouser
            {
                SlNo = x.SlNo,
                UserId = x.UserId,
                RoleId = x.RoleId,
                Description = x.Description,
                RoleNames = x.RoleNames,
            }).ToList();

            return View(list);
        }

        // Add New Users
        public string AddUser(string EmailID)
        {
            string returnValue = "";
            string query = "";
            string username = "";
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[8];
            var random = new Random();
            DataSet ds = new DataSet();
            DataSet ds1 = new DataSet();
            try
            {
                int UserID = loginUser.getUserID();
                int roleID = loginUser.getRoleID();

                connectionString.connectionOpen();
                string str = "SELECT * FROM tbl_users WHERE Email = '" + EmailID + "';";
                MySqlDataAdapter da = new MySqlDataAdapter(str, connectionString.getConnection());
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    return "Excist";
                }
                for (int i = 0; i < stringChars.Length; i++)
                {
                    stringChars[i] = chars[random.Next(chars.Length)];
                }
                var finalString = new String(stringChars);
                username = EmailID.Split('@')[0];
                var auser = new ApplicationUser()
                {
                    UserName = username,
                    Email = EmailID,
                    RoleId = roleID,
                    LoginMode = 1
                    //CreatorUserId = user.UserId
                };
                var result = _manager.CreateAsync(auser, finalString);
                bool isValid = result.Result.Succeeded;
                if (!isValid)
                {
                    return "Error: " + result.Result.Errors.FirstOrDefault();
                }
                string queryUpdateCreatorId = "Update tbl_users set CreatorUserId = '" + UserID + "' where Email='" + EmailID + "';";
                MySqlCommand comNewqueryUpdateCreatorId = new MySqlCommand(queryUpdateCreatorId, connectionString.getConnection());
                comNewqueryUpdateCreatorId.ExecuteNonQuery();

                var user2 = _manager.FindByEmail(EmailID); //Fetch User Details which are Inserted to the Database.

                //Send Email after create a New User.
                #region
                bool _res = false;
                mailsend objMail = new mailsend();
                _res = objMail.mailSend(user2.UserName, user2.Email, "0", null, 0, finalString);
                #endregion

                #region
                //For Agency Type of Users
                if (roleID == 3)
                {
                    //var user2 = _manager.FindByEmail(EmailID);
                    query = "insert into tbl_agencydetails (AgencyName,EmailId,UserId) values ('" + username + "','" + EmailID + "','" + user2.UserId + "')";
                    MySqlCommand com = new MySqlCommand(query, connectionString.getConnection());
                    com.ExecuteNonQuery();
                    long _aid = com.LastInsertedId;

                    int Agency_ID = Convert.ToInt32(_aid);

                    string queryNew = "INSERT INTO tbl_assignagencytranslator (UserID, AgencyID) VALUES (" + UserID + ", " + Agency_ID + ")";
                    MySqlCommand comNew = new MySqlCommand(queryNew, connectionString.getConnection());
                    comNew.ExecuteNonQuery();

                    string query1 = "insert into tbl_organizationagencymap (agencyid,organizationid) values (" + Convert.ToInt16(_aid) + ",'" + UserID + "')";
                    MySqlCommand com1 = new MySqlCommand(query1, connectionString.getConnection());
                    com1.ExecuteNonQuery();

                    connectionString.connectionClose();

                    NotificationHandler nh = new NotificationHandler();
                    nh.Invite("byOther", EmailID, loginUser.userDetail().UserName, "Agency", username);

                    //bool _res = false;
                    //mailsend objMail = new mailsend();
                    //_res = objMail.mailSend(user2.UserName, user2.Email, "0", null, 0, finalString);

                    returnValue = _aid.ToString();
                }
                #endregion
            }
            catch (Exception ex)
            {
                string exception = ex.Message.ToString();
                Logger.AddLog("AppViewsController", "addAgencyNew", ex.Message);
            }
            finally
            {
                connectionString.connectionClose();
            }
            return returnValue;
        }
        //END


        //Save User Email Ids to the DB with Specific Role.
        public string saveUserRoles(string userEmailID, string userAssignedRoles, string userDescritption, string userRoles)
        {
            string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (Regex.IsMatch(userEmailID, pattern))
            {
                try
                {
                    //Checking for Unique Values using Entity Framework
                    IdentityUser user = System.Web.HttpContext.Current.Session.GetDataFromSession<IdentityUser>("User");
                    string userId = Convert.ToString(user.UserId);

                    //var existingValueCount = Configtask.tbl_rolesassigntouser.Where(x => x.UserId == userEmailID && x.RoleId == userAssignedRoles).Count();
                    var existingValueCount = Configtask.tbl_rolesassigntouser.Where(x => x.UserId == userEmailID).Count();
                    if ((existingValueCount > 0))
                    {
                        return "Roles are already added for this User.";
                    }
                    else
                    {
                        //Add New Users if they are not Registered to the Database.
                        AddUser(userEmailID);
                        tbl_rolesassigntouser roleAssignToUser = new EntityModel.tbl_rolesassigntouser()
                        {
                            UserId = userEmailID,
                            RoleId = userAssignedRoles,
                            Description = userDescritption,
                            RoleNames = userRoles
                        };
                        Configtask.tbl_rolesassigntouser.Add(roleAssignToUser);
                        Configtask.SaveChanges();
                        return "Task has been added successfully.";
                    }
                }
                catch (Exception ex)
                {
                    string exception = ex.Message.ToString();
                    return "Some Error occured.";
                }
            }
            else
                return "Invalid Email Id.";
        }

        //Delete the Assign Roles, using Entity Framework.
        public ActionResult DeleteAssignRoles(long id = 0)
        {
            var objDeleteData = Configtask.tbl_rolesassigntouser.Where(x => x.SlNo == id).FirstOrDefault();
            if (objDeleteData != null)
            {
                Configtask.tbl_rolesassigntouser.Remove(objDeleteData);
                Configtask.SaveChanges();
            }
            else
            {

            }
            return RedirectToAction("OrgDefineUserRoles");
        }

        //Edit the Assign Roles, using Entity Framework.
        public JsonResult FetchAssignRoles(long id)
        {
            var objEditData = Configtask.tbl_rolesassigntouser.Where(x => x.SlNo == id).FirstOrDefault();
            return Json(objEditData, JsonRequestBehavior.AllowGet);
        }

        //Edit the Define Roles, using Entity Framework.
        public JsonResult FetchDefineRoles(long id)
        {
            var objEditDefineRoleData = Configtask.tbl_organizationdefinedroles.Where(x => x.RoleId == id).FirstOrDefault();
            return Json(objEditDefineRoleData, JsonRequestBehavior.AllowGet);
        }

        //Edit / Update the Assign Roles, using Entity Framework.
        public string EditAssignRoles(long id, string userEmailID, string userAssignedRoles, string userDescritption, string userRoles)
        {
            try
            {
                //Return the ROLE Name to the View from DB for, Table Report Define Role Page.
                //var objDefinedRoles = Configtask.tbl_rolesassigntouser.Where(x => x.UserId == userEmailID).ToList();
                //ViewBag.objDefinedRoles = objDefinedRoles;

                tbl_rolesassigntouser ObjRoleAssignToUser = (from x in Configtask.tbl_rolesassigntouser where x.SlNo == id select x).First();
                ObjRoleAssignToUser.UserId = userEmailID;
                ObjRoleAssignToUser.RoleId = userAssignedRoles;
                ObjRoleAssignToUser.Description = userDescritption;
                ObjRoleAssignToUser.RoleNames = userRoles;
                Configtask.SaveChanges();
                return "Task has been added successfully.";
            }
            catch (Exception ex)
            {
                string exception = ex.Message.ToString();
            }
            return "Not Added";
        }

        public string saveRoleswithPermission(string roleName, string PermissonIds, string RoleDescription, string PermissionNames)
        {
            string operationFlag = "Not_Done"; //Operational Flag, for checking that First Insertion is done or not.

            //Checking for Unique Values using Entity Framework
            IdentityUser user = System.Web.HttpContext.Current.Session.GetDataFromSession<IdentityUser>("User");
            string userId = Convert.ToString(user.UserId);

            var existingValueCount = Configtask.tbl_organizationdefinedroles.Where(x => x.OrganizationUserId == userId && x.RoleName == roleName).Count();
            if ((existingValueCount > 0))
            {
                return "Roles are already added for this User.";
            }
            else
            {
                try
                {
                    //Save Defined roles to the organization defined roles.
                    tbl_organizationdefinedroles obj_OrganizationDefinedRoles = new EntityModel.tbl_organizationdefinedroles()
                    {
                        RoleName = roleName,
                        RoleDescription = RoleDescription,
                        OrganizationUserId = userId,
                        CreatedDate = System.DateTime.Now.ToString(),
                        PermissionIds = PermissonIds
                    };
                    Configtask.tbl_organizationdefinedroles.Add(obj_OrganizationDefinedRoles);
                    Configtask.SaveChanges();
                    operationFlag = "Done";

                    //Put Role ID and Permission ID that which Role will able to do what functions.
                    if (operationFlag == "Done")
                    {
                        tbl_organizationassignedroles Obj_OrganizationAssignedRoles = new EntityModel.tbl_organizationassignedroles()
                        {
                            RoleId = roleName,
                            PermissionId = PermissonIds,
                            Description = RoleDescription
                        };
                        Configtask.tbl_organizationassignedroles.Add(Obj_OrganizationAssignedRoles);
                        Configtask.SaveChanges();
                        return "Task has been added successfully.";
                    }
                    else
                        return "Some Error occured.";
                }
                catch (Exception ex)
                {
                    string exception = ex.Message.ToString();
                    return "Some Error occured.";
                }
            }
        }

        //Delete the Assign Roles, using Entity Framework.
        public ActionResult DeleteRolesWithPermission(long id = 0)
        {
            var objDeleteData = Configtask.tbl_organizationdefinedroles.Where(x => x.RoleId == id).FirstOrDefault();
            if (objDeleteData != null)
            {
                Configtask.tbl_organizationdefinedroles.Remove(objDeleteData);
                Configtask.SaveChanges();
            }
            else
            {

            }
            return RedirectToAction("OrgDefineUserRoles");
        }

        //Edit the Assign Roles, using Entity Framework.
        public string UpdateDefinedRoles(long id, string roleName, string PermissonIds, string RoleDescription)
        {
            try
            {
                IdentityUser user = System.Web.HttpContext.Current.Session.GetDataFromSession<IdentityUser>("User");
                string userId = Convert.ToString(user.UserId);

                tbl_organizationdefinedroles ObjOrganizationdefinedroles = (from x in Configtask.tbl_organizationdefinedroles where x.RoleId == id select x).First();
                ObjOrganizationdefinedroles.RoleName = roleName;
                ObjOrganizationdefinedroles.RoleDescription = RoleDescription;
                ObjOrganizationdefinedroles.PermissionIds = PermissonIds;
                ObjOrganizationdefinedroles.OrganizationUserId = userId;
                Configtask.SaveChanges();
                return "updated successfully.";
            }
            catch (Exception ex)
            {
                string exception = ex.Message.ToString();
            }
            return "not updated";
        }

        //Configure Cost Module
        [HttpGet]
        [AllowAnonymous]
        public ActionResult AddConfigureCost()
        {
            //Fetch all the Cost Unit From Database.
            var objgetCostUnits = Configtask.tbl_costunitmaster.ToList();
            ViewBag.CostUnits = objgetCostUnits;

            var objcostmaster = Configtask.tbl_costmaster.ToList();
            return View(objcostmaster);
        }

        public class downloadfile
        {
            public string ProjectId { get; set; }
            public string TotalWord { get; set; }
            public string RepeatedWord { get; set; }
            public string TMWordCount { get; set; }
            public string TranslationRequired { get; set; }
            public string ChildFileName { get; set; }
            public string Status { get; set; }
            public string Progress { get; set; }
            public string fileID { get; set; }

            public string RelPath { get; set; }
        }

        public class RootObject
        {
            public List<downloadfile> downloadfiles { get; set; }
        }
    }
}
