@Autowired
icimsMessageService.sendAsync(msg);
jgen.writeStringField("kind", fieldSchema.getKind().getDisplayValue());
jgen.writeArrayFieldStart("values");
jgen.writeStringField("key", value.getMapKey());
jgen.writeStringField("value", value.getMapValue());
EMAIL(5, "EMAILS"),
NUMBER(6, "NUMBER"),
DECIMAL(7, "DECIMAL"),
CURRENCY(8, "CURRENCY"),
SALARY(9, "SALARY"),
TAG(18, "TAG"),
"JOB(2, ""JOB""),				/* jobs ? */"
"PERSON(3, ""PERSON"");		/* people ? */"
EMAIL(5, "EMAIL"),
NUMBER(6, "NUMBER"),
DECIMAL(7, "DECIMAL"),
CURRENCY(8, "CURRENCY"),
SALARY(9, "SALARY"),
TAG(18, "TAG"),
.replaceQueryParam("version", featureFlagService.stringValueOf(LinkedInRSCFeatureFlags.LINKEDIN_INMAIL_VIEWER_VERSION))
[Errno 2] No such file or directory: u'/Volumes/common/sourcecode/irecruiter/Web/src/com/icims/offerletter/ws/OfferDataBindingService.java'
[Errno 2] No such file or directory: u'/Volumes/common/sourcecode/irecruiter/Web/src/com/icims/offerletter/ws/OfferDataBindingService.java'
[Errno 2] No such file or directory: u'/Volumes/common/sourcecode/irecruiter/Web/src/com/icims/offerletter/ws/OfferDataBindingService.java'
[Errno 2] No such file or directory: u'/Volumes/common/sourcecode/irecruiter/Web/src/com/icims/offerletter/ws/OfferDataBindingService.java'
[Errno 2] No such file or directory: u'/Volumes/common/sourcecode/irecruiter/Web/src/com/icims/offerletter/ws/OfferDataBindingService.java'
protected static final String PRIVATE = "private";
protected static final String SITE_NAME = "siteName";
}

return getSuccessReturn("created", jsonAdapter.convertFromObject(offer));
content = "Title";
content = "Option";
content = "Resume";
return getSuccessReturn("read", jsonAdapter.convertFromObject(offer));
return getSuccessReturn("deleted", offerJson);
return getSuccessReturn("updated", jsonAdapter.convertFromObject(offer));
return getSuccessReturn("read", jsonAdapter.convertFromObject(lastStatus));
return getSuccessReturn("extended", jsonAdapter.convertFromObject(status));
return getSuccessReturn("acknowledged", jsonAdapter.convertFromObject(status));
return getSuccessReturn("resent to candidate");
throw new SumoException("Query is taking longer than expected. Please reduce the complexity of your query");
private static final String COMPANY = "Company";
private static final String EXPAND = "expand";
private static final String FIELD = "field";
private static final String PERSON = "Person";
private static final String PREVIEW = "preview";
private static final String REFRESH = "refresh";
private static final String SHARED = "shared";
private static final String TITLE = "title";
jsArray.put(new JSONObject().put(ID, node.getId().toString()).put("value", getExtendedNodeValue(node)));
StringUtils.isNotBlank(request.getParameter(INSTRUCTIONAL_MSG)) && StringUtils.isNotEmpty(onlyShowInstructionMessage) && ("true".equals(onlyShowInstructionMessage) || "on".equals(onlyShowInstructionMessage)));
StringUtils.isNotBlank(request.getParameter(INSTRUCTIONAL_MSG)) && StringUtils.isNotEmpty(onlyShowInstructionMessage) && ("true".equals(onlyShowInstructionMessage) || "on".equals(onlyShowInstructionMessage)));
pb.setProfileImage("search");
query = GeneralUtil.setQueryStringValue(query, "module", null);
query = GeneralUtil.setQueryStringValue(query, "action", null);
query = GeneralUtil.setQueryStringValue(query, "hashed", null);
query = GeneralUtil.setQueryStringValue(query, "slot", resultsBean.getSlot());
} else if (!table.startsWith("Profile")) {
List<GroupListNode> keywordSearchNodes = GroupListSearch.findByAttribute(filterParentNode, ListAttributeDefinition.SEARCH_VISUALIZATION_NODE_TYPE, "keyword", (int)CurrentUserService.getUserId(), true);
if (isSearchBrowser && !StringUtils.contains(sections.get(s).getValue(), "Page")) continue;
boolean backAction = "Back".equals(actionId);
return "Date";
return "Icon";
return "Rating";
if (key.charAt(0) == SavedSearch.PREFIX_CRITERIA && key.indexOf("_Rank_") == -1 && key.indexOf("Keywords") == -1) {
if (replay == null && columnSizes == null) return "failure";
serializer.setOutputProperty(OutputKeys.INDENT, "yes");
chd.endElement("", "", "Row");
chd.endElement("", "", "File");
atr.addAttribute("", "", "Name", "CDATA", head[i]);
chd.endElement("", "", "Column");
DateTimeFormatter parser = DateTimeFormat.forPattern("MM/dd/yy hh:mm a");
NotesTabPageBean.NoteBox jobNoteBox = createNoteBox(jobNoteBoxName, "notes", COMPANY_NOTEBOX,
NotesTabPageBean.NoteBox jobNoteBox = createNoteBox(jobNoteBoxName, "notes", JOB_NOTEBOX,
NotesTabPageBean.NoteBox otherBox = createNoteBox(otherBoxName, "tags", otherboxId, getHashedUrl(otherboxRefreshUrl), getHashedUrl(otherboxSearchFrameUrl), otherBoxPersonNoteSearchFrameUrl);
NotesTabPageBean.NoteBox appointmentBox = createNoteBox(appointmentBoxName, "calendar", appointmentId, getHashedUrl(appointmentRefreshUrl), getHashedUrl(appointmentSearchFrameUrl), appointmentBoxPersonNoteSearchFrameUrl);
NotesTabPageBean.NoteBox memoBox = createNoteBox(memoBoxName, "notes", memoboxId, getHashedUrl(memoboxRefreshUrl), getHashedUrl(memoboxSearchFrameUrl), memoboxPersonNoteSearchFrameUrl);
NotesTabPageBean.NoteBox profileSharedBox = createNoteBox(profileSharedBoxName, "share", sharedboxId, getHashedUrl(sharedboxRefreshUrl), getHashedUrl(sharedboxSearchFrameUrl), profileSharedPersonNoteSearchFrameUrl);
NotesTabPageBean.NoteBox inMailNoteBox = createNoteBox(inMailBoxName, "social social-linked-in linkedin-inmail-viewer", inMailId, getHashedUrl(inMailRefreshUrl), getHashedUrl(inMailSpaUrl), null);
truncZip = "AD" + zip.replaceAll("[^\\d]", "");
throw new ProviderException("Malformed JSON response from Provider", e);
if (StringUtils.isNotBlank(county) && "USA".equals(countryAbv3)) {
throw new ProviderException("Malformed JSON response from Provider", e);
return StringUtils.containsIgnoreCase(e.getMessage(), "At least one valid recipient is required");
INDEED_USER("icims.indeed.api.user", "Indeed", false, "2lpBK2wJ2XKkO7yUAgjpIJlUZD244wQnJgUxhe83"), //
PERSON("person", ProfileDefinition.PERSON, "Person", ProfileDefinition.PERSON_TYPE, false), //
PERSON("person", ProfileDefinition.PERSON, "Person", ProfileDefinition.PERSON_TYPE, false), //
JOB("job", ProfileDefinition.JOB, "Job", ProfileDefinition.JOB_TYPE, false), //
JOB("job", ProfileDefinition.JOB, "Job", ProfileDefinition.JOB_TYPE, false), //
COMPANY("company", ProfileDefinition.COMPANY, "Company", ProfileDefinition.COMPANY_TYPE, true), //
COMPANY("company", ProfileDefinition.COMPANY, "Company", ProfileDefinition.COMPANY_TYPE, true), //
PERFORMANCE("performance", ProfileDefinition.PERFORMANCE, "Performance", ProfileDefinition.PERFORMANCE_TYPE, true), //
PERFORMANCE("performance", ProfileDefinition.PERFORMANCE, "Performance", ProfileDefinition.PERFORMANCE_TYPE, true), //
PERFORMANCE_WORKFLOW("performanceworkflow", ProfileDefinition.PERFORMANCE_WORKFLOW, "Performance Workflow", ProfileDefinition.PERFORMANCEWORKFLOW_TYPE, true), //
SOURCE("source", ProfileDefinition.SOURCE, "Source", ProfileDefinition.SOURCE_TYPE, true), //
SOURCE("source", ProfileDefinition.SOURCE, "Source", ProfileDefinition.SOURCE_TYPE, true), //
SOURCE_WORKFLOW("sourceworkflow", ProfileDefinition.SOURCE_WORKFLOW, "Source Workflow", ProfileDefinition.SOURCEWORKFLOW_TYPE, true), //
ROOM("room", ProfileDefinition.ROOM, "Room", ProfileDefinition.ROOM_TYPE, true), //
ROOM("room", ProfileDefinition.ROOM, "Room", ProfileDefinition.ROOM_TYPE, true), //
EVENT("connectevent", ProfileDefinition.EVENT, "Event", ProfileDefinition.EVENT_TYPE, true), //
EVENT_WORKFLOW("connecteventworkflow", ProfileDefinition.EVENT_WORKFLOW, "Event Workflow", ProfileDefinition.EVENT_WORKFLOW_TYPE, true), //
EVENT_WORKFLOW_SOURCE("connecteventworkflowsource", ProfileDefinition.EVENT_WORKFLOW_SOURCE, "Event Workflow Source", ProfileDefinition.EVENT_WORKFLOW_SOURCE_TYPE, true), //
return ProfileDefinitionImpl.SEARCH_API_NAMES.getOrDefault(dbTypeId, "UNKNOWN");
return FlagTableUtils.lookupFlagtableLabel(fieldFlagsGroupName, "Profile");
protected static final String PHONES_COLLECTION_FIELD_NAME = "phones";
protected static final String ADDRESSES_COLLECTION_FIELD_NAME = "addresses";
[Errno 2] No such file or directory: u'/Volumes/common/sourcecode/irecruiter/Web/src/com/icims/jobapplications/ws/IndeedApplyPayloadValidator.java'
[Errno 2] No such file or directory: u'/Volumes/common/sourcecode/irecruiter/Web/src/com/icims/jobapplications/ws/IndeedApplyPayloadValidator.java'
[Errno 2] No such file or directory: u'/Volumes/common/sourcecode/irecruiter/Web/src/com/icims/jobapplications/ws/IndeedApplyPayloadValidator.java'
[Errno 2] No such file or directory: u'/Volumes/common/sourcecode/irecruiter/Web/src/com/icims/jobapplications/ws/IndeedApplyPayloadValidator.java'
[Errno 2] No such file or directory: u'/Volumes/common/sourcecode/irecruiter/Web/src/com/icims/jobapplications/ws/IndeedApplyPayloadValidator.java'
final String NUMBER = "number";
ADDRESSES(BaseController.PPF_ADDRESSES, "addresses"), //
PHONES(BaseController.PPF_PHONES, "phones"), //
EDUCATION(BaseController.CPF_EDUCATION, "education"), //
EMAIL(BaseController.PPF_EMAIL, "email");
errors.add(new ValidationError(ErrorCode.FIELD_REQUIRED, "applicant object is missing (FieldNames are case-sensitive)"));
result.setMessage("Required fields missing");
result.setMessage("Required fields missing");
if (!submittalService.isSubmittalsHaveSameJob(submittalIds)) throw new BusinessLogicException("Given submittalIds must tied to the same job");
if (!submittalService.isSubmittalsHaveSameJob(submittalIds)) throw new BusinessLogicException("Given submittalIds must tied to the same job");
throw new BusinessLogicException("Both of Meeting's start and end date should either be null or not-null.");
throw new BusinessLogicException("All meetings datetime can either be null or not-null");
return getSuccessReturn("created", new JSONObject().put(INTERVIEW_ID_KEY, interview.getId()));
return getSuccessReturn("read", response);
return getSuccessReturn("read", response);
return getSuccessReturn("read", response);
return getSuccessReturn("updated", jsonAdapter.convertFromObject(interview.toInterviewDetail()));
return getSuccessReturn("read", response);
return getSuccessReturn("deleted", response);
return getSuccessReturn("read", response);
return getSuccessReturn("sent", response);
return getSuccessReturn("read", response);
return getSuccessReturn("read", response);
return getSuccessReturn("read", getMailTemplatesHelper());
return getSuccessReturn("read", response);
return getSuccessReturn("read", getAutoCompleteData(profileType, search));
return getSuccessReturn("read", getCandidatesAssociatedToJob(jobId));
return getSuccessReturn("read", response);
mockHttpServletRequest.addParameter("run", "1");
mockHttpServletRequest.addParameter("jump", "1");
mockHttpServletRequest.addParameter("limit", "50");
return getSuccessReturn("read", response);
return getSuccessReturn("read", response);
return getSuccessReturn("read", response);
return getSuccessReturn("created", new JSONObject().put("interviewId", interview.getId()));
return getSuccessReturn("read", response);
return getSuccessReturn("read", response);
return getSuccessReturn("read", new JSONObject().put("variables", variableMappingResponse));
return getSuccessReturn("read", new JSONObject().put("variables", variableMappingResponse));
unit = "day";
unit = "minute";
List<Node> list = DOMHelper.selectNodes(dom.getDocumentElement(), "//Attribute");
protected static final String PERSON_LABEL = "person";
protected static final String JOB_LABEL = "job";
return "OK";
return "OK";
!profileDefinitionType.isCustom() ? profileDefinitionType.getApiName() : "custom"), isReplay, profileDefinitionType, eventSequenceService);
private static final String FOLDER_FIELD_NAME = "folder";
private static final String FOLDER_FIELD_NAME = "folder";
private static final String STATUS_FIELD_NAME = "status";
private static final String VALUE = "value";
private static final String CATEGORY = "category";
ColumnFormat column = ColumnFormatSearch.findBySchemaId(task.getDefaultAssignee().replace("$F", "$T"));
private static final String PROFILE_TYPE_NAME = "custom";
if (node == null) return "deleted";
if (node.getSystemId() == DASHBOARD_SYSTEM_ID) return "shared";
String dynTitle = listNodeService.getDynamicTitle(node, "{subject}");
w.getFields().get("shared").setValue("shared");
if (StringUtils.startsWith(tableType, "Profile") && StringUtils.startsWith(profileType, "Profile")) {
if (StringUtils.startsWith(tableType, "Profile") && StringUtils.startsWith(profileType, "Profile")) {
field.setKey("Share With");
response.setIntegrationSystemName("iCIMS Platform");
private static final String VENDORS2 = "vendors";
private static final String FAILED = "failed";
private static final String POSTED = "posted";
pb.setProfileFriendlyName(FlagTableUtils.lookupFlagtableLabel(profileDef.getFieldFlagsGroupName(), "Profile"));
selectedList = searchEngineBo.getSelectedListForAction(reader, "Post", massPostMax + 1, isSearchBrowser);
String folderLabel = FlagTableUtils.lookupFlagtableLabel("JobProfileFields", "Folder").toLowerCase();
selectedList = searchEngineBo.getSelectedListForAction(reader, "Post", massPostMax + 1, searchBrowser);
selectedList = searchEngineBo.getSelectedListForAction(reader, "Post", -1, isSearchBrowser);
msg.addBody(email.getBody(), "text/html; charset=UTF-8");
response = new JSONObject().put("ok", description);
LinkHeader self = new LinkHeader(apiUrlService.buildSelfUri(messageContext), LinkRelation.SELF, "The current jobpost being viewed.");
JobPostError jpe = new JobPostError(ErrorCode.JOB_UNPOST_SIDE_EFFECT, "There are job board posts that re-direct to this portal post");
private final String parameter_error_message = "Error setting query parameter";
rowcount = executeUpdate("insert into public.customer (customerid, name, status, lastpolldate, jvm, profiletype) values (?, ?, ?, ?, ?, ?);", params -> {
rowcount = executeUpdate("insert into public.chunk (customerid, chunkid, filename, createddate, profiletype) values (?, ?, ?, ?, ?);", params -> {
return "OK";
return "OK";
pb.setShowSocialResume(!"off".equals(Config.getProperty("icims.candidate.social.resume")) && StringUtils.isNotBlank(Config.getProperty("icims.link.account")));
if (allowedTypes.contains("all")) allowedTypes = allTypes.keySet();
if (!"linkedin".equals(account.getAccountType()) || ("linkedin".equals(account.getAccountType()) && linkedInResumeEnabled)) {
if (!"linkedin".equals(account.getAccountType()) || ("linkedin".equals(account.getAccountType()) && linkedInResumeEnabled)) {
BriefAccountInfo traditionalAccount = new BriefAccountInfo("traditional", messageService.getMessage("appcandidateadapter.java.Traditional_957"), null);
pb.setLinkedAccountType("linkedin");
pb.setLinkedAccountTypeDisplayName("LinkedIn");
if (!e.getMessage().startsWith("File not Found")) {
if (("fonts".equals(type) || "img".equals(type) || "svg".equals(type) || "shade".equals(type) || "form".equals(type) || "thumbnails".equals(type) || "turnimages".equals(type))
if (("fonts".equals(type) || "img".equals(type) || "svg".equals(type) || "shade".equals(type) || "form".equals(type) || "thumbnails".equals(type) || "turnimages".equals(type))
if (("fonts".equals(type) || "img".equals(type) || "svg".equals(type) || "shade".equals(type) || "form".equals(type) || "thumbnails".equals(type) || "turnimages".equals(type))
if (!StringUtils.startsWith(resumeHtml, "error:")) {
boolean popup = !"tab".equals(request.getParameter("gui"));
return "OK";
return "OK";
String emailPropKey = "linkedIn.recruiter.request.email";
if (!InstanceManager.getCurrentApp().getCustomer().getCustomerName().startsWith("prod")) {
msg.addBody(template.getBody(), "text/html; charset=UTF-8");
return "OK";
String personIdColumn = "$F{PersonID}";
personIdColumn = StringUtils.replace(col, "$F{CandidateResumeIcon}", personIdColumn);
pageBeanGlyphButtonsBuilder.upload(glyphButtons, "Upload", getMessageService().getMessage("resumepagebean.java.Upload_592"), UrlHash.hashUrl("icims2?module=AppCandidate&action=uploadResume&id=" + profileId + "&_html=1"));
validateListPropKey("icims.config.appstatus.linkedinrsc.oneclick", "Status for LinkedIn RSC One-Click Export");
private static final String COULD_NOT_WRITE = "Could not write {}";
customerIDTStatus.setProfileType("Please provide profile type");
ignoredSchemas.add("$F{VideoUrl}");
ignoredSchemas.add("$F{VCLCantRecordUrl}");
if (messages.size() != 1) throw new BusinessLogicException("While previewing meeting message, we should get 1 message object");
if (start == -1) start = html.indexOf("</head");
if (start == -1) start = html.indexOf("<head");
int end = html.lastIndexOf("</body");
if (methodname.startsWith("is") || methodname.startsWith("get")) {
if (methodname.startsWith("is") || methodname.startsWith("get")) {
return "Could not obtain data from page bean (IllegalAccessException)";
return "Could not obtain data from page bean (InvocationTargetException)";
if (!httpRsp.containsHeader("Expires")) {
if (!ret_file.exists() || !ret_file.canRead()) throw new Exception("Readable resume file does not exist.");
if (StringUtils.isNotBlank(navigatorSpaVersion) && !navigatorSpaVersion.equals("legacy")) {
if (!UrlHash.validateHash(request) && !("Root".equals(module) && "login".equals(action) && RequestMethod.GET.toString().equals(request.getMethod()))) {
if (!skipIpCheck && !"AppInert".equalsIgnoreCase(module) && !("Root".equals(module) && "test".equals(action)) && ipUtilsBlockIP(request)) {
if (!isLoggedIn && (!"Root".equals(module) || !"login".equals(action)) && request.getParameter("LoginName") != null && request.getParameter("LoginPassword") != null) {
("login".equalsIgnoreCase(action) || "logout".equalsIgnoreCase(action) || "resetPassword".equalsIgnoreCase(action) || "password".equalsIgnoreCase(action)))) {
("login".equalsIgnoreCase(action) || "logout".equalsIgnoreCase(action) || "resetPassword".equalsIgnoreCase(action) || "password".equalsIgnoreCase(action)))) {
("login".equalsIgnoreCase(action) || "logout".equalsIgnoreCase(action) || "resetPassword".equalsIgnoreCase(action) || "password".equalsIgnoreCase(action)))) {
if (message == null || message.indexOf("Connection reset by peer") == -1) {
String iformName = "Unknown Form";
TELEPHONE(113002L, "telephone"), //
VIDEO(113003L, "video"), //
CATEGORIES("categories"), //
COMPANIES("companies");
private static final String STATUS = "status";
return "invalid".concat(INVALID_EMAIL_DOMAIN);
return ResourceResponseBuilder.create(Status.OK).response(new JSONObject().put("fields", ret)).build();
return getErrorReturnKey("offeratsclientbindingresource.java.GET.exception.from.atsclient", ErrorCode.INTERNAL_ERROR, Status.BAD_REQUEST, logger, "message", ex.getMessage());
ErrorCode.INTERNAL_ERROR, Status.BAD_REQUEST, logger, "message", ex.getMessage());
ErrorCode.INTERNAL_ERROR, Status.BAD_REQUEST, logger, "message", ex.getMessage());
ErrorCode.INTERNAL_ERROR, Status.BAD_REQUEST, logger, "message", ex.getMessage());
private static final Map<String, List<String>> ENTITLEMENTS = Collections.singletonMap(TOKEN_TYPE, Lists.newArrayList("read"));
private static final String GLOBAL = "global";
private static final String GLOBAL = "global";
private static final String KIND = "kind";
private static final String VALUE = "value";
private static final String CURRENCY = "currency";
private static final String PERIOD = "period";
String[] allowedKindStringsArray = {"person", "submittal", "job"};
String[] allowedKindStringsArray = {"person", "submittal", "job"};
private static final String ERRORS = "errors";
private static final String RESUME_LABEL = "resume";
private static final String EMAIL = "email";
@Path("linkedin")
builder.response(documentText.getBytes("UTF8"), resume.getFilename() + "." + "txt", "text/plain; charset=utf-8");
if (people.size() > 2000) return ResourceResponseBuilder.create(Status.NOT_ACCEPTABLE).response(new JSONObject("{\"error\": \"List of PersonIDs should be less than or equal to 2000\"}")).build();
return Response.status(HttpStatus.SC_BAD_REQUEST).entity("\"error\": SubmittalsIds is malformed. Expected a comma-separated list of ids").build();
SelectedList list = searchEngineBo.getSelectedListForAction(reader, "Forms", -1, isSearchBrowser);
ColumnFormat column = ColumnFormatSearch.findBySchemaId(schemaId.replace("$F", "$T"));
} else if (tableName.startsWith("Profile")) {
for (SearchTemplateInfo info : searchTemplateService.getTemplateInfos(SearchTemplateType.EMAIL_CAMPAIGN_SEARCH, "Person", CurrentUserService.getUserId(), true, true, null)) {
pb.setRefreshOnSend("send".equals(request.getParameter("refreshon")));
if (pde.getMessage() != null && "You already have the global maximum number of templates stored".equals(pde.getMessage())) {
if (StringUtils.equalsIgnoreCase(request.getParameter("mode"), "campaign")) {
return escaped.replaceFirst("text/html", "text/html; charset=UTF-8");
if (msg == null) return "failure";
return success ? "success" : "failure";
return success ? "success" : "failure";
boolean campaignMode = StringUtils.equals(request.getParameter("mode"), "campaign");
if (StringUtils.isBlank(title)) return "failure";
} else if (pde.getMessage() != null && pde.getMessage().contains("not allowed to save public templates")) {
} else if (StringUtils.startsWith(pde.getMessage(), "Cannot save this")) {
String errorMessage = (e.getMessage() != null) ? "Error: " + e.getMessage() : "Error occured while testing SMTP config, see platform logs for more details.";
if (StringUtils.equals(type, "to")) {
return status.equals("success") || status.equals("duplicate");
String status = "success";
return status.equals("success") || status.equals("duplicate");
if (!personNewType.equals(StringUtils.lowerCase(personExistingType))) return "duplicate";
if (StringUtils.equals(type, "to")) {
if (StringUtils.isEmpty(schemaId)) return "failure";
if (StringUtils.isEmpty(schemaId)) return "failure";
String upper = formula.replaceAll("\\s", "").toUpperCase();
return new ApprovalServiceResult<>("acknowledged offer");
return new ApprovalServiceResult<>("created", convertToOfferApproval(offer));
return new ApprovalServiceResult<>("started");
return getSuccessReturn("skipped approver");
return new ApprovalServiceResult<>(skipFlag ? "skipped approver" : "resent to approver");
return new ApprovalServiceResult<>(skipFlag ? "skipped approver" : "resent to approver");
return new ApprovalServiceResult<>("cancelled approval");
jgen.writeStringField("kind", fieldSchema.getKind().toString());
jgen.writeStringField("label", entry.getValue());
jgen.writeStringField("kind", fieldValueResult.getKind().toString());
jgen.writeStringField("value", fieldValueResult.getValue());
jgen.writeStringField("currency", fieldValueResult.getCurrency());
jgen.writeStringField("period", fieldValueResult.getPeriod());
jgen.writeArrayFieldStart("indexes");
return "Last Activity Date Is Not Defined For CustomProfile";
JSONObject successPayload = new JSONObject().put("result", result).put("data", data);
JSONObject successPayload = new JSONObject().put("result", result).put("data", data);
private static final String CUSTOMIZED = "Customized";
private static final String TEMPLATE_LIBRARY_VARIABLE_TYPE_APPROVAL = "approval";
private static final String TEMPLATE_LIBRARY_VARIABLE_TYPE_INTERVIEW = "interview";
private static final String OFFER = "offer";
} else if (StringUtils.equals(mode, "campaign")) {
} else if (StringUtils.equals(mode, "draft")) {
} else if (StringUtils.equals(mode, "notification")) {
result.setTitle(profileId + ", " + (StringUtils.isNotBlank(profileRef.getProfile().getTitle()) ? profileRef.getProfile().getTitle() : "No title"));
hm.setTitle(job.getExtJobId() + ", " + (job.getJobTitle() != null ? job.getJobTitle() : "No title"));
private static final String SOURCE = "source";
private static final String SLOT = "slot";
private static final String LIST = "list";
return APPLICANT_DISTANCE_MAX_VALUE.equals(distance) ? "Far" : distance.toString();
JSONObject workflow = new JSONObject().put(ProfileDefinition.SUBMITTAL, new JSONArray().put(new JSONObject().put("id", profileJSON.opt("baseprofile").toString()).put("profile", "Job")));
JSONObject workflow = new JSONObject().put(ProfileDefinition.SUBMITTAL, new JSONArray().put(new JSONObject().put("id", profileJSON.opt("baseprofile").toString()).put("profile", "Job")));
validateListPropKey("ccc.submittals.withdraw.status.disabled", "Disabled For Statuses");
validateListPropKey("icims.config.css.default_submittal_status", "Status for Applicant Self-Submission");
if (!StringUtils.contains(autoLaunchAction, "ForwardCand") && !StringUtils.contains(autoLaunchAction, "SubmitCand") && !StringUtils.contains(autoLaunchAction, "Comm") && !StringUtils.contains(autoLaunchAction, "Delay")
if (nodeData.getModifiedAttributeValues().containsKey(ListAttributeDefinition.AUTOLAUNCH_ACTIONS) && "Hire,IdentifyWizard,TaskWizard,Comm".equals(nodeData.getModifiedAttributeValues().get(ListAttributeDefinition.AUTOLAUNCH_ACTIONS))) {
CF_SCHEMA_FIELD_MAPPING.put(MultiDataType.TEXTFIELD, "Title");
CF_SCHEMA_FIELD_MAPPING.put(MultiDataType.URL, "Title");
CF_SCHEMA_FIELD_MAPPING.put(MultiDataType.EMAIL, "Title");
CF_SCHEMA_FIELD_MAPPING.put(MultiDataType.RADIO, "Title");
CF_SCHEMA_FIELD_MAPPING.put(MultiDataType.EEODROPDOWN, "Title");
CF_SCHEMA_FIELD_MAPPING.put(MultiDataType.LISTEDITOR_SINGLE_VALUE, "Title");
CF_SCHEMA_FIELD_MAPPING.put(MultiDataType.LEGACYCHECKBOX, "Title");
CF_SCHEMA_FIELD_MAPPING.put(MultiDataType.SSN, "Title");
CF_SCHEMA_FIELD_MAPPING.put(MultiDataType.LEGACYRADIO, "Title");
CF_SCHEMA_FIELD_MAPPING.put(MultiDataType.PASSWORD, "Title");
CF_SCHEMA_FIELD_MAPPING.put(MultiDataType.DROPDOWN_SINGLE, "Option");
CF_SCHEMA_FIELD_MAPPING.put(MultiDataType.LISTEDITOR_MULTIPLE, "Content");
CF_SCHEMA_FIELD_MAPPING.put(MultiDataType.TAG, "Content");
output.setTypeName("Person");
String filterParam = "C_" + primarySchemaId.replace("$F{", "$C{") + "_Value";
String searchId = StringUtil.abstractSubstring(table.getTableName(), "$SEARCH{", "}");
ret = ret.replace(USERID_TOKEN, "$E{GlobalUserID}");
ret = ret.replaceAll("\\d\\d/\\d\\d/\\d\\d\\d\\d \\d\\d:\\d\\d:(\\d\\d).337", "\\$E\\{GlobalDate$1\\}");
} else if (StringUtils.contains(value, "{DATE:") || StringUtils.contains(value, "{HOUR:")) {
} else if (StringUtils.contains(value, "{DATE:") || StringUtils.contains(value, "{HOUR:")) {
} else if (StringUtils.contains(secondaryValue, "{DATE:") || StringUtils.contains(secondaryValue, "{HOUR:")) {
} else if (StringUtils.contains(secondaryValue, "{DATE:") || StringUtils.contains(secondaryValue, "{HOUR:")) {
} else if (ProfileDefinition.PERSON.equals(type) || "candidate".equalsIgnoreCase(type) || "person".equalsIgnoreCase(type)) {
} else if (ProfileDefinition.PERSON.equals(type) || "candidate".equalsIgnoreCase(type) || "person".equalsIgnoreCase(type)) {
if (!configService.getBooleanDynamicProperty("Person", "searchengine.refinesearch.enable")) return false;
SavedFilter groupFilters = this.searchTemplateBo.createFilterTemplate("Person");
if (template == null) throw new PermissionDeniedException("No deletable rows matched the specified templateId");
throw new PermissionDeniedException("User does not have permission to delete other's templates");
throw new PermissionDeniedException("You already have the global maximum number of templates stored");
if (template.getShared() != TemplateSharedType.NOT_SHARED && !Config.getBooleanProperty("icims.config.savedsearch.createshared")) throw new PermissionDeniedException("Current user not allowed to save public templates.");
throw new PermissionDeniedException("Locked templates cannot be customized.");
throw new PermissionDeniedException("Locked Templates cannot be changed");
throw new PermissionDeniedException("Locked Templates cannot be overwitten");
if (template == null) throw new PermissionDeniedException("No deletable rows matched the specified templateId");
if (!("Root".equals(request.getParameter("module")) && "logout".equals(request.getParameter("action")))) {
RequestUtil.setSessionAttribute(request, "branding", request.getParameter("branding"));
descriptors.add(new DataDescriptor("handleAsTextField", "Always edit as text field", DataDescriptor.FIELD_ONOFF, new String[] {DataDescriptor.IFORM_QUESTION}));
descriptors.add(new DataDescriptor(LIST_PROP_KEY, "List PropKey", DataDescriptor.HIDDEN));
descriptors.add(new DataDescriptor(LIST_TYPE, "List Type", DataDescriptor.HIDDEN));
searchEngineService.scheduleFullSearchEngineReset(this.getClass().toString(), "runListSpecificDeleteActions", "Time to Fill fields removed.");
protected static final String INFO_REPORTS = "reports";
item.setCandidateAdvancing(contact.getNotes().contains("advances")); // candidate is advancing or not
item.setChangeTypeText("added");
item.setChangeTypeText("removed");
item.setChangeTypeText("edited");
private static final String OFFER = "OFFER";
UPLOAD("upload"), DOWNLOAD("download"), LINK("link");
UPLOAD("upload"), DOWNLOAD("download"), LINK("link");
UPLOAD("upload"), DOWNLOAD("download"), LINK("link");
map.add("file", new MultipartInputStreamResource(stream, "filename"));
map.add("file", new MultipartInputStreamResource(stream, "filename"));
throw new FailedNotifyException("invalid email");
throw new FailedNotifyException("Unable to send notification email");
if (approval == null) throw new ApprovalException("Can't find the approval.");
throw new ApprovalException("Can't find the approval item.");
JOB(1, "Job", "approvaltype.java.job.approval", true), //
JOB_NOTIFICATION(5, "Job", "approvaltype.java.job.approval.notification", false), //
UNKNOWN(-2, "", "UNKNOWN", false); //
throw new ApprovalException("Approval cannot be null");
throw new ApprovalException("ApprovalEvent is null.");
approvalService.setApprovalItemStatus(item.getId(), ApprovalItemStatus.STATUS_APPROVED, Long.valueOf(event.getUserID()), event.getData("comments"));
throw new ApprovalException("Not implemented yet.");
approvalService.setApprovalItemStatus(item.getId(), ApprovalItemStatus.STATUS_REJECTED, Long.valueOf(event.getUserID()), event.getData("comments"));
throw new ApprovalException("Event type not supported.");
private static final String APPROVAL_TYPE = "type";
private static final String APPROVAL_TITLE = "title";
private static final String FAILURE = "failure";
private static final String REFERER_PARAM = "Referer";
private static final String RESULT = "result";
private static final String SUCCESS = "success";
boolean isHiringManager = "client".equals(request.getParameter("user"));
if (StringUtils.isBlank(url)) throw new Exception("tokenized URL is empty or null");
item.setEvenOrOdd(i++ % 2 == 0 ? "even" : "odd");
item.setEvenOrOdd(i++ % 2 == 0 ? "even" : "odd");
String cause = "cause";
IcimsMessage approvalMessage = getCustomApprovalEmailFromCache(request, "default", approval.getContactId());
throw new DataTableException("Unable to clear the approval list.");
throw new DataTableException("Notification lists cannot be cleared.");
} else if (includeResume && "resume".equalsIgnoreCase(trimmed)) {
Long newDocid = documentService.saveDocument(personId, DocumentItemType.PERSON, null, zipBuffer.toByteArray(), CurrentUserService.getUserId(), personName + " Full Profile Data", "zip", personName + " Full Profile Data",
documentService.updateDocumentBinary(zipDocumentData.get(0).getId(), zipBuffer.toByteArray(), personName + " Full Profile Data", personName + " Full Profile Data", "zip", null);
useConnect = useConnect && ("connect".equals(request.getAttribute("originPortal")) || "/connect".equals(request.getServletPath()));
Query deleteAssociationQuery = createHQLQuery("delete from ActivityAssociation assoc where assoc.activity.id in (:activityIds)");
Query deletePinnedActivityQuery = createHQLQuery("delete from PinnedActivity pinned where pinned.activity.id in (:activityIds)");
Query deleteActivityQuery = createHQLQuery("delete from Activity where id in (:activityIds)");
return "Contact";
if (("Mobile Hiring Manager").equals(contact.getTopic())) {
if (property.isDirty && "title".equals(property.propertyName)) {
FORM_ADD_OR_DELETE(1, "iForm Added or Deleted from Packet"), //
FORM_ORDER(2, "iForm Order"), //
EXPIRATION_DATE(3, "Expiration Date");
return "Job";
return "Person";
return listSelectionDAO.findOneByProperties(ListSelectionUtils.getEntityNameFromOwner(owner), new String[] {"owner.id", "type", "nodeId"}, new Object[] {owner.getId(), Integer.valueOf(type), nodeId});
.addEntity("I", "Interview") //
.addEntity("I", "Interview") //
.addEntity("I", "Interview") //
&& (!Config.getBooleanProperty("icims.textrecruit.dev.limiter") || (StringUtils.startsWith(databaseName, "prod") || StringUtils.startsWith(databaseName, "demo")));
SECOND(0, "second"), //
MINUTE(1, "minute"), //
HOUR(2, "hour"), //
DAY(3, "day"), //
WEEK(4, "week"), //
UNKNOWN(-1, "unknown");
PENDING("pending"), //
COMPLETED("completed"), //
ALL("all");
return "Canceled";
return "Planned";
return "Published";
private static final String CHILD_LOCK = "children";
if (!term.isEmpty() && !"in".equals(term) && !"of".equals(term) && (term.length() > 0 || (int)term.charAt(0) > 127 || (int)term.charAt(0) == 35)) {
if (!term.isEmpty() && !"in".equals(term) && !"of".equals(term) && (term.length() > 0 || (int)term.charAt(0) > 127 || (int)term.charAt(0) == 35)) {
if (StringUtils.isBlank(name)) name = "(un-named attribute)";
private static final String D_TABLE_VALUE_PREFIX = "$D{TableValue";
private static final String D_TABLE_VALUE = "$D{TableValue}";
private static final String D_VALUE_PREFIX = "$D{Value";
private static final String D_VALUE = "$D{Value}";
private static final String D_KEY_PREFIX = "$D{Key";
private static final String D_PROFILE_VALUE = "$D{ProfileValue}";
private static final String D_PROFILE_VALUE_PREFIX = "$D{ProfileValue";
if (root == null) return "[No Root]";
Preconditions.checkArgument(StringUtils.isNotBlank(featureFlagKey), "feature flag key cannot be blank");
return value + (customized ? "[Custom]" : "");
Query query = createHQLQuery("delete ListAttributeHistory where personId IN (:personIds)");
.setTimestamp("from", createdDateFrom) //
.setTimestamp("to", createdDateTo);
STRING("string"), CHECKBOX("checkbox"), INTEGER("integer"), REAL("real"), DROPDOWN("dropdown"), LISTSELECTION("listselection"), LISTMULTISELECTION("listmultiselection"), COMMCENTER("commcenter"), RELATIONALPICKER("relationalpicker");
STRING("string"), CHECKBOX("checkbox"), INTEGER("integer"), REAL("real"), DROPDOWN("dropdown"), LISTSELECTION("listselection"), LISTMULTISELECTION("listmultiselection"), COMMCENTER("commcenter"), RELATIONALPICKER("relationalpicker");
} else if (cmd.startsWith("Level")) {
if (cmd2 != null && cmd2.startsWith("Value")) {
theAttribute = "(Attribute's ListAttributeID_ not currently supported)";
theAttribute = "(Attribute's Order_ not currently supported)";
if (format.startsWith("PROP;")) format = Config.getProperty(userID, format.substring(5), "/");
if (arrayDelimiter.startsWith("PROP;")) arrayDelimiter = Config.getProperty(userID, arrayDelimiter.substring(5), ",");
EQUAL("equal"), //
FLAG("flag"), //
GROUP("group"), //
PROP("prop"), //
TAB("tab"), //
TEMPLATE("template"), //
List<Node> list = DOMHelper.selectNodes(dom, "//List/@propkey");
List<Node> list = DOMHelper.selectNodes(dom, "//List/@file");
List<Node> list = DOMHelper.selectNodes(getDOM(), "/*/Attributes/Attribute");
return value.replaceAll("\\$D\\{Key\\}", Matcher.quoteReplacement(dynamicKey)).replaceAll("\\$D\\{Value\\}", Matcher.quoteReplacement(configData != null ? configData.getValue() : ""));
return value.replaceAll("\\$D\\{Key\\}", Matcher.quoteReplacement(dynamicKey)).replaceAll("\\$D\\{Value\\}", Matcher.quoteReplacement(configData != null ? configData.getValue() : ""));
List<Node> xmlChildrenList = DOMHelper.selectNodes(xmlParentNode, "Node");
List<Node> xmlAttributeList = DOMHelper.selectNodes(xmlChildNode, "Attribute");
value = "1".equals(value) ? "Enabled" : "Disabled";
value = "1".equals(value) ? "Enabled" : "Disabled";
this.defaultValueListText = "1".equals(defaultValue) ? "Checked" : "Unchecked";
private static final String WORKFLOW_STATUS_DEFAULT_VALUE = "Under Review";
if (currentListPropKey.startsWith("lists.")) fileChecksum = ChecksumUtil.getHash(ResourceReader.getResourceAsStream(currentList.getFilePath()));
searchEngineService.scheduleFullSearchEngineReset(this.getClass().toString(), "runListSpecificActions", "Time to Fill fields modified.");
private static final String GLOBAL = "global";
private static final String DEPTH = "depth";
private static final String RESULT = "result";
if (listNodeKey.startsWith("New")) {
if (node.fieldKey.startsWith("New") && MultiDataType.DROPDOWN_ID.getValue().toString().equals(node.type) && !node.fieldOptions.isNull(PARENT_FIELD) && StringUtils.isNotEmpty(node.fieldOptions.getString(PARENT_FIELD))) {
} else if (listNodeKey.startsWith("New")) {
} else if (listNodeKey.startsWith("New")) {
if (fieldKey.startsWith("New")) {
return "fields".equalsIgnoreCase(nodeInProfileTabsList.getAttributeValue(ListAttributeDefinition.PROFILE_PANEL_TYPE));
if (nodeData.getListNodeKey().startsWith("New") && nodeData.getParent() != null && "PersonProfileFields".equals(nodeData.getParent().getValue())) {
if (nodeData.getListNodeKey().startsWith("New")) {
boolean newField = fieldKey.startsWith("New") || allNewFields;
definitionNodeData.getModifiedAttributeValues().put(ListAttributeDefinition.CF_SORT_DEFINITION, "Created Date,true,true,0;Updated Date,true,true,1");
definitionNodeData.getModifiedAttributeValues().put(ListAttributeDefinition.CF_SORT_DEFINITION, "Created Date,true,true,0;Updated Date,true,true,1");
if (profile.startsWith("person")) {
} else if (profile.startsWith("job")) {
} else if (profile.startsWith("profile")) {
type = "Referral";
if (node.fieldOptions.toString().contains("sensitive")) return true;
private static final String FIELD_PARAM = "field";
private static final String TITLE_PARAM = "title";
private static final String RESULT = "result";
boolean missingParam = Stream.of(LIST_PROPKEY_PARAM, "page", GROUP_ID_PARAM, ROOT_NODE_PARAM, "showHidden", "showSynonym") //
JSONObject listsJSON = new JSONObject().put("lists", new JSONArray(getSupportedLists()));
if (page > getLastPage(nodes.size())) throw new PageInvalidException("page parameter cannot be greater than the total number of pages");
builder.replaceQueryParam("page", page);
builder.replaceQueryParam("page");
private static final String CHILDREN = "children";
if (entry.getKey().startsWith("New")) {
if (requestedPage < 1) throw new PageInvalidException("page parameter must be greater than 0");
if (requestedSize < 1) throw new PageInvalidException("size parameter must be greater than 0");
SUCCESS("success"), WARN("warn"), FAIL("fail");
SUCCESS("success"), WARN("warn"), FAIL("fail");
SUCCESS("success"), WARN("warn"), FAIL("fail");
String errorMsg = "Invalid JSON format";
if (!StringUtils.equalsIgnoreCase(customerTypeSource, "test") || !StringUtils.equalsIgnoreCase(customerTypeTarget, "prod") //
if (!StringUtils.equalsIgnoreCase(customerTypeSource, "test") || !StringUtils.equalsIgnoreCase(customerTypeTarget, "prod") //
ResourceResponseBuilder builder = buildResponseImport(ErrorCode.INVALID_CONTENT_DISPOSITION, ConfigurationResourceResultType.FAIL, source, "Expected file not found", filename);
public static final String REFERRAL = "referral";
private static final String RESULT = "result";
String groupName = "Global";
ResourceResponseBuilder builder = buildResponseImport(ErrorCode.INVALID_CONTENT_DISPOSITION, ConfigurationResourceResultType.FAIL, source, "Expected file not found", filename);
if (StringUtils.equalsIgnoreCase("success", result)) {
return "PRIVATE";
return "PUBLIC";
return "UNKNOWN";
return "Undecided";
return "Accepted";
return "Declined";
return "Tentative";
return "Not Sent";
Query query = createReadOnlySQLQuery(sql).addEntity("c", "Contact") //
Query query = createReadOnlySQLQuery(sql).addEntity("con", "Contact");
Query query = createReadOnlySQLQuery(sql).addEntity("con", "Contact");
SEND("send"), //
CANCEL("cancel"), //
UNKNOWN("unknown");
shortSubject = "No Subject";
params.add(new XParameter("X-FILENAME", filename == null ? "unknown file" : filename));
ProfileField capacityField = helper.createNumberField("capacity", capacity);
ProfileField deleteIcon = new ProfileFieldHelper(row.getId()).createIconField("delete", "16/redx.png", "Delete", null, "deleteRow(document.id(this).getParent('table.dataTable').get('id'),this);");
ProfileField deleteIcon = new ProfileFieldHelper(row.getId()).createIconField("delete", "16/redx.png", "Delete", null, "deleteRow(document.id(this).getParent('table.dataTable').get('id'),this);");
Integer defaultStatus = "interview".equals(dataTable.getStaticParameter("defaultContactType")) ? Contact.INTERVIEW_SCHEDULE : Contact.APPOINTMENT;
throw new PermissionDeniedException("You do not have permissions to delete contact entries of other users");
throw new PermissionDeniedException("Emails sent as part of an email campaign cannot be deleted.");
if (StringUtils.equals(mode, "interview")) {
pb.setNewAppointment(StringUtils.equals("new", request.getParameter("cmd")));
boolean isResource = StringUtils.equalsIgnoreCase("room", attendee.getString("type"));
boolean isResource = StringUtils.equalsIgnoreCase("room", attendee.getString("type"));
boolean isPerson = StringUtils.equalsIgnoreCase("person", attendee.getString("type"));
if (StringUtils.startsWith(toId, "room")) {
} else if (StringUtils.startsWith(toId, "person")) {
boolean isResource = StringUtils.equalsIgnoreCase("room", attendee.getString("type"));
.addMetadata("subject", c.getTopic()) //
.addMetadata("location", c.getLocation());
.addMetadata("association", association) //
calendarAppointment.addMetadata("description", TextFromHtml.getTextFromHtml(c.getNotes()));
items.put(new JSONObject().put("key", entry.getKey()).put("value", entry.getValue()));
items.put(new JSONObject().put("key", entry.getKey()).put("value", entry.getValue()));
if (profileId != null && ("Job".equals(profileType) || "Person".equals(profileType))) {
if (profileId != null && ("Job".equals(profileType) || "Person".equals(profileType))) {
results.put(new JSONObject().put("name", key).put("values", result.get(key)));
if (!("delete".equals(which) && StringUtils.isEmpty(query))) {
dataTable.updateRows(manager.getRows(dataTable, "update", dataTableJSON));
dataTable.addRows(manager.getRows(dataTable, "add", dataTableJSON));
dataTable.deleteRows(manager.getRows(dataTable, "delete", dataTableJSON));
return new ProfileFieldHelper(rowId).createIconField("delete", "16/redx.png", messageService.getMessage("datatable.delete"), null, "deleteRow(document.id(this).getParent('table.dataTable').get('id'),this);");
PacificStandardTime("Pacific Standard Time", new HashSet<>(Arrays.asList("America/Los_Angeles", "America/Vancouver", "America/Dawson", "America/Whitehorse", "America/Tijuana", "PST8PDT"))), //
PacificStandardTimeMexico("Pacific Standard Time (Mexico)", new HashSet<>(Arrays.asList("America/Santa_Isabel"))), PakistanStandardTime("Pakistan Standard Time", new HashSet<>(Arrays.asList("Asia/Karachi"))), //
PacificStandardTimeMexico("Pacific Standard Time (Mexico)", new HashSet<>(Arrays.asList("America/Santa_Isabel"))), PakistanStandardTime("Pakistan Standard Time", new HashSet<>(Arrays.asList("Asia/Karachi"))), //
ParaguayStandardTime("Paraguay Standard Time", new HashSet<>(Arrays.asList("America/Asuncion"))), //
RomanceStandardTime("Romance Standard Time", new HashSet<>(Arrays.asList("Europe/Paris", "Europe/Brussels", "Europe/Copenhagen", "Europe/Madrid", "Africa/Ceuta"))), //
RussiaTimeZone10("Russia Time Zone 10", new HashSet<>(Arrays.asList("Asia/Srednekolymsk"))), //
RussiaTimeZone11("Russia Time Zone 11", new HashSet<>(Arrays.asList("Asia/Kamchatka", "Asia/Anadyr"))), //
RussiaTimeZone3("Russia Time Zone 3", new HashSet<>(Arrays.asList("Europe/Samara"))), //
AstrakhanStandardTime("Astrakhan Standard Time", new HashSet<>(Arrays.asList("Europe/Astrakhan"))), //
RussianStandardTime("Russian Standard Time", new HashSet<>(Arrays.asList("Europe/Moscow", "Europe/Simferopol", "Europe/Volgograd", "Europe/Kirov", "Europe/Ulyanovsk"))), //
SAEasternStandardTime("SA Eastern Standard Time",
SAPacificStandardTime("SA Pacific Standard Time",
SAWesternStandardTime("SA Western Standard Time",
SEAsiaStandardTime("SE Asia Standard Time",
SamoaStandardTime("Samoa Standard Time", new HashSet<>(Arrays.asList("Pacific/Apia"))), //
SingaporeStandardTime("Singapore Standard Time", new HashSet<>(Arrays.asList("Asia/Singapore", "Asia/Brunei", "Asia/Makassar", "Asia/Kuala_Lumpur", "Asia/Kuching", "Asia/Manila", "Etc/GMT-8"))), //
SouthAfricaStandardTime("South Africa Standard Time",
SriLankaStandardTime("Sri Lanka Standard Time", new HashSet<>(Arrays.asList("Asia/Colombo"))), //
SyriaStandardTime("Syria Standard Time", new HashSet<>(Arrays.asList("Asia/Damascus"))), //
TaipeiStandardTime("Taipei Standard Time", new HashSet<>(Arrays.asList("Asia/Taipei"))), //
TasmaniaStandardTime("Tasmania Standard Time", new HashSet<>(Arrays.asList("Australia/Hobart", "Australia/Currie"))), //
TokyoStandardTime("Tokyo Standard Time", new HashSet<>(Arrays.asList("Asia/Tokyo", "Asia/Jayapura", "Pacific/Palau", "Asia/Dili", "Etc/GMT-9"))), //
TongaStandardTime("Tonga Standard Time", new HashSet<>(Arrays.asList("Pacific/Tongatapu", "Pacific/Enderbury", "Pacific/Fakaofo", "Pacific/Tongatapu", "Etc/GMT-13"))), //
TurkeyStandardTime("Turkey Standard Time", new HashSet<>(Arrays.asList("Europe/Istanbul", "Asia/Istanbul"))), //
USEasternStandardTime("US Eastern Standard Time", new HashSet<>(Arrays.asList("America/Indianapolis", "America/Indiana/Indianapolis", "America/Indiana/Marengo", "America/Indiana/Vevay"))), //
USMountainStandardTime("US Mountain Standard Time", new HashSet<>(Arrays.asList("America/Phoenix", "America/Dawson_Creek", "America/Creston", "America/Hermosillo", "Etc/GMT+7", "MST"))), //
WAustraliaStandardTime("W. Australia Standard Time", new HashSet<>(Arrays.asList("Australia/Perth", "Antarctica/Casey"))), //
UlaanbaatarStandardTime("Ulaanbaatar Standard Time", new HashSet<>(Arrays.asList("Asia/Ulaanbaatar", "Asia/Choibalsan"))), //
VenezuelaStandardTime("Venezuela Standard Time", new HashSet<>(Arrays.asList("America/Caracas"))), //
VladivostokStandardTime("Vladivostok Standard Time", new HashSet<>(Arrays.asList("Asia/Vladivostok", "Asia/Sakhalin", "Asia/Ust-Nera"))), //
WCentralAfricaStandardTime("W. Central Africa Standard Time",
WEuropeStandardTime("W. Europe Standard Time",
WestAsiaStandardTime("West Asia Standard Time",
WestPacificStandardTime("West Pacific Standard Time",
YakutskStandardTime("Yakutsk Standard Time", new HashSet<>(Arrays.asList("Asia/Yakutsk", "Asia/Khandyga")));
AUSCentralStandardTime("AUS Central Standard Time", new HashSet<>(Arrays.asList("Australia/Darwin"))), //
AUSCentralWStandardTime("Aus Central W. Standard Time", new HashSet<>(Arrays.asList("Australia/Eucla"))), //
AUSEasternStandardTime("AUS Eastern Standard Time", new HashSet<>(Arrays.asList("Australia/Sydney", "Australia/Melbourne"))), //
LordHoweStandardTime("Lord Howe Standard Time", new HashSet<>(Arrays.asList("Australia/Lord_Howe"))), //
ChathamIslandsStandardTime("Chatham Islands Standard Time", new HashSet<>(Arrays.asList("Pacific/Chatham"))), //
EasterIslandStandardTime("Easter Island Standard Time", new HashSet<>(Arrays.asList("Pacific/Easter"))), //
NorfolkStandardTime("Norfolk Standard Time", new HashSet<>(Arrays.asList("Pacific/Norfolk"))), //
AfghanistanStandardTime("Afghanistan Standard Time", new HashSet<>(Arrays.asList("Asia/Kabul"))), //
AlaskanStandardTime("Alaskan Standard Time", new HashSet<>(Arrays.asList("America/Anchorage", "America/Juneau", "America/Nome", "America/Sitka", "America/Yakutat", "America/Metlakatla"))), //
ArabStandardTime("Arab Standard Time", new HashSet<>(Arrays.asList("Asia/Riyadh", "Asia/Bahrain", "Asia/Kuwait", "Asia/Qatar", "Asia/Riyadh", "Asia/Aden"))), //
ArabianStandardTime("Arabian Standard Time", new HashSet<>(Arrays.asList("Asia/Dubai", "Asia/Muscat", "Etc/GMT-4"))), //
ArabicStandardTime("Arabic Standard Time", new HashSet<>(Arrays.asList("Asia/Baghdad"))), //
ArgentinaStandardTime("Argentina Standard Time",
AtlanticStandardTime("Atlantic Standard Time", new HashSet<>(Arrays.asList("America/Halifax", "America/Glace_Bay", "America/Goose_Bay", "America/Moncton", "Atlantic/Bermuda", "America/Thule"))), //
AzerbaijanStandardTime("Azerbaijan Standard Time", new HashSet<>(Arrays.asList("Asia/Baku"))), //
AzoresStandardTime("Azores Standard Time", new HashSet<>(Arrays.asList("Atlantic/Azores", "America/Scoresbysund"))), //
BahiaStandardTime("Bahia Standard Time", new HashSet<>(Arrays.asList("America/Bahia"))), BangladeshStandardTime("Bangladesh Standard Time", new HashSet<>(Arrays.asList("Asia/Dhaka", "Asia/Thimphu"))), //
BahiaStandardTime("Bahia Standard Time", new HashSet<>(Arrays.asList("America/Bahia"))), BangladeshStandardTime("Bangladesh Standard Time", new HashSet<>(Arrays.asList("Asia/Dhaka", "Asia/Thimphu"))), //
BelarusStandardTime("Belarus Standard Time", new HashSet<>(Arrays.asList("Europe/Minsk"))), //
CanadaCentralStandardTime("Canada Central Standard Time", new HashSet<>(Arrays.asList("America/Regina", "America/Swift_Current"))), //
CapeVerdeStandardTime("Cape Verde Standard Time", new HashSet<>(Arrays.asList("Atlantic/Cape_Verde", "Etc/GMT+1"))), //
CaucasusStandardTime("Caucasus Standard Time", new HashSet<>(Arrays.asList("Asia/Yerevan"))), //
CenAustraliaStandardTime("Cen. Australia Standard Time", new HashSet<>(Arrays.asList("Australia/Adelaide", "Australia/Broken_Hill"))), //
CentralAmericaStandardTime("Central America Standard Time",
CentralAsiaStandardTime("Central Asia Standard Time", new HashSet<>(Arrays.asList("Asia/Almaty", "Antarctica/Vostok", "Asia/Kashgar", "Asia/Urumqi", "Indian/Chagos", "Asia/Bishkek", "Asia/Almaty", "Asia/Qyzylorda", "Etc/GMT-6"))), //
CentralBrazilianStandardTime("Central Brazilian Standard Time", new HashSet<>(Arrays.asList("America/Cuiaba", "America/Campo_Grande"))), //
CentralEuropeStandardTime("Central Europe Standard Time", new HashSet<>(Arrays.asList("Europe/Budapest", "Europe/Tirane", "Europe/Prague", "Europe/Podgorica", "Europe/Belgrade", "Europe/Ljubljana", "Europe/Bratislava", "MET"))), //
EEuropeStandardTime("E. Europe Standard Time", new HashSet<>(Arrays.asList("EET", "Asia/Gaza", "Asia/Hebron", "Europe/Nicosia"))), //
CentralEuropeanStandardTime("Central European Standard Time", new HashSet<>(Arrays.asList("CET", "Europe/Warsaw", "Europe/Sarajevo", "Europe/Zagreb", "Europe/Skopje"))), //
CentralPacificStandardTime("Central Pacific Standard Time",
CentralStandardTime("Central Standard Time",
CentralStandardTimeMexico("Central Standard Time (Mexico)", new HashSet<>(Arrays.asList("America/Mexico_City", "America/Bahia_Banderas", "America/Merida", "America/Monterrey"))), //
ChinaStandardTime("China Standard Time", new HashSet<>(Arrays.asList("Asia/Shanghai", "Asia/Hong_Kong", "Asia/Macau", "Asia/Chongqing", "Asia/Harbin"))), //
DatelineStandardTime("Dateline Standard Time", new HashSet<>(Arrays.asList("Etc/GMT+12"))), //
EAfricaStandardTime("E. Africa Standard Time",
EAustraliaStandardTime("E. Australia Standard Time", new HashSet<>(Arrays.asList("Australia/Brisbane", "Australia/Lindeman"))), //
ESouthAmericaStandardTime("E. South America Standard Time", new HashSet<>(Arrays.asList("America/Sao_Paulo"))), //
EkaterinburgStandardTime("Ekaterinburg Standard Time", new HashSet<>(Arrays.asList("Asia/Yekaterinburg"))), //
FLEStandardTime("FLE Standard Time", new HashSet<>(Arrays.asList("Europe/Kiev", "Europe/Mariehamn", "Europe/Sofia", "Europe/Tallinn", "Europe/Helsinki", "Europe/Vilnius", "Europe/Riga", "Europe/Uzhgorod", "Europe/Zaporozhye"))), //
EasternStandardTime("Eastern Standard Time",
EasternStandardTimeMexico("Eastern Standard Time (Mexico)", new HashSet<>(Arrays.asList("America/Cancun"))), //
EgyptStandardTime("Egypt Standard Time", new HashSet<>(Arrays.asList("Africa/Cairo"))), //
FijiStandardTime("Fiji Standard Time", new HashSet<>(Arrays.asList("Pacific/Fiji"))), //
MarquesasStandardTime("Marquesas Standard Time", new HashSet<>(Arrays.asList("Pacific/Marquesas"))), //
GMTStandardTime("GMT Standard Time",
GTBStandardTime("GTB Standard Time", new HashSet<>(Arrays.asList("Europe/Bucharest", "Asia/Nicosia", "Europe/Athens", "Europe/Chisinau"))), //
GeorgianStandardTime("Georgian Standard Time", new HashSet<>(Arrays.asList("Asia/Tbilisi"))), //
GreenlandStandardTime("Greenland Standard Time", new HashSet<>(Arrays.asList("America/Godthab", "America/Miquelon"))), //
GreenwichStandardTime("Greenwich Standard Time",
HawaiianStandardTime("Hawaiian Standard Time", new HashSet<>(Arrays.asList("Pacific/Honolulu", "Pacific/Rarotonga", "Pacific/Tahiti", "Pacific/Johnston", "America/Adak", "Etc/GMT+10", "HST"))), //
IndiaStandardTime("India Standard Time", new HashSet<>(Arrays.asList("Asia/Calcutta", "Asia/Kolkata"))), //
IranStandardTime("Iran Standard Time", new HashSet<>(Arrays.asList("Asia/Tehran"))), //
IsraelStandardTime("Israel Standard Time", new HashSet<>(Arrays.asList("Asia/Jerusalem"))), //
JordanStandardTime("Jordan Standard Time", new HashSet<>(Arrays.asList("Asia/Amman"))), //
KaliningradStandardTime("Kaliningrad Standard Time", new HashSet<>(Arrays.asList("Europe/Kaliningrad"))), //
KoreaStandardTime("Korea Standard Time", new HashSet<>(Arrays.asList("Asia/Seoul"))), //
NorthKoreaStandardTime("North Korea Standard Time", new HashSet<>(Arrays.asList("Asia/Pyongyang"))), //
LibyaStandardTime("Libya Standard Time", new HashSet<>(Arrays.asList("Africa/Tripoli"))), //
LineIslandsStandardTime("Line Islands Standard Time", new HashSet<>(Arrays.asList("Pacific/Kiritimati", "Etc/GMT-14"))), //
MagadanStandardTime("Magadan Standard Time", new HashSet<>(Arrays.asList("Asia/Magadan"))), //
MauritiusStandardTime("Mauritius Standard Time", new HashSet<>(Arrays.asList("Indian/Mauritius", "Indian/Reunion", "Indian/Mahe"))), //
MiddleEastStandardTime("Middle East Standard Time", new HashSet<>(Arrays.asList("Asia/Beirut"))), //
MontevideoStandardTime("Montevideo Standard Time", new HashSet<>(Arrays.asList("America/Montevideo"))), //
MoroccoStandardTime("Morocco Standard Time", new HashSet<>(Arrays.asList("Africa/Casablanca", "Africa/El_Aaiun"))), //
MountainStandardTime("Mountain Standard Time",
MountainStandardTimeMexico("Mountain Standard Time (Mexico)", new HashSet<>(Arrays.asList("America/Chihuahua", "America/Mazatlan"))), //
MyanmarStandardTime("Myanmar Standard Time", new HashSet<>(Arrays.asList("Asia/Rangoon", "Indian/Cocos"))), //
NCentralAsiaStandardTime("N. Central Asia Standard Time", new HashSet<>(Arrays.asList("Asia/Novosibirsk", "Asia/Omsk"))), //
NamibiaStandardTime("Namibia Standard Time", new HashSet<>(Arrays.asList("Africa/Windhoek"))), //
NepalStandardTime("Nepal Standard Time", new HashSet<>(Arrays.asList("Asia/Katmandu", "Asia/Kathmandu"))), //
NewZealandStandardTime("New Zealand Standard Time", new HashSet<>(Arrays.asList("Pacific/Auckland", "Antarctica/McMurdo"))), //
NewfoundlandStandardTime("Newfoundland Standard Time", new HashSet<>(Arrays.asList("America/St_Johns"))), //
NorthAsiaEastStandardTime("North Asia East Standard Time", new HashSet<>(Arrays.asList("Asia/Irkutsk", "Asia/Chita"))), //
NorthAsiaStandardTime("North Asia Standard Time", new HashSet<>(Arrays.asList("Asia/Krasnoyarsk", "Asia/Novokuznetsk", "Asia/Barnaul", "Asia/Tomsk"))), //
PacificSAStandardTime("Pacific SA Standard Time", new HashSet<>(Arrays.asList("America/Santiago", "Antarctica/Palmer"))), //
super("documents");
TIME("time"),
LONG("long"),
DateTime dt = DateTimeFormat.forPattern("MM-dd-yyyy").parseDateTime(value);
private static final DateTimeFormatter FORMATTER_DB = DateTimeFormat.forPattern("MM/dd/yyyy HH:mm:ss.SSS").withZone(getTimeZone());
private static final DateTimeFormatter FORMATTER_VARCHAR_DATETIME = DateTimeFormat.forPattern("MM/dd/yyyy HH:mm:ss.SSS").withZone(getTimeZone());
private static final DateTimeFormatter FORMATTER_VARCHAR_DATEONLY = DateTimeFormat.forPattern("MM/dd/yyyy").withZone(getTimeZone());
if (StringUtils.isNotBlank(localeCode) && !"multiple".equals(localeCode) && !"other".equals(localeCode)) {
if (StringUtils.isNotBlank(localeCode) && !"multiple".equals(localeCode) && !"other".equals(localeCode)) {
doNotCompress.add("tiff");
doNotCompress.add("zip");
return "Job";
return "Person";
return "Custom Profile";
return "Scheduler";
return "Meeting";
return "Unknown";
if (("files".equalsIgnoreCase(type) && isImage) || //
("images".equalsIgnoreCase(type) && !isImage)) {
throw new NotImplementedException("Method not implemented.");
if (e.getMessage() != null && e.getMessage().indexOf("does not exist") != -1) {
fileName = "resume";
private static final String RESUME_TITLE = "Resume";
String ext = "invalid";
pb.setContext("resume");
pb.setNameOfType("Resume");
JSONObject keyJSON = new JSONObject().put("key", key).put("value", v).put("effValue", e_v).put("defValue", d_v);
JSONObject keyJSON = new JSONObject().put("key", key).put("value", v).put("effValue", e_v).put("defValue", d_v);
GlyphButton upload = pageBeanGlyphButtonsBuilder.upload(glyphButtons, "Add Attachment", getMessageService().getMessage("attachmentspagebean.java.addAttachment_1"),
addBody(body, "text/plain; charset=UTF-8");
addBody(body, "text/html; charset=UTF-8");
addBody(body, "text/html; charset=UTF-8");
setBody(1, body, "text/html; charset=UTF-8");
private static final String[] conversion = {"AN", "default", "EL", "IE", "IL", "JB", "LI", "LM", "ME", "MS", "SE", "SN", "SQ", "SR", "SU", "VN", "SO", "IP", "TS", "XC", "EC", "FC", "FJ", "AE", "BE", "FN", "EC", "FD", "RP", "TX", "IN",
private static final String[] conversion = {"AN", "default", "EL", "IE", "IL", "JB", "LI", "LM", "ME", "MS", "SE", "SN", "SQ", "SR", "SU", "VN", "SO", "IP", "TS", "XC", "EC", "FC", "FJ", "AE", "BE", "FN", "EC", "FD", "RP", "TX", "IN",
private static final String[] conversion = {"AN", "default", "EL", "IE", "IL", "JB", "LI", "LM", "ME", "MS", "SE", "SN", "SQ", "SR", "SU", "VN", "SO", "IP", "TS", "XC", "EC", "FC", "FJ", "AE", "BE", "FN", "EC", "FD", "RP", "TX", "IN",
private static final String[] conversion = {"AN", "default", "EL", "IE", "IL", "JB", "LI", "LM", "ME", "MS", "SE", "SN", "SQ", "SR", "SU", "VN", "SO", "IP", "TS", "XC", "EC", "FC", "FJ", "AE", "BE", "FN", "EC", "FD", "RP", "TX", "IN",
private static final String[] conversion = {"AN", "default", "EL", "IE", "IL", "JB", "LI", "LM", "ME", "MS", "SE", "SN", "SQ", "SR", "SU", "VN", "SO", "IP", "TS", "XC", "EC", "FC", "FJ", "AE", "BE", "FN", "EC", "FD", "RP", "TX", "IN",
private static final String[] conversion = {"AN", "default", "EL", "IE", "IL", "JB", "LI", "LM", "ME", "MS", "SE", "SN", "SQ", "SR", "SU", "VN", "SO", "IP", "TS", "XC", "EC", "FC", "FJ", "AE", "BE", "FN", "EC", "FD", "RP", "TX", "IN",
private static final String[] conversion = {"AN", "default", "EL", "IE", "IL", "JB", "LI", "LM", "ME", "MS", "SE", "SN", "SQ", "SR", "SU", "VN", "SO", "IP", "TS", "XC", "EC", "FC", "FJ", "AE", "BE", "FN", "EC", "FD", "RP", "TX", "IN",
"PN", "PM", "JR", "JA"};
GERMAN("de"), //
SPANISH("es"), //
ITALIAN("it"), //
BOTH_EXIST(3, "both", null);
return "[confirmed]";
return "[invalid]";
return "[bounced]";
if (instance == null) return "unknown";
setBody(0, body, "text/plain; charset=UTF-8");
addBody(body, "text/plain; charset=UTF-8");
addBody(text, "text/plain; charset=UTF-8");
p.set("filename", filename, charset);
UNKNOWN(0, "unknown", false), //
PASS(1, "pass", true), //
NEUTRAL(2, "neutral", false), //
FAIL(4, "fail", false), //
Long ownerId = results.getLongColumn("owner");
protected static final String BIDIRECTIONAL_FOLDER_RECIPIENT_ADDRESS_REGEX = "[^\\+]+\\+(email)\\+[^\\+]+@(%)";
protected static final String BOUNCE_FOLDER_RECIPIENT_ADDRESS_REGEX = "[^\\+]+\\+(bounce)\\+[^\\+]+@(%)";
if (StringUtils.containsIgnoreCase(ExceptionUtils.getRootCauseMessage(e), "lens server")) {
String sourceChannel = "Email Import";
String source = "Email";
tagImportedResults(emailLogEntry, extra, msg, "[message body]", resumeImportService.doImportTextJSON(parseLang(msg.getRecipient()), text, extra));
String firstName = StringUtils.isNotBlank(resultJSON.optString("firstname")) ? resultJSON.optString("firstname") : "EMPTY";
String lastName = StringUtils.isNotBlank(resultJSON.optString("lastname")) ? resultJSON.optString("lastname") : "EMPTY";
String email = StringUtils.isNotBlank(resultJSON.optString("email")) ? resultJSON.optString("email") : "EMPTY";
if (!ArrayUtils.isEmpty(row) && StringUtils.startsWith(row[0], "Successfully imported")) continue;
if (!ArrayUtils.isEmpty(row) && StringUtils.startsWith(row[0], "Successfully imported")) continue;
String[] receivedHeaders = message.getHeader("Received");
if (nameValuePair.getName().equalsIgnoreCase("subject") && nameValuePair.getValue().equalsIgnoreCase("unsubscribe")) {
BULK("Bulk"),
AUTO("Auto"),
NORMAL("Normal"), UNKNOWN("Unknown");
NORMAL("Normal"), UNKNOWN("Unknown");
if (contactId == null) throw new FailedNotifyException("An error occurred while saving the IcimsMessage.");
ignoredSchema.add("$F{VideoUrl}");
ignoredSchema.add("$F{VCLCantRecordUrl}");
} else if (StringUtils.startsWith(searchTable, "Profile")) {
Long profileType = StringUtil.toLong(StringUtils.substring(searchTable, "Profile".length()));
if (StringUtils.isBlank(csvIds) || "Status:".equals(csvIds.trim())) return new ArrayList<>();
String senderLabel = isSenderPlatformUser ? "platform user" : "non platform user";
String senderLabel = isSenderPlatformUser ? "platform user" : "non platform user";
format = format.replace("[Name]", personal);
format = format.replace("[Email]", address);
calendarPart.setContent(vCalData, "text/calendar; charset=UTF-8; method=REQUEST");
DataSource ds = new ByteArrayDataSource(fileHtml.getBytes("UTF8"), "text/html; charset=UTF-8", fileName);
int idx = body.lastIndexOf("</body");
return "No email address provided.";
return "No email domain address provided.";
static private String[] topDomains = {"aol", "comcast", "gmail", "hotmail", "live", "mac", "verizon", "yahoo"};
String email = emailPrefix + (bounce ? "+bounce+" : "+email+") + returnIdentifier + "@" + emailDomain;
String email = emailPrefix + (bounce ? "+bounce+" : "+email+") + returnIdentifier + "@" + emailDomain;
ret.setBounce("bounce".equals(m.group(1)));
if (autoSubmittedHeaders != null && autoSubmittedHeaders[0].equalsIgnoreCase("no")) {
String[] precedenceHeader = message.getHeader("Precedence");
if (autoResponseSuppressHeader != null && autoResponseSuppressHeader[0].equalsIgnoreCase("All")) {
private static final String[] failPhrases = {"delivery status notification (failure)", "undeliverable", "failed email report", "message delivery failure", "delivery failure", "delivery has failed", "returned mail"};
private static final String[] failPhrases = {"delivery status notification (failure)", "undeliverable", "failed email report", "message delivery failure", "delivery failure", "delivery has failed", "returned mail"};
private static final String[] failPhrases = {"delivery status notification (failure)", "undeliverable", "failed email report", "message delivery failure", "delivery failure", "delivery has failed", "returned mail"};
private static final String[] failPhrases = {"delivery status notification (failure)", "undeliverable", "failed email report", "message delivery failure", "delivery failure", "delivery has failed", "returned mail"};
private static final String[] failPhrases = {"delivery status notification (failure)", "undeliverable", "failed email report", "message delivery failure", "delivery failure", "delivery has failed", "returned mail"};
private static final String[] failPhrases = {"delivery status notification (failure)", "undeliverable", "failed email report", "message delivery failure", "delivery failure", "delivery has failed", "returned mail"};
AccessLogThreadStatHelper accessLog = AccessLogThreadStatHelper.newFactory("Send Mails", null, null, null);
appendExtraInfo(info, "Profile IDs", msg.getProfileIds());
ret.addBody(summary.toString(), "text/html; charset=UTF-8");
private static final String[] RECIPIENT_LIST_TYPES = new String[] {"Person", "Submittal", "Profile9"};
pb.getCampaignCategories().put(-1L, "\u2014 All \u2014");
pb.getCampaignCategories().put(-1L, "\u2014 All \u2014");
return isSuccess ? "OK" : "Failed to update campaign status.";
return isSuccess ? "OK" : "Failed to update campaign status.";
if (StringUtils.containsIgnoreCase(tabContainer, "EMAIL")) {
expInfo = "After 1 email";
expInfo = "Never";
campaignSearchTemplates.addAll(searchTemplateService.getTemplateInfos(SearchTemplateType.EMAIL_CAMPAIGN_SEARCH, "Person", CurrentUserService.getUserId(), true, false, null));
params.add(new BasicNameValuePair("secret", recaptchaSecret));
params.add(new BasicNameValuePair("response", recaptchaResponse));
throw new EsignatureException("Unable to determine esignature vendor to use");
return buildErrorResponse(Status.INTERNAL_SERVER_ERROR, "Email notification failed to send.");
SavedFilter groupFilters = searchTemplateBo.createFilterTemplate("Person");
currAttributeId = Integer.parseInt(value.replaceAll("[^\\d]", ""));
private static final String UNSUPPORTED_PROFILE_TYPE_ERROR = "Unsupported profile type found.";
SUPPORTED_PROFILE_TYPES.add("Person");
private static final String VENDOR_STRING = "vendor";
throw EsignatureValidationException.isBlankField("request body");
throw new EsignatureException("Failed to save or update esignature configuration", e);
throw new EsignatureException("Failed to delete esignature configuration", e);
throw new EsignatureCompanyNotFoundException("Failed to find esignature company configuration");
throw new EsignatureCompanyNotFoundException("Failed to find esignature configuration");
map.add("File", new ByteArrayResource(file));
throw new EsignatureConfigException("JSON for Adobe Sign configuration is not valid", e);
AdobeSignRestUtil restUtil = new AdobeSignRestUtil("send transient document", restTemplate);
AdobeSignRestUtil restUtil = new AdobeSignRestUtil("send agreement", restTemplate);
AdobeSignRestUtil restUtil = new AdobeSignRestUtil("get signing url info", restTemplate);
AdobeSignRestUtil restUtil = new AdobeSignRestUtil("get agreement info", restTemplate);
AdobeSignRestUtil restUtil = new AdobeSignRestUtil("put agreement state change", restTemplate);
AdobeSignRestUtil restUtil = new AdobeSignRestUtil("put agreement postSignOption", restTemplate);
AdobeSignRestUtil restUtil = new AdobeSignRestUtil("download combined document", restTemplate);
AdobeSignRestUtil restUtil = new AdobeSignRestUtil("get base uri", restTemplate);
AdobeSignRestUtil restUtil = new AdobeSignRestUtil("refresh access token", restTemplate);
throw new EsignatureException("No signer information returned from adobesign");
throw new EsignatureApiException("Document not in desired status", null);
throw new EsignatureApiException("Document never left indicated status", null);
throw new EsignatureDocumentNotReadyForDownloadException("AdobeSign document cannot be downloaded while still in draft state");
throw EsignatureValidationException.isNullField("Document DTO");
throw EsignatureValidationException.isBlankField("Document name");
throw EsignatureValidationException.isNullField("Document body");
throw EsignatureValidationException.isNullField("Icims ID");
throw EsignatureValidationException.isBlankField("Icims Company ID");
throw EsignatureValidationException.isNullField("Void DTO");
throw EsignatureValidationException.isBlankField("Void Reason");
throw EsignatureValidationException.isBlankField("Signer email");
SIGNATURE("signature"), INITIAL("initial"), DATE("date");
SIGNATURE("signature"), INITIAL("initial"), DATE("date");
SIGNATURE("signature"), INITIAL("initial"), DATE("date");
throw new EsignatureApiException("Invalid URL for microservice", e);
String targetPath = "provision";
headers.set("Accept", MediaType.APPLICATION_JSON_VALUE);
headers.set("Authorization", jwtToken.getAuthorizationHeader());
headers.set("Accept", MediaType.APPLICATION_JSON_VALUE);
headers.set("Authorization", jwtToken.getAuthorizationHeader());
String targetPath = String.format("configuration/%s", vendor.toString());
throw new EsignatureApiException("Error generating document URL for esignature microservice", e);
throw new EsignatureApiException("Error generating polling URL for esignature microservice", e);
private static final String AUTHENTICATION_METHOD = "password";
throw new EsignatureAuthenticationException("Unable to find available token");
throw new EsignatureAuthenticationException("Failed to obtain oAuth token from docusign");
throw new EsignatureAuthenticationException("IO Exception occurred while trying to get a JWT token", e);
throw new EsignatureAuthenticationException("API Exception occurred while trying to get a JWT Token", e);
throw new EsignatureAuthenticationException("Error getting Account Info", e);
throw new EsignatureAuthenticationException("Unkown exception occured getting access token from docusign", e);
() -> new EsignatureAuthenticationException("DocuSign account not found in user info"));
throw new EsignatureAuthenticationException("Error getting Account Info", e);
return String.format("%s/restapi", baseUri);
throw new EsignatureException("Failed to save or update docusign configuration", e);
throw new EsignatureException("Docusign configuration not found");
throw EsignatureValidationException.isNullField("Document XML");
CREATED("created", EsignatureDocumentStatus.UPLOADED, false), //
SENT("sent", EsignatureDocumentStatus.SENT, true), //
DELIVERED("delivered", EsignatureDocumentStatus.REVIEWED, true), //
SIGNED("signed", EsignatureDocumentStatus.SIGNED, false), //
COMPLETED("completed", EsignatureDocumentStatus.SIGNED, true), //
DECLINED("declined", EsignatureDocumentStatus.DECLINED, true), //
VOIDED("voided", EsignatureDocumentStatus.VOIDED, true);
throw EsignatureValidationException.isInvalidField("Document Status");
throw new EsignatureConfigException("Platform URL", e);
throw EsignatureValidationException.isInvalidField("Document is invalid");
throw EsignatureValidationException.isNullField("Document DTO");
throw EsignatureValidationException.isBlankField("Document name");
throw EsignatureValidationException.isNullField("Document body");
throw EsignatureValidationException.isNullField("Icims ID");
throw EsignatureValidationException.isBlankField("Icims Company ID");
throw EsignatureValidationException.isBlankField("Signer email");
throw EsignatureValidationException.isBlankField("Signer name");
throw EsignatureValidationException.isBlankField("Signer id");
throw EsignatureValidationException.isBlankField("Signer redirect");
throw EsignatureValidationException.isNullField("Integrator Key");
throw EsignatureValidationException.isNullField("User Id");
throw EsignatureValidationException.isNullField("Configuration");
throw EsignatureValidationException.isNullField("Account Id");
throw EsignatureValidationException.isNullField("Public Key");
throw EsignatureValidationException.isInvalidField("Public Key");
throw EsignatureValidationException.isInvalidField("Private Key");
throw new EsignatureApiException("Docusign Create Envelope Exception", e);
throw new EsignatureApiException("Docusign Void Envelope Exception", e);
throw new EsignatureApiException("Docusign Signing Url Exception", e);
throw new EsignatureApiException("Docusign Download Document Exception", e);
throw new EsignatureApiException("Docusign Get Status Updates Exception", e);
throw new EsignatureJWTSException("An error occurred while extracting iCIMS GUID from JWTS", e);
throw new EsignatureJWTSException("Could not extract company from JWTS");
super(String.format("%s is not properly configured", message), cause);
super("Esignature Document Not Found");
return new EsignatureValidationException(String.format("%s cannot be blank", invalidField));
return new EsignatureValidationException(String.format("%s cannot be null", invalidField));
return new EsignatureValidationException(String.format("%s is an invalid format for a URL", invalidValue));
return new EsignatureValidationException(String.format("%s is invalid", invalidValue));
throw new EsignatureJWTSException(String.format("%s algorithm not valid", ALGORITHM_STRING), e);
throw new EsignatureJWTSException("UTF-8 encoding is not valid", e);
TOKEN_TYPE("TYPE"), //
TOKEN_VERSION("VERSION"), //
PLATFORM("PLATFORM"), //
ROLES("ROLES"), //
private static final String JWT_SECTION_FORMAT = "[^,$\\s\\.]*";
private static final String HEADER_TOKEN_FORMAT = String.format("(?:JWT|Bearer) (%s\\.%s\\.%s)", JWT_SECTION_FORMAT, JWT_SECTION_FORMAT, JWT_SECTION_FORMAT);
SPA_VERSION("tasuite-core-navigator-spa-version", Variation.of("legacy"), TaSuiteContextStrategy.ID);
return (currentUser.getRegulatoryCountry() == null) ? "US" : postalCountryDao.getCountryById(currentUser.getRegulatoryCountry());
String key = "forms.inputtypes.checkbox" + "." + (isChecked ? "" : "no") + "checkhtml";
String key = "forms.inputtypes.checkbox" + "." + (isChecked ? "" : "no") + "checkhtml";
if (StringUtils.startsWith(temp, "updated") || StringUtils.startsWith(temp, "created") || StringUtils.startsWith(temp, "origclient")) {
if (StringUtils.startsWith(temp, "updated") || StringUtils.startsWith(temp, "created") || StringUtils.startsWith(temp, "origclient")) {
WEB(0, "web"), HTM(1, "htm"), DOC(2, "doc"), TXT(4, "txt"), XMLDOC(5, "xmldoc");
DateTimeFormatter parser = DateTimeFormat.forPattern("MM/dd/yy");
int i = header.toLowerCase().indexOf("</head");
Assert.notEmpty(profiles, "You must include profiles when getPublicByFormNamesAndProfiles.");
if (formName.startsWith("Packet:")) {
if (formName.startsWith("Packet:")) {
reservedNames.add("owner");
reservedNames.add("status");
String key = "forms.inputtypes.checkbox." + (isChecked ? "" : "no") + "checkhtml";
String key = "forms.inputtypes.checkbox." + (isChecked ? "" : "no") + "checkhtml";
searchEngineBO.scheduleFullSearchEngineReset("FormService", "delete", messageService.getMessage("formserviceimpl.java.FormWasDeleted_1211"));
if (name.startsWith("Packet:")) {
return "OK";
if (StringUtils.isNotBlank(map.get("listPropKey")) && ("presql".equals(propKey) || "list".equals(propKey))) {
prop.setValue(def != null ? def.getParentDependantDropdown() : "Parent will match SysConfig");
data.setPacketText("One Time");
private static final String[] LIST_YESNO = {"Yes", "No"};
private static final String[] LIST_YESNO = {"Yes", "No"};
private static final String[] LIST_POOR_EXCELLENT = {"Poor", "Fair", "Good", "Excellent"};
private static final String[] LIST_POOR_EXCELLENT = {"Poor", "Fair", "Good", "Excellent"};
private static final String[] LIST_POOR_EXCELLENT = {"Poor", "Fair", "Good", "Excellent"};
private static final String[] LIST_POOR_EXCELLENT = {"Poor", "Fair", "Good", "Excellent"};
private static final String[] LIST_SOURCE_DEVICE = {"Desktop", "Mobile"};
private static final String[] LIST_SOURCE_DEVICE = {"Desktop", "Mobile"};
static final String VALUE = "value";
completedBy.put(new JSONObject().put("id", userId).put("value", messageService.getMessage("appformadapter.java.Myself_1")));
completedBy.put(new JSONObject().put("id", p.getId()).put("value", p.getName()));
type = "htm".equalsIgnoreCase(view) ? "view" : "download";
type = "htm".equalsIgnoreCase(view) ? "view" : "download";
boolean isNew = "new".equals(request.getParameter("cmd"));
pb.addHashedUrl("web", "icims2?module=AppForm&action=previewForm");
output.setTypeName("Form");
String sections = token.getAllEditableSections().toString().replaceAll("\\[|\\]", "").replace("@default", "Main");
private static final String ENTRY = "entry";
return "Prepopulate with Profile Link Field";
String title = "Generate Full Text Snapshots";
blockedFunctions.add("TODAY");
blockedFunctions.add("NOW");
throw new FSMException("Invalid state transition");
return (Long)createHQLQuery(query).setLong("sequence", sequence).uniqueResult();
CREATED(0, "created"), //
STARTED(1, "started"), //
COMPLETED(-1, "completed");
VISIBILITY(2, "visibility"), //
CORRECTION(3, "correction"), //
PORTABILITY(4, "portability"), //
OBJECTION(5, "objection"), //
DELETION(6, "deletion"), //
DateTimeFormatter formatter = DateTimeFormat.forPattern("yyyy-MM-dd hh:mm a");
if (type == null) errors.add("type");
if (person == null) errors.add("person");
if (portal == null) errors.add("portal");
public static final String back = "BACK";
public static final String history = "HISTORY";
public static final String edit = "EDIT";
public static final String share = "SHARE";
public static final String copy = "COPY";
public static final String upload = "UPLOAD";
public static final String save = "SAVE";
public static final String send = "SEND";
glyphButton.setOnclick("ICIMS.removeClass(document.querySelector('.transitionWrapper'), 'slide-in'); document.querySelector('.transitionWrapper').className += ' slide-in-reverse';");
glyphButton.setOnclick("if (typeof(appendCancelUrl) != 'undefined') appendCancelUrl(this);");
glyphButton.setOnclick("if (typeof(appendCancelUrl) != 'undefined') appendCancelUrl(this);");
usaCan.add("USA");
usaCan.add("CAN");
if (StringUtils.equals(countryCode, "BRA") || StringUtils.equals(countryCode, "FRA") || StringUtils.equals(countryCode, "GUF") || StringUtils.equals(countryCode, "GLP") || StringUtils.equals(countryCode, "MTQ")
} else if (zip.matches("^[A-Z]{1}[\\d]{1}[A-Z]{1} [\\d]{1}[A-Z]{1}[\\d]{1}.*")) {
} else if (zip.matches("^[A-Z][A-Z\\d]{1,3} .*")) { // UK
return coordRadiusBounds(ret.getDouble("latitude"), ret.getDouble("longitude"), radius, units);
truncZip = zip.replaceAll("[^\\d ]", "");
truncZip = zip.replaceAll("[^\\d]", "");
countryAbv3 = "USA";
return coordRadiusBounds(ret.getDouble("latitude"), ret.getDouble("longitude"), radius, units);
TITLE("title"), //
DESCRIPTION("description"), //
BUTTON("button"); //
prefix = "unifi";
content.setVerificationMethod("FILE");
private static final String BLURB_METRICS = "metrics";
private static final String FIELD_DATA_DATA = "data";
private static final String FIELD_DATA_OWNER = "owner";
if (isDirty && !StringUtils.contains(entityName, "History") && shouldHistoricallyTrack(entityFd)) {
String error = String.format("FormAnswer (%s) was found without a FormData before it. Historical data may not be in sync!", event.id);
String error = String.format("FormAnswer (%s) was found with FormData (%s) when FormData (%s) was expected. Historical data may not be in sync!", event.id, parentFormData, lastFormData);
pb.setTitle("ERROR - invalid type");
pb.setDbType("Job");
pb.setDbType("Person");
Assert.hasText(currentTabInternalName, "The current tab's internal name is invalid");
private static final String FIELD_PREFIX = "field,";
private static final String PRIMITIVE_COLLECTION_PREFIX = "primitive,";
private static final String COLLECTION_PREFIX = "collection,";
Assert.hasText(flagTableName, "Flag table name is null");
Assert.hasText(flagTableName, "Flag Table Name is invalid");
String entityName = collectionHistory.getEntityName().replace("History", "");
throw new Exception("ERROR: Trying to save NULL or empty string themeName!");
throw new Exception("ERROR: Trying to delete NULL or empty string themeName!");
return Response.ok(getJSONFromObject("rule", rulesService.getRuleById(ruleId))).build();
JSONObject successPayload = new JSONObject().put("result", "saved").put("RuleSet", apiUrlService.buildUri(RulesResource.class, "getRuleSet", result.get("RuleSetId")).toString()).put("result", result);
JSONObject successPayload = new JSONObject().put("result", "saved").put("RuleSet", apiUrlService.buildUri(RulesResource.class, "getRuleSet", result.get("RuleSetId")).toString()).put("result", result);
JSONObject successPayload = new JSONObject().put("result", "saved").put("RuleSet", apiUrlService.buildUri(RulesResource.class, "getRuleSet", result.get("RuleSetId")).toString()).put("result", result);
JSONObject errorPayload = new JSONObject().put("result", "error").put("error", error);
private static final String EXECUTING_PROPERTY_KEY_DATAUPDATER = "Executing Property Key (SQL) DataUpdater...";
protected static final String RESET_LISTS_MESSAGE = "Resetting XML lists prior to running Data Updater...";
protected static final String RESET_DEFAULTS_MESSAGE = "Resetting defaults prior to running Data Updater...";
return "Unknown";
private static final String PARALLEL = "Parallel";
private static final String NESTED = "Thread";
private static final String DEPENDENCY = "Depends";
private static final String ON = "on";
private static final String TYPE = "type";
private static final String RESOURCE = "resource";
private static final String EXECUTING_PARALLEL_SQL_DATAUPDATER = "Executing Parallel SQL DataUpdater...";
private static final String EXECUTING_PARALLEL_JAVA_DATAUPDATER = "Executing Parallel Java DataUpdater...";
private static final String EXECUTING_SEQUENTIAL_SQL_DATAUPDATER = "Executing SQL DataUpdater...";
private static final String EXECUTING_SEQUENTIAL_JAVA_DATAUPDATER = "Executing Java DataUpdater...";
InitializationLog.end("Resetting Procedures", PeriodType.time());
InitializationLog.end("Resetting Indexes", PeriodType.time());
public static final String approvalOk = "ok";
throw new Exception("Account Locked");
throw new Exception("Account Locked");
throw new Exception("Invalid Username or Password.");
} else if ("Account Locked".equals(e.getMessage())) {
event.setData("comments", comments.toString());
StringBuilder error = new StringBuilder("CSRF Token Error.");
return "FAILED: Cobertura data file location not defined. You must set the JVM system property \"net.sourceforge.cobertura.datafile\"";
if (adminSSO && !Config.getBooleanProperty("login.sso.admin.enable")) return "SSO Not Enabled.";
if (!adminSSO && Config.getIntProperty("login.sso.enable") <= 0) return "SSO Not Enabled.";
if (Config.getIntProperty("login.sso.enable") <= 0) return "SSO Not Enabled.";
if (Config.getIntProperty("login.sso.enable") != 2) return "SAML SSO Not Enabled.";
if (Config.getIntProperty("login.sso.enable") != 2) return "SAML SSO Not Enabled.";
return "Failure";
return "Failure";
return "OK";
jgen.writeBooleanField("read", lastRevision.isRead());
jgen.writeStringField("title", lastRevision.getTitle());
jgen.writeStringField("description", lastRevision.getDescription());
jgen.writeObjectFieldStart("category");
jgen.writeObjectField("label", categoryNode.getDisplayValue());
jgen.writeBooleanField("archived", lastRevision.isArchived());
FilterProvider apiFilters = new SimpleFilterProvider().addFilter("filter properties by name", SimpleBeanPropertyFilter.serializeAllExcept("text", "params"));
jgen.writeBooleanField("write", lastRevision.isWrite());
jgen.writeBooleanField("delete", lastRevision.isDelete());
jgen.writeBooleanField("archived", lastRevision.isArchived());
jgen.writeBooleanField("archived", offer.isArchived());
jgen.writeStringField("status", lastStatus.getStatus().getDisplayValue());
DOWNLOAD(new DeliveryTypeBuilder(1, "download").hideFromCandidatePortal().autoExtend()), //
PORTAL(new DeliveryTypeBuilder(2, "portal").requireEmail().autoExtend()), //
EMAIL(new DeliveryTypeBuilder(3, "email").requireEmail().hideInOfferWizard().hideFromCandidatePortal()), //
jgen.writeStringField("value", variable.getValue());
jgen.writeStringField("label", detail.getLabel());
"jgen.writeStringField(""field"", variable.getSearchSchema());	// TODO: Remove(deprecated)"
jgen.writeBooleanField("default", detail.isDefaultFlag());
jgen.writeStringField("type", detail.getDetailType().getDisplayValue());
jgen.writeNumberField("offset", expiration.getOffset());
jgen.writeStringField("unit", expiration.getUnit());
jgen.writeStringField("status", expiration.getStatus().getDisplayValue());
jgen.writeNumberField("time", expiration.getTime());
jgen.writeStringField("timezone", expiration.getTimezone());
jgen.writeBooleanField("read", lastRevision.isRead());
jgen.writeBooleanField("write", lastRevision.isWrite());
jgen.writeBooleanField("delete", lastRevision.isDelete());
jgen.writeBooleanField("archived", lastRevision.isArchived());
jgen.writeStringField("status", status.getStatus().getDisplayValue());
DRAFT(new Builder(1, "draft").makeActive().makeEditable()), //

GroupListNode categoryNode = BeanLocatorHelper.getBean(ListNodeService.class).getById("lists.offer.template.categories", lastRevision.getCategory());
jgen.writeBooleanField("trashed", lastRevision.isTrashed());
}
jgen.writeBooleanField("read", lastRevision.isRead());
jgen.writeBooleanField("write", lastRevision.isWrite());
jgen.writeBooleanField("delete", lastRevision.isDelete());
jgen.writeBooleanField("archived", lastRevision.isArchived());
USER(1, "User"), //
USERGROUP(2, "User Group"), //
UNKNOWN(Integer.MIN_VALUE, "Unknown");
private static final String ARCHIVED = "archived";
.addEntity("o", "Offer") //
static final String CATEGORY_NOT_NULL = "category should not be null";
static final String CLAUSE_ID_NOT_NULL = "clause ID should not be null";
static final String ENTITY_NOT_NULL = "entity should not be null";
static final String TEMPLATE_ID_NOT_NULL = "template id should not be null";
static final String PERMISSION_ID_NOT_NULL = "permission id should not be null";
static final String PERSON_ID_NOT_NULL = "person id should not be null";
static final String OFFER_ID_NOT_NULL = "offer id should not be null";
static final String ARCHIVED = "archived";
static final String CATEGORY = "category";
pb.addHashedUrl("wizard", "icims2?module=AppOfferWizardAdapter&action=showOfferWizard");
pb.addHashedUrl("wizard", "icims2?module=AppOfferWizardAdapter&action=showOfferWizard&submittalId=" + submittalId);
static final String FIELD_NOT_FOUND = "association not found";
static final String JOB_NOT_FOUND = "job not found";
static final String EXISTS = "exists";
static final String FAILURES = "failures";
static final String INCOMPLETE = "incomplete";
return new OfferAssociationServiceResult<>(true, "List of Offer Template Associated",  templateIds);
return new OfferServiceResult<>("found", jobAssociations);
return new OfferServiceResult<>("get", getAssociationSearchResults(templateId, ignoreLocks).size());
String associating = "associating";
static final String ARCHIVED = "archived";
static final String TRASHED = "trashed";
static final String RESTORED = "restored";
static final String EMAIL = "email";
static final String CATEGORY = "category";
static final String DESCRIPTION = "description";
static final String TITLE = "title";
static final String WRITE_PERMISSION = "write";
static final String READ_PERMISSION = "read";
static final String DELETE_PERMISSION = "delete";
static final String RESULTS = "results";
static final String QUERY = "query";
static final String EXISTS = "exists";
static final String NO_APPROVAL = "no approval";
static final String NO_OFFER = "no offer";
static final String NOT_IN_DRAFT = "not in draft";
static final String FAILED_TO_SAVE = "failed to save offer";
static final String FAILED_TO_READ_BACK = "failed to read back offer";
static final String NOT_IN_APPROVAL_PENDING = "not in approval pending";
static final String FAILED_TO_NOTIFY = "failed to notify";
static final String APPROVAL_EXCEPTION = "approval exception";
static final String GET_OFFER_EXCEPTION = "get offer exception";
static final String FAILED_TO_ACKNOWLEDGE = "failed to acknowledge";
static final String NOT_FOUND = "not found";
static final String READ = "read";
static final String RELATION = "relation";
return getSuccessReturn("resent to approver");
private static final String OFFER_GET_EXCEPTION_ERROR = "get offer exception";
private static final String OFFER_NOT_FOUND_ERROR = "no offer";
private static final String PERSON = "Person";
private static final String JOB = "Job"; // for field schema
private static final String RECIPIENT = "Recipient"; // for variable schema
private static final String OFFER = "Offer"; // for variable schema
if ("Recipient Form URL".equals(varType)) {
} else if ("AppFlow Form URL".equals(varType)) {
static final String NO_JOBID= "no jobId";
static final String NO_JOB = "no job";
static final String NO_FIELD = "field not found";
static final String NO_OFFER_TEMPLATE_ASSOCIATED="no offer template associated";
return getSuccessReturn("created", jsonAdapter.convertFromObject(offerClausePermission));
return getErrorReturn("No permissions for offer template", ErrorCode.INTERNAL_ERROR, Status.BAD_REQUEST, logger);
return getSuccessReturn(archivedFlag ? ARCHIVED : "updated", jsonAdapter.convertFromObject(offerClausePermission));
return getSuccessReturn("read", jsonarray);
return getSuccessReturn("deleted", jsonAdapter.convertFromObject(offerClausePermission));
return getSuccessReturn("created", jsonAdapter.convertFromObject(clause));
return getSuccessReturn("updated", jsonAdapter.convertFromObject(clause));
return getSuccessReturn("archived", jsonAdapter.convertFromObject(clause));
return getSuccessReturn("read", jsonAdapter.convertFromObject(clause));
return getSuccessReturn("deleted", jsonAdapter.convertFromObject(clause));
{"title", "offerclauseresourcecommon.java.Offer.Clause.title"}, //
private static final String EXCEPTION = "Exception";
JSONObject responsePayload = new JSONObject().put("result", "updated").put(OFFER_ID, offerId).put("data", jsonPermissions);
"status", offer.getCurrentStatus().getStatus().getDisplayValue());
JSONObject responsePayload = new JSONObject().put(RESULT, "updated").put(OFFERID, offerId).put(DATA, jsonDetails);
offer.setPdf(signed ? "signed" : "true");
return signed ? "signed".equals(offer.getPdf()) : StringUtils.isNotBlank(offer.getPdf());
return watermarkText.replace("{{name}}", candidateName)
.replace("{{email}}", candidateEmail)
private static final String OFFSET = "offset";
private static final String UNIT = "unit";
private static final String STATUS = "status";
private static final String TIME = "time";
return getSuccessReturn("read", jsonAdapter.convertFromObject(expiration));
private static final String TIMEZONE = "timezone";
return getSuccessReturn("created", jsonAdapter.convertFromObject(expiration));
return getSuccessReturn("deleted", expirationJson);
return getSuccessReturn("updated", jsonAdapter.convertFromObject(expiration));
private static final String EXCEPTION = "Exception";
JSONObject responsePayload = new JSONObject().put("result", "updated").put(TEMPLATE_ID, templateId).put("data", jsonPermissions);
JSONObject responsePayload = new JSONObject().put("result", "updated").put(TEMPLATE_ID, templateId).put("data", jsonPermissions);
JSONObject responsePayload = new JSONObject().put("result", "updated").put(TEMPLATE_ID, templateId).put("data", jsonPermissions);
return getSuccessReturn("read", jsonarray);
return getSuccessReturn("offer template user permission", returnPermissions);
JSONObject responsePayload = new JSONObject().put("result", "updated").put(OFFER_ID, offerId).put("data", jsonPermissions);
JSONObject responsePayload = new JSONObject().put("result", "updated").put(OFFER_ID, offerId).put("data", jsonPermissions);
return getSuccessReturn("read", jsonarray);
return getSuccessReturn("offer user permission", returnPermissions);
JSONObject successPayload = new JSONObject().put("result", result);
{"title", "offerresourcecommon.java.Offer.title"}};
private static final String EXCEPTION_CAUGHT_DURING_ENCODING = "Exception caught during encoding";
ErrorCode.FIELD_REQUIRED, Status.BAD_REQUEST, logger, ex, "query", query);
ErrorCode.FIELD_REQUIRED, Status.BAD_REQUEST, logger, ex, "filter", filter);
request.addParameter("take", String.valueOf(pageSize));
request.addParameter("sort[0][field]", sort.get("field").toString());
request.addParameter("sort[0][dir]", sort.get("direction").toString());
String prefix = "filter[filters]";
request.addParameter("skip", String.valueOf((pageNumber - 1) * pageSize));
request.addParameter("page", String.valueOf(pageNumber));
request.addParameter("skip", String.valueOf(0));
request.addParameter("page", String.valueOf(0));
private static final String FAILED_TO_SAVE = "failed to save";
private static final String NO_OFFER_FOUND = "No offer found";
private static final String EMAIL_EXCEPTION = "email exception";
private static final String NO_EMAIL_FOR_OFFER = "no email for offer";
private static final String NO_EMAIL_REFERENCED = "no email referenced";
return new OfferServiceResult<>(false, "unauthorized");
return new OfferServiceResult<>(false, "invalid status");
return new OfferServiceResult<>("rescinded", offer);
return new OfferServiceResult<>(false, "unauthorized");
return new OfferServiceResult<>(archive ? "archived" : "restored", offer);
return new OfferServiceResult<>(archive ? "archived" : "restored", offer);
return new OfferServiceResult<>(false, "invalid status");
return new OfferServiceResult<>(archive ? "archived" : "restored", offer);
return new OfferServiceResult<>(archive ? "archived" : "restored", offer);
return new OfferServiceResult(false, "email template not found");
return new OfferServiceResult(false, "offer does not have a status");
return new OfferServiceResult<>("notified");
return new OfferServiceResult<>(false, "unsupported status");
return new OfferServiceResult(false, "email template not found");
return new OfferServiceResult<>(false, "exception sending email");
return new OfferServiceResult<>("notified");
return new OfferServiceResult<>(false, "no delivery type");
return new OfferServiceResult<>("no send");
return new OfferServiceResult<>(false, "offer has no status");
return new OfferServiceResult<>(false, "offer not in pending status");
return new OfferServiceResult<>(false, "exception sending email");
return new OfferServiceResult<>("sent");
return new OfferServiceResult<>(true, "Offer can auto-extend");
return new OfferServiceResult<>(false, "Offer cannot auto-extend");
result = new OfferServiceResult<>(true, "Offer HTML generated", pdf);
version = "version"; // if this is a dev environment, we want the folder path to remain as version
return new OfferServiceResult<>(false, "not portal delivery type");
return new OfferServiceResult<>("cancel");
static final String GET_EXCEPTION = "exception caught getting offer";
static final String NO_OFFER = "no offer";
static final String UNKNOWN = "unknown";
static final String NOT_FOUND = "not found";
static final String OFFER_EXCEPTION = "offer exception";
static final String BAD_EMAIL = "bad email reference";
static final String ALREADY_SENT = "email already send";
static final String GET = "get";
static final String DISABLED = "disabled";
static final String EXISTS = "exists";
static final String CREATED = "created";
static final String UNCHANGED = "unchanged";
static final String NOT_FOUND = "not found";
static final String UPDATED = "updated";
static final String READ = "read";
static final String LABEL = "label";
private static final int MAX_TITLE_LENGTH = 1000;
offerTemplatePermissionRevision.setModifiedDate(null); // first created is not modified yet
revisionNew.setCategory(categoryNodeID);

if (templateId == null) {
{"title", "offertemplateresourcecommon.java.Offer.Template.title"}};
result = new OfferServiceResult<>(false, "Offer template thumbnail returned is empty.");
result = new OfferServiceResult<>(true, "Offer template thumbnail generated", thumbnail);
throw new EsignatureException("Unable to get offer object", e);
throw new EsignatureException("No Offer Object available");
throw new EsignatureException("Unable to get offer object", e);
throw new EsignatureException("No Offer Object available");
throw new EsignatureException("Unable to save offer object", e);
throw new EsignatureException("Unable to get offer document object", e);
throw new EsignatureException("No PDF available for upload");
throw new EsignatureException("Unable to build webhook url for esignature integraton", e);
throw new EsignatureException("Esignature authentication failed", eae);
voidDTO.setVoidReason("Rescind Offer");
private static final String ACCEPT = "accept";
DateTimeFormatter formatter = DateTimeFormat.forPattern("yyyy-MM-dd hh:mm a");
ACTIVE("ob-item-active active", "onboard.task.status.active"), //
DateTimeFormatter formatter = DateTimeFormat.forPattern("yyyy-MM-dd hh:mm a");
DateTimeFormatter dateTimeFormatter = DateTimeFormat.forPattern("yyyy-MM-dd hh:mm a");
DateTimeFormatter dateTimeFormatter = DateTimeFormat.forPattern("yyyy-MM-dd hh:mm a");
DateTimeFormatter dateTimeFormatter = DateTimeFormat.forPattern("yyyy-MM-dd hh:mm a");
DateTimeFormatter dateTimeFormatter = DateTimeFormat.forPattern("yyyy-MM-dd hh:mm a");
throw new PortalUserException("This form type is not supported on this Portal", PortalException.INVALID_DATA);
requestUtilWrapper.setSessionAttribute(pageContextWrapper.getRequest(), "expanded", expanded);
SIGNATURE("signature"), //
throw new ValueType.MappingException(String.format("Unknown question input type %s", question.getInputType()));
SALARY("salary"), //
final DateTimeFormatter formatter = DateTimeFormat.forPattern("yyyy-MM-dd hh:mm a");
DataStepBuilder response = DataStepBuilder.create().id("portals-adapters-questions-" + (jobId == null ? "people" : jobId));
type.getOptions().put("items", items);
type.getOptions().put("items", listEditorDropdownItems);
mapNumericOption(type, "min", tag.getParameter("min"));
mapNumericOption(type, "max", tag.getParameter("max"));
mapNumericOption(type, "min", tag.getParameter("min"));
mapNumericOption(type, "max", tag.getParameter("max"));
mapNumericOption(type, "min", tag.getParameter("min"));
mapNumericOption(type, "max", tag.getParameter("max"));
INTEGER("integer"), //
UNKNOWN("unknown");
BREAK("break"), //
COLLECTION("collection"), //
INPUTS("inputs"), //
UNKNOWN("unknown");
private static final String VALUE_TYPE_MISMATCH_MSG = "Value '%s' does not match type %s";
private static final DateTimeFormatter DATE_TIME_FORMATTER = DateTimeFormat.forPattern("yyyy-MM-dd hh:mm a");
COLLECTION("collection"), //
DECIMAL("decimal"), //
FILE("file"), //
INTEGER("integer"), //
MONEY("money"), //
throw new PermissionException("Per Job Source is not configured to be asked.");
super("Portal not found");
throw new InternalServerErrorException("Unable to store screening answers", e);
protected static final String MAPPING_TYPE = "mapping";
"title", messageService.getMessage("appportaljobsearchadminadapter.java.portaljobsearchfieldsadmin.fields.mapping.title.label") //
"description", messageService.getMessage("appportaljobsearchadminadapter.java.portaljobsearchfieldsadmin.fields.mapping.description.label") //
PORTAL(5, "Portal"), //
WEB(1, "Web Post"), //
VENDOR(2, "Vendor"), //
JOB_VIPER(1001, "Job Viper"), //
JWTEZPOST(1002, "Easy Post"), //
UNKNOWN(0, "Unknown");
DESCRIPTION("description", "$T{Job}.$T{JobContent3035}.$F{Content}", true, true, false), //
RESPONSIBILITIES("responsibilities", "$T{Job}.$T{JobContent3036}.$F{Content}", false, false, false), //
TITLE("title", "$T{Job}.$F{JobTitle}", true, true, false), //
QUALIFICATIONS("qualifications", "$T{Job}.$T{JobContent3037}.$F{Content}", false, false, false), //
DEPARTMENT("department", "$T{Job}.$T{JobContent3108}.$F{ContentListNode}", false, false, true), //
BENEFITS("benefits", "???", false, false, true), //
COUNTRY("country", "$T{Job}.$T{JobLocation}.$F{Country}", false, false, true), //
STREET("street", "$T{Job}.$T{JobLocation}.$F{Street}", false, false, false), //
CITY("city", "$T{Job}.$T{JobLocation}.$F{City}", false, false, true), //
PROVINCE("province", "$T{Job}.$T{JobLocation}.$F{State}", false, false, true), //
LIVE(100, "Live"), EXPIRED(200, "Expired"), POSTING_IN_PROCESS(300, "Posting in Process"), DELETION_IN_PROCESS(400, "Deletion in Process"), //
LIVE(100, "Live"), EXPIRED(200, "Expired"), POSTING_IN_PROCESS(300, "Posting in Process"), DELETION_IN_PROCESS(400, "Deletion in Process"), //
LIVE(100, "Live"), EXPIRED(200, "Expired"), POSTING_IN_PROCESS(300, "Posting in Process"), DELETION_IN_PROCESS(400, "Deletion in Process"), //
LIVE(100, "Live"), EXPIRED(200, "Expired"), POSTING_IN_PROCESS(300, "Posting in Process"), DELETION_IN_PROCESS(400, "Deletion in Process"), //
UNPOSTED(500, "Unposted"), UNKNOWN(999, "Unknown");
UNPOSTED(500, "Unposted"), UNKNOWN(999, "Unknown");
return "New";
return "Posted";
return "Sent";
return "Failed";
return "Canceled";
return "Unknown";
return createHQLQuery(CDC_FIND_JOB_POST_BOARD_LOG_BY_SEQUENCE_RANGE).setLong("begin", begin).setLong("end", end).setMaxResults(maxResults).list();
return createHQLQuery(CDC_FIND_JOB_POST_BOARD_LOG_BY_SEQUENCE_RANGE).setLong("begin", begin).setLong("end", end).setMaxResults(maxResults).list();
return (Long)createHQLQuery(CDC_COUNT_JOB_POST_BOARD_LOG_BYSEQUENCE_RANGE).setLong("begin", begin).uniqueResult();
"j.statusId in (:jobStatusIds)";
return createHQLQuery(CDC_FIND_JOB_POST_LOG_BY_SEQUENCE_RANGE).setLong("begin", begin).setLong("end", end).setMaxResults(maxResults).list();
return createHQLQuery(CDC_FIND_JOB_POST_LOG_BY_SEQUENCE_RANGE).setLong("begin", begin).setLong("end", end).setMaxResults(maxResults).list();
return (Long)createHQLQuery(CDC_COUNT_JOB_POST_LOG_EVENTS_AFTER_GIVEN_SEQUENCE_NUMBER).setLong("begin", begin).uniqueResult();
errors.add(new JobPostError(ErrorCode.REQUEST_INVALID, "portal is not allowed to be posted"));
errors.add(new JobPostError(ErrorCode.REQUEST_INVALID, "user is not allowed to post to portal"));
errors.add(new JobPostError(ErrorCode.REQUEST_INVALID, "Job is already posted to the portal"));
errors.add(new JobPostError(ErrorCode.REQUEST_INVALID, "user is not allowed to post to portal"));
errors.add(new JobPostError(ErrorCode.REQUEST_INVALID, "Job is not posted to the portal"));
@Path("unpost")
JobPostError jpError = new JobPostError(ErrorCode.INVALID_FORMAT, "Error on translating from JSON to JobBoardInfo");
result.addError(new JobPostError(ErrorCode.REQUEST_INVALID, "Job is already posted to the Job Distributor"));
errors.add(new JobPostError(ErrorCode.REQUEST_INVALID, "portal is not allowed to be posted"));
errors.add(new JobPostError(ErrorCode.REQUEST_INVALID, "portal is not allowed to be redirected for job boards posting"));
errors.add(new JobPostError(ErrorCode.REQUEST_INVALID, "user is not allowed to post to portal"));
errors.add(new JobPostError(ErrorCode.REQUEST_INVALID, "user is not allowed to post to web (job boards)"));
errors.add(new JobPostError(ErrorCode.REQUEST_INVALID, "Job is not posted to the Job Distributor"));
builder.link(new LinkHeader(uriSelf, LinkRelation.SELF, "JobPost created"));
@Path("unpost")
builder.link(new LinkHeader(uriSelf, LinkRelation.SELF, "Job Unposted"));
PROFILE("Company", "Profile");
PROFILE("Company", "Profile");
private static final Set<String> ENTITY_NAMES = Collections.unmodifiableSet(Sets.newHashSet("Person", "Education", "PhoneOfPerson", "AddressOfPerson", "CandidateInfo", "EmployeeInfo", "HiringManagerInfo", "Login"));
private static final Set<String> ENTITY_NAMES = Collections.unmodifiableSet(Sets.newHashSet("Person", "Education", "PhoneOfPerson", "AddressOfPerson", "CandidateInfo", "EmployeeInfo", "HiringManagerInfo", "Login"));
private static final Set<String> ENTITY_NAMES = Collections.unmodifiableSet(Sets.newHashSet("Person", "Education", "PhoneOfPerson", "AddressOfPerson", "CandidateInfo", "EmployeeInfo", "HiringManagerInfo", "Login"));
return "Profiles";
String dateMatch = "[DATE:";
return "[No Hiring Manager]";
return "[No Owner]";
return "[No Company]";
systemAccounts.add("support");
PERSON(1, "Person"), //
PORTAL(5, "Portal"), //
.setString("email", email) //
"order by title.Data_Text1 asc";
"order by title.Data_Text1 asc";
Assert.notEmpty(historicalIds, "historicalIds must not be empty");
Assert.notEmpty(historicalIds, "historicalIds must not be empty");
Assert.notEmpty(definitions, "definitions must not be empty");
Assert.hasText(fieldEntityName, "fieldEntityName must contain text; it must not be null, empty, or blank");
Assert.hasText(fieldEntityName, "fieldEntityName must contain text; it must not be null, empty, or blank");
Assert.hasText(fieldEntityName, "fieldEntityName must contain text; it must not be null, empty, or blank");
StringBuilder sqlBuilder = new StringBuilder("select MAX(batchOfMsns.MessageSequence), COUNT(*) AS numberOfUpdates from (");
return createHQLQuery(makeCDCRangeQuery(profileDefinitionType)).setLong("begin", begin).setLong("end", end).setMaxResults(maxResults).list();
return createHQLQuery(makeCDCRangeQuery(profileDefinitionType)).setLong("begin", begin).setLong("end", end).setMaxResults(maxResults).list();
return (Long)createHQLQuery(makeCDCCountQuery(profileDefinitionType)).setLong("begin", begin).uniqueResult();
return createReadOnlySQLQuery(sql).addEntity("j", "Job").setParameter("talentPoolId", talentPool.getId()).list();
if (temp.contains("HOME") || temp.charAt(0) == 'H') {
} else if (temp.contains("WORK") || temp.contains("OFFICE") || temp.charAt(0) == 'W' || temp.charAt(0) == 'O') {
} else if (temp.contains("WORK") || temp.contains("OFFICE") || temp.charAt(0) == 'W' || temp.charAt(0) == 'O') {
} else if (temp.contains("EMERGENCY") || temp.charAt(0) == 'E') {
private static final String JOB_ENTITY_NAME = "Job";
"order by isDefault desc, phoneTypeId asc, phoneNumber asc, extension asc, id desc";
"order by isDefault desc, phoneTypeId asc, phoneNumber asc, extension asc, id desc";
Query query = createHQLQuery(makeCDCCountRangeQuery(profileDefinitionType)).setLong("sequence", begin);
private static final String LABEL = "label";
String loginName = "fulladmin".equals(logingroup) ? "admin" : "support";
String support = "support";
Objects.requireNonNull(workflow, "Workflow cannot be null");
Objects.requireNonNull(person, "Person cannot be null");
return StringUtils.defaultString(this.getFile().getWholeFilename(), "File") + (StringUtils.isNotBlank(this.getFile().getText()) ? " [" + this.getFile().getText() + "]" : "");
private static final String HIST_ENTITY_POSTFIX = "History";
private static final String HIST_ENTITY_POSTFIX = "History";
addError("global", key, messageService.getMessage("sourcechannelslistvalidator.java.AppSourcetypedeffriendlyn_1049", Collections.singletonMap("sourceTypeDefFriendlyName", sourceTypeDef.getFriendlyName())));
return personGroupService.getAllChildrenByGroupNickName("recruiter", null).contains(personId);
ret.put("Opt Out", "Opt Out");
if ((e instanceof DuplicateProfileException) || (cause != null && cause.getMessage() != null && cause.getMessage().indexOf("duplicate") > -1)) {
if ("Previous Search".equalsIgnoreCase(template.getTitle())) continue;
ret.put("Opt Out", "Opt Out");
output.setTypeName("Person");
if (temp.contains("HOME") || temp.charAt(0) == 'H') {
} else if (temp.contains("WORK") || temp.contains("OFFICE") || temp.charAt(0) == 'W' || temp.charAt(0) == 'O') {
} else if (temp.contains("WORK") || temp.contains("OFFICE") || temp.charAt(0) == 'W' || temp.charAt(0) == 'O') {
} else if (temp.contains("MOBILE") || temp.contains("CELL") || temp.charAt(0) == 'M' || temp.charAt(0) == 'C') {
} else if (temp.contains("MOBILE") || temp.contains("CELL") || temp.charAt(0) == 'M' || temp.charAt(0) == 'C') {
} else if (temp.contains("PAGER") || temp.contains("BEEPER") || temp.charAt(0) == 'B') {
private static final String TAB_GROUP = "Tab Group";
searchEngineBo.scheduleFullSearchEngineReset("AppAdmin", "reset", "Search Engine Reset Scheduled.");
searchEngineBo.scheduleFullSearchEngineReset("AppAdmin", "reset", "Search Engine Reset Scheduled.");
addError("global", key, messageService.getMessage("sourcechannelslistvalidator.java.VendorSourcetypedeffriend_1048", Collections.singletonMap("sourceTypeDefFriendlyName", sourceTypeDef.getFriendlyName())));
return "Initial Data Transfer Thread";
return "Profiles";
private static final String DATALOAD_ACTION = "action";
ResourceResponseBuilder builder = ResourceResponseBuilder.create(Status.OK).link(new LinkHeader(uriSelf, LinkRelation.SELF, "The status for the current request"));
searchEngineService.scheduleFullSearchEngineReset("AppEvent", "saveRule", "Event was saved");
if (initialDataLoadStatus.getStatusText().equals("KILLED")) {
new MBeanAttributeInfo("channelCount", "java.lang.int", "total number of channels", true, false, false), //
new MBeanAttributeInfo("activeIDLCount", "java.lang.int", "active initial data transfers", true, false, false), //
new MBeanAttributeInfo("customerMessagesProduced", "java.lang.long", "total number of consumer messages sent", true, false, false), //
String dDescription = "Streaming API Monitoring";
dConstructors[0] = new MBeanConstructorInfo("ProfileSyncDynamicMBeanImpl(): No-parameter constructor", constructors[0]);
private static final String CONFIG_ERROR = "Configuration Error";
formatListNodeSelection("lists.school", "school", education.getSchool(), jsonObject);
formatListNodeSelection("lists.school.degree", "degree", education.getDegree(), jsonObject);
formatListNodeSelection("lists.school.major", "major", education.getMajor(), jsonObject);
formatObject("entry", education.getId(), jsonObject);
formatObject("minor", education.getMinor(), jsonObject);
formatObject("rank", education.getRank(), jsonObject);
formatObject("entry", phone.getId(), jsonObject);
formatObject("entry", address.getId(), jsonObject);
return new CollectionLinkField().name(fieldName).scope(getCustomerID()).id(companyId).collection("addresses").entryId(addressId).kind(companyApiName);
DateTimeFormatter formatter = DateTimeFormat.forPattern("yyyy-MM-dd hh:mm a");
"allowed to be run at a time. Please try again in a few minutes.";
private static final String SEEK_FAILED = "An error ocurred while attempting to seek to the given offset.";
errors.put("Error retrieving updates, empty channel");
return "Offline";
return "Pending";
return "Replay";
return "Update";
this.customerName = "Unit Testing Customr";
return "OK";
return "OK";
return "OK";
return "OK";
return "OK";
return "OK";
private static final String DISABLE_ACTION = "action";
private static final String DISABLE_VALUE = "disable";
private static final String ENABLE_VALUE = "enable";
links.put(new JSONObject().put("rel", "updates").put("href", apiUrlService.buildUri(ProfileUpdatesResource.class, "pollForProfileUpdates", channelId)));
links.put(new JSONObject().put("rel", "current").put("href", apiUrlService.buildUri(ProfileSyncResource.class, "currentProfiles", channelId)));
protected static final String ERROR_KEY_UNKNOWN = "unknown";
if (!("next".equalsIgnoreCase(type) || "prev".equalsIgnoreCase(type) || (StringUtils.isNotBlank(tab)))) {
table.addRow(json, "email", messageService.getMessage("appprofileedit.java.Email_563"));
table.addRow("Type", addressType);
table.addRow("Type", phoneType);
JSONObject school = education.optJSONObject("school");
table.addRow(school, "value", messageService.getMessage("appprofileedit.java.School_573"));
table.addRow(education, "degree", messageService.getMessage("appprofileedit.java.Degree_574"));
table.addRow(education, "major", messageService.getMessage("appprofileedit.java.Major_575"));
table.addRow(education, "minor", messageService.getMessage("appprofileedit.java.Minor_576"));
table.addRow(education, "city", messageService.getMessage("appprofileedit.java.City_578"));
table.addRow(education, "state", messageService.getMessage("appprofileedit.java.State_579"));
table.addRow(education, "country", messageService.getMessage("appprofileedit.java.Country_580"));
table.addRow(job, "workstate", messageService.getMessage("appprofileedit.java.State_588"));
if (StringUtils.equalsIgnoreCase("Room", fieldName)) {
boolean isContract = "contract".equalsIgnoreCase(subtype);
boolean isRetained = "retained".equalsIgnoreCase(subtype);
String mode = request.getParameter("mode") == null ? "tab" : request.getParameter("mode").toLowerCase();
return "Bad JobID";
return "OK";
return "OK";
return "TRUE";
return "FALSE";
return "OK";
private static final String JOB_PROGRESS_STATUS_SUCCESS = "Success";
private static final String JOB_PROGRESS_STATUS_NEUTRAL = "Neutral";
private final String[] dataContainerFields = new String[] {"addresses", "location", "phones", "email", "hiringManager", "recruiter", "owner", "primaryRep"};
private final String[] dataContainerFields = new String[] {"addresses", "location", "phones", "email", "hiringManager", "recruiter", "owner", "primaryRep"};
private static final String JOB_PROGRESS_STATUS_FAIL = "Fail";
private final String[] dataContainerFields = new String[] {"addresses", "location", "phones", "email", "hiringManager", "recruiter", "owner", "primaryRep"};
private final String[] dataContainerFields = new String[] {"addresses", "location", "phones", "email", "hiringManager", "recruiter", "owner", "primaryRep"};
private final String[] dataContainerFields = new String[] {"addresses", "location", "phones", "email", "hiringManager", "recruiter", "owner", "primaryRep"};
private final String[] dataContainerFields = new String[] {"addresses", "location", "phones", "email", "hiringManager", "recruiter", "owner", "primaryRep"};
if (personGroupService.isUserGroupMember(CurrentUserService.getUserId(), "vendor")) {
newReader.getSearchEngineReaderInfo().setTab("Workflow Profile");
boolean emailField = "email".equals(dataContainerField);
newReader.getSearchEngineReaderInfo().setTab("Workflow Profile");
("default".equals(forcedSetting) || //
(!"legacy".equals(forcedSetting) && "default".equals(Config.getProperty("icims.config.profile.viewtype"))));
(!"legacy".equals(forcedSetting) && "default".equals(Config.getProperty("icims.config.profile.viewtype"))));
String queryString = "&type=platform&validate=none";
boolean fullScreen = ("full".equals(request.getParameter("screen")) ? true : false);
return new PanelData("On", false, true);
if (StringUtils.contains(classes, "modal")) {
GlyphButton upload = pageBeanGlyphButtonsBuilder.upload(glyphButtons, "Upload Resume", getMessageService().getMessage("resumepagebean.java.UploadResume_593"),
if (node == null || !"replacing".equalsIgnoreCase(node.getAttributeValue(ListAttributeDefinition.TYPE))) {
fields.getField(ProfileFieldDefinition.JOB_REPLACING).setHidden(node == null || !"replacing".equalsIgnoreCase(node.getAttributeValue(ListAttributeDefinition.TYPE)));
boolean contract = "contract".equalsIgnoreCase(nodeType);
boolean retained = "retained".equalsIgnoreCase(nodeType);
pageBeanGlyphButtonsBuilder.history(glyphButtons, Config.getBooleanProperty("icims.features.gold.history_logger.job.enable"), "Job");
ACTIVITY(1, "activity"), TAGS(2, "tags"), UNKNOWN(-1, "unknown");
ACTIVITY(1, "activity"), TAGS(2, "tags"), UNKNOWN(-1, "unknown");
ACTIVITY(1, "activity"), TAGS(2, "tags"), UNKNOWN(-1, "unknown");
if (hideEEO) fields.get("CandProfileFields.Age").setHidden(!StringUtils.isEmpty(age) && !"Opt Out".equals(age));
if (hideEEO) fields.get("CandProfileFields.Disability").setHidden(!StringUtils.isEmpty(disability) && !"Opt Out".equals(disability));
if (hideEEO) fields.get("CandProfileFields.Gender").setHidden(!StringUtils.isEmpty(gender) && !"Opt Out".equals(gender));
if (hideEEO) fields.get("CandProfileFields.Nationality").setHidden(!StringUtils.isEmpty(nationality) && !"Opt Out".equals(nationality));
if (hideEEO) fields.get("CandProfileFields.Origin").setHidden(!StringUtils.isEmpty(origin) && !"Opt Out".equals(origin));
if (hideEEO) fields.get("CandProfileFields.Race").setHidden(!StringUtils.isEmpty(race) && !"Opt Out".equals(race));
if (hideEEO) fields.get("CandProfileFields.Religion").setHidden(!StringUtils.isEmpty(religion) && !"Opt Out".equals(religion));
if (hideEEO) fields.get("CandProfileFields.Veteran").setHidden(!StringUtils.isEmpty(veteran) && !"Opt Out".equals(veteran));
pageBeanGlyphButtonsBuilder.history(glyphButtons, contactTab && Config.getBooleanProperty("icims.features.gold.history_logger.cand_emp.enable"), "Person");
boolean currentUserIsInAgencyUserGroup = personGroupService.isUserGroupMember(currentUserId, "vendor");
MODERN(0, "modern", true, false), //
MODERNFALLBACK(1, "modern", true, true), //
FULL_SCREEN(1, "full"), SPLIT_SCREEN(2, "half"), UNKNOWN(-1, "unknown");
FULL_SCREEN(1, "full"), SPLIT_SCREEN(2, "half"), UNKNOWN(-1, "unknown");
FULL_SCREEN(1, "full"), SPLIT_SCREEN(2, "half"), UNKNOWN(-1, "unknown");
String profileType = isAddress ? "address" : profile;
output.setTypeName("Person");
private static final String STATUS_LABEL = "status";
private static final String STATUS_LABEL = "status";
return Response.ok(new JSONObject().put("label", label)).build();
return "Client";
return "Person";
CONTACT(0, "contact"), //
MANAGER(3, "client"), //
return "Contact";
return "Candidate";
return "Employee";
String countryFieldName = stateFieldName.substring(0, stateFieldName.indexOf("state")) + "country";
static final String CONTENT_MD5_ERROR = "The content's computed MD5 digest did not match the one provided in the header.";
builder.response(file.getText().getBytes("UTF8"), file.getFilename() + ".txt", "text/plain; charset=utf-8");
private static final String SOURCE_LABEL = "source";
private static final String STATUS_LABEL = "status";
if (people.size() > 2000) return ResourceResponseBuilder.create(Status.NOT_ACCEPTABLE).response(new JSONObject("{\"error\": \"List of PersonIDs should be less than or equal to 2000\"}")).build();
NO_DEFAULT_SELECTION(1, "Field Group"), DEFAULT_SELECTION(2, "Field Group (With Default Selection)"), RATING(3, "Rating");
NO_DEFAULT_SELECTION(1, "Field Group"), DEFAULT_SELECTION(2, "Field Group (With Default Selection)"), RATING(3, "Rating");
NO_DEFAULT_SELECTION(1, "Field Group"), DEFAULT_SELECTION(2, "Field Group (With Default Selection)"), RATING(3, "Rating");
PLATFORM("platform", "platformProfile", 0L, "Platform"), //
PLATFORM("platform", "platformProfile", 0L, "Platform"), //
REFERRAL("referral", "portalReferral", 30002L, "Portal (Recruit - Referral)"), //
REFERRAL("referral", "portalReferral", 30002L, "Portal (Recruit - Referral)"), //
ONBOARD("onboard", "onboardProfile", 30004L, "Portal (Onboard)"), //
CONNECT("connect", "connectProfile", 30005L, "Portal (Connect)"), //
CONNECT("connect", "connectProfile", 30005L, "Portal (Connect)"), //
PORTAL("candidate", "portalProfile", 30001L, "Portal (Recruit - Candidate)"), //
PORTAL("candidate", "portalProfile", 30001L, "Portal (Recruit - Candidate)"), //
PORTAL_SUBMITTAL("portalSubmittal", "portalSubmittal", 30003L, "Portal (Recruit - Candidate) - Submittal");
GroupListNode node = "Profile".equals(fieldName) ? groupNode : GroupListSearch.findFirstByAttribute(groupNode, ListAttributeDefinition.VALUE, fieldName);
EDIT("edit"), ADD_NEW("addNew"), LABEL("label"), HIDDEN("hidden"), REQUIRED("required"), READ_ONLY("readOnly"), FULL_TEXT_INDEXING("fullTextIndexing"), MOVE("move");
EDIT("edit"), ADD_NEW("addNew"), LABEL("label"), HIDDEN("hidden"), REQUIRED("required"), READ_ONLY("readOnly"), FULL_TEXT_INDEXING("fullTextIndexing"), MOVE("move");
EDIT("edit"), ADD_NEW("addNew"), LABEL("label"), HIDDEN("hidden"), REQUIRED("required"), READ_ONLY("readOnly"), FULL_TEXT_INDEXING("fullTextIndexing"), MOVE("move");
EDIT("edit"), ADD_NEW("addNew"), LABEL("label"), HIDDEN("hidden"), REQUIRED("required"), READ_ONLY("readOnly"), FULL_TEXT_INDEXING("fullTextIndexing"), MOVE("move");
LOCKED("locked"), UNLOCKED("unlocked"), UNKNOWN(null);
LOCKED("locked"), UNLOCKED("unlocked"), UNKNOWN(null);
private static final String CLIENT_ROLE = "client";
currentUserIsInAgencyUserGroup = personGroupService.isUserGroupMember(currentUserId, "vendor");
private static final String TAB = "TAB";
private static final String PANEL = "PANEL";
ret.setFriendlyName(flagTableUtilsService.lookupFlagtableLabel(ret.getFieldFlagsGroupName(), "Profile"));
ret.setFriendlyName(flagTableUtilsService.lookupFlagtableLabel(ret.getFieldFlagsGroupName(), "Profile"));
ret.setFriendlyName(flagTableUtilsService.lookupFlagtableLabel(ret.getFieldFlagsGroupName(), "Profile"));
ret.setFriendlyName(flagTableUtilsService.lookupFlagtableLabel(ret.getFieldFlagsGroupName(), "Profile"));
if (internalName.startsWith("TAB")) {
} else if (internalName.startsWith("PANEL")) {
return "Person";
return "Job";
return "Company";
profileDefinitionTranslator.addToError(ret, "The tab you selected holds panels only. You must provide a panelLabel.");
private static final String UN_SUPPORTED_ENDPOINT = "This end point is deprecated and can be removed or changed at any time.";
return profileDefinitionTranslator.addToError(new JSONObject(), "getProfileFieldDefinition requires non null parameters only");
return missingAttribute("systemId or id");
profileDefinitionTranslator.addToError(ret, "GroupListNode not found.");
profileDefinitionTranslator.addToError(ret, "showForSelf no longer supported");
profileDefinitionTranslator.addToError(ret, "no modifications detected");
return ResourceResponseBuilder.create(Status.BAD_REQUEST).response(profileDefinitionTranslator.addToError(ret, "JSONException occurred")).build();
if (!profileDef.getInternalName().equals("contact")) return false;
if (fieldName.contains("resume") || fieldName.contains("coverletter") || fieldName.contains("referrercommentstoreferral")) {
if (!(profilePage.equals("candidate") || profilePage.equals("referral")//
if (!(profilePage.equals("candidate") || profilePage.equals("referral")//
|| profilePage.equals("onboard") || profilePage.equals("connect"))) {
profileDefinitionTranslator.setBooleanAttributeValue("required", payload, ret, pdrn);
profileDefinitionTranslator.addToError(ret, "You must either provide a sectionLabel to move to a new section in the current tab or a tabLabel and sectionLabel to move to a section in a different tab.");
profileDefinitionTranslator.addToError(ret, "The tab name that you entered does not exist.");
profileDefinitionTranslator.addToError(ret, "Cannot move a field within a field group into another section or tab.");
profileDefinitionTranslator.addToError(ret, "listnode is null");
profileDefinitionTranslator.addToError(ret, "a json exception occurred");
private static final String FIELD = "field";
if (def.getTabContainerDefinition().getInternalName().startsWith("TAB")) {
if (StringUtils.equals(node.getAttributeValue(ListAttributeDefinition.PROFILE_PANEL_TYPE, userId, true), "fields")) {
temp = groupListSearchService.findFirstByAttribute(node, ListAttributeDefinition.PROFILE_SECTION_TYPE, "unlocked", userId, false);
return "Tab Panel";
private static final String INVALID_PARAMETER_WITH_FORCE = "The parameter {%s} is not in the DataDescriptor list. Add the parameter to an array called force if you are completely sure it is a valid parameter.";
if (minStr != null && min == null) errors.put("The parameter, {min}, must be a number.");
if (maxStr != null && max == null) errors.put("The parameter, {max}, must be a number.");
errors.put("The parameter, {sensitive}, must be a number.");
errors.put("The parameter, {sensitive}, must be 0 or 1.");
errors.put("The parameter, {min}, should not be greater than {max}.");
errors.put("The parameter, {profileLinkType}, must refer to a profile that is custom, non-workflow, and visible.");
errors.put("JSONException while validating parameter values.");
addToError(payload, "JSONException while checking required.");
section.setFriendlyName("Bulk");
section.setFriendlyName("Bulk");
addToError(error, "The given profileLinkType is not a valid profile name.");
return "Yes";
return "No";
return "Same as Profile";
EXPIRY("EXPIRY"), //
if ("linkedin".equals(type)) {
if (e.getMessage().startsWith("Error: JWT token expired.")) {
profileDefinitionTranslator.addToError(ret, "These Candidate, Employee, and HM (Client) roles only apply to the PersonProfileFields type.");
profileDefinitionTranslator.addToError(ret, "JSONException encountered while setting hidden attribute.");
profileDefinitionTranslator.addToError(ret, "The hidden attribute can only be set if the profileDef is a custom profile.");
profileDefinitionTranslator.addToError(ret, "The label cannot be blank.");
profileDefinitionTranslator.addToError(ret, "JSONException encountered while setting readonly attribute.");
profileDefinitionTranslator.addToError(ret, "This field is not full text indexable.");
profileDefinitionTranslator.addToError(ret, "Valid entries for {fullTextIndexing} are 0 for Off, 1 for Keyword Search, and 2 for Keyword and Quick Search.");
profileDefinitionTranslator.addToError(ret, "None of your changes were saved due to the validation errors. Please resolve them and then try again.");
profileDefinitionTranslator.addToError(ret, "No changes have been made.");
return ResourceResponseBuilder.create(Status.BAD_REQUEST).response(profileDefinitionTranslator.addToError(new JSONObject(), "You must include what you are creating. ?create=field ?create=section ?create=tab")).build();
profileDefinitionTranslator.addToError(ret, "showForSelf no longer supported");
return ResourceResponseBuilder.create(Status.BAD_REQUEST).response(profileDefinitionTranslator.addToError(new JSONObject(), "You must include a tabLabel and sectionLabel when creating a section.")).build();
profileDefinitionTranslator.addToError(ret, "There was a JSONException while creating a new section.");
profileDefinitionTranslator.addToError(ret, "You have not included all of the required fields.  You must specify a field label.");
profileDefinitionTranslator.addToError(ret, "You have not included all of the required fields. You must specify a field type id.");
profileDefinitionTranslator.addToError(ret, "You have not included all of the required fields. You must specify a field location (tab & section, or field group).");
profileDefinitionTranslator.addToError(ret, "You cannot add a field group to a field group.");
Boolean required = profileDefinitionTranslator.booleanAttribute(field, ret, "required");
profileDefinitionTranslator.addToError(ret, "That is not a valid custom field type for a child field under a field group.");
profileDefinitionTranslator.addToError(ret, "That is not a valid custom field type.");
profileDefinitionTranslator.addToError(ret, "Invalid type. typeId must be an integer. eg. \"1\" or 1");
profileDefinitionTranslator.addToError(ret, "You have not included all of the required parameters. Please refer to the documentation or UI for required fields.");
profileDefinitionTranslator.addToError(ret, "Since errors were detected during parameter validation, the field was not created.");
profileDefinitionTranslator.addToError(ret, "Could not find that tab label.");
profileDefinitionTranslator.addToError(ret, "You specified a tab of panels but did not specify a panelLabel.");
profileDefinitionTranslator.addToError(ret, "Could not find that panel label.");
profileDefinitionTranslator.addToError(ret, "Could not find that section label.");
profileDefinitionTranslator.addToError(ret, "Could not find that section label.");
profileDefinitionTranslator.addToError(ret, "You cannot add fields to standard field groups.");
profileDefinitionTranslator.addToError(ret, "Could not find that field group.");
profileDefinitionTranslator.addToError(ret, "There was a JSON error.");
profileDefinitionTranslator.addToError(ret, "There was a JSON error.");
return ResourceResponseBuilder.create(Status.PRECONDITION_FAILED).response(profileDefinitionTranslator.addToError(new JSONObject(), "You must include confirmDelete=true as a query parameter in the url.")).build();
if (fieldName.endsWith("resume") && (profileDef.getInternalName().equalsIgnoreCase("contact"))) fieldFlagsName = "PortalProfileFields.Resume";
if (fieldName.endsWith("resume") && (profileDef.getInternalName().equalsIgnoreCase("contact"))) fieldFlagsName = "PortalProfileFields.Resume";
if (fieldName.endsWith("coverletter") && (profileDef.getInternalName().equalsIgnoreCase("contact"))) fieldFlagsName = "PortalProfileFields.CoverLetter";
if (fieldName.endsWith("referrercommentsToreferral") && (profileDef.getInternalName().equalsIgnoreCase("contact"))) fieldFlagsName = "PortalProfileFields.ReferrerCommentsToReferral";
return new JSONObject().put(itemType, "That entry does not exist");
extensions.add("tiff");
throw new ProviderException("Attempt to contact the Provider failed.");
" " + StringUtils.defaultString(response.getError(), StringUtils.defaultString(response.getResults(), "Problem contacting server.")));
uri.addParameter("hashed", hashedParam);
return "Unable to retrieve JSON request.";
JSONObject jsonWrappedForTinyMCE = new JSONObject().put("result", spellCheckResponse);
} else if ("image/svg+xml".equals(type)) {
response.sendError(500, "Service Not Available");
response.sendError(500, "Service Not Available");
response.sendError(500, "Service Not Available");
response.sendError(500, "Service Not Available");
String requestInfo = String.format("proxy %s uri: %s -- %s", method, request.getRequestURI(), proxyRequest.getRequestLine().getUri());
return (StringUtils.containsIgnoreCase(se.getMessage(), "connection reset"));
return "!Proxy!UXService";
String[] headers = new String[] {"Connection", "Keep-Alive", "Proxy-Authenticate", "Proxy-Authorization", "TE", "Trailers", "Transfer-Encoding", "Upgrade"};
String[] headers = new String[] {"Connection", "Keep-Alive", "Proxy-Authenticate", "Proxy-Authorization", "TE", "Trailers", "Transfer-Encoding", "Upgrade"};
String[] headers = new String[] {"Connection", "Keep-Alive", "Proxy-Authenticate", "Proxy-Authorization", "TE", "Trailers", "Transfer-Encoding", "Upgrade"};
String[] headers = new String[] {"Connection", "Keep-Alive", "Proxy-Authenticate", "Proxy-Authorization", "TE", "Trailers", "Transfer-Encoding", "Upgrade"};
Preconditions.checkArgument(keepAliveDurationInMillis >= 10000L, "Keep-Alive duration cannot be less than 10000 millis");
Preconditions.checkArgument(keepAliveDurationInMillis <= 60000L, "Keep-Alive duration cannot be greater than 60000 millis");
String moduleActionUrlFragment = "module=AppReverseProxy&action=forwardRequest";
Preconditions.checkArgument(intervalInMillis >= 5000L, "Monitor Interval cannot be less than 5000 millis");
Preconditions.checkArgument(intervalInMillis <= 60000L, "Monitor interval cannot be greater than 60000 millis");
Preconditions.checkArgument(idleTimeoutInMillis >= 10000L, "Idle timeout cannot be less than 10000 millis");
Preconditions.checkArgument(idleTimeoutInMillis <= 60000L, "Idle timeout cannot be greater than 60000 millis");
BLANK(" ", " ", 0), LESS_THAN("<", "Less than", 1), LESS_THAN_OR_EQUAL("<=", "Less than or equal to", 2), EQUALS("=", "Equal to", 3), NOT_EQUALS("!=", "Not equal to", 4), GREATER_THAN_OR_EQUAL(">=", "Greater than or equal to", 5), GREATER_THAN(
BLANK(" ", " ", 0), LESS_THAN("<", "Less than", 1), LESS_THAN_OR_EQUAL("<=", "Less than or equal to", 2), EQUALS("=", "Equal to", 3), NOT_EQUALS("!=", "Not equal to", 4), GREATER_THAN_OR_EQUAL(">=", "Greater than or equal to", 5), GREATER_THAN(
BLANK(" ", " ", 0), LESS_THAN("<", "Less than", 1), LESS_THAN_OR_EQUAL("<=", "Less than or equal to", 2), EQUALS("=", "Equal to", 3), NOT_EQUALS("!=", "Not equal to", 4), GREATER_THAN_OR_EQUAL(">=", "Greater than or equal to", 5), GREATER_THAN(
BLANK(" ", " ", 0), LESS_THAN("<", "Less than", 1), LESS_THAN_OR_EQUAL("<=", "Less than or equal to", 2), EQUALS("=", "Equal to", 3), NOT_EQUALS("!=", "Not equal to", 4), GREATER_THAN_OR_EQUAL(">=", "Greater than or equal to", 5), GREATER_THAN(
BLANK(" ", " ", 0), LESS_THAN("<", "Less than", 1), LESS_THAN_OR_EQUAL("<=", "Less than or equal to", 2), EQUALS("=", "Equal to", 3), NOT_EQUALS("!=", "Not equal to", 4), GREATER_THAN_OR_EQUAL(">=", "Greater than or equal to", 5), GREATER_THAN(
">", "Greater than", 6);
LIBRARY_MANAGEMENT("library"), PERSON("person"), JOB_SPECIFIC("job"), LIBRARY_ASSOCIATION("associate");
LIBRARY_MANAGEMENT("library"), PERSON("person"), JOB_SPECIFIC("job"), LIBRARY_ASSOCIATION("associate");
LIBRARY_MANAGEMENT("library"), PERSON("person"), JOB_SPECIFIC("job"), LIBRARY_ASSOCIATION("associate");
LIBRARY_MANAGEMENT("library"), PERSON("person"), JOB_SPECIFIC("job"), LIBRARY_ASSOCIATION("associate");
return "Job Specific";
Collections.singletonMap("task", Lists.newArrayList("create", "read", "update"));
Collections.singletonMap("task", Lists.newArrayList("create", "read", "update"));
Collections.singletonMap("task", Lists.newArrayList("create", "read", "update"));
Collections.singletonMap("task", Lists.newArrayList("create", "read", "update"));
answerText = "No";
answerText = "Yes";
DataTable dataTable = questionDataTableManager.startEditSession("person");
boolean required = "on".equalsIgnoreCase(request.getParameter("required"));
boolean hidden = "on".equalsIgnoreCase(request.getParameter("hidden"));
boolean searchable = "on".equalsIgnoreCase(request.getParameter("searchable"));
EditQuestionDNQAndPostedToPageBean.PortalSelection all = new EditQuestionDNQAndPostedToPageBean.PortalSelection(globalPortal.getId(), "\u2014 All \u2014", false, allOptionEnabled);
ProfileField deleteField = helper.createIconField("delete", "16/redx.png", deleteText, null, deleteOnclick);
private static final String ANSWER = "answer";
private static final String WEIGHT = "weight";
SavedSearch search = searchTemplateService.createSearchTemplate("Referral", Collections.emptyMap(), false);
SavedOutput output = searchTemplateService.createOutputTemplate("Referral", REFERRAL_SEARCH_TABLE_COLUMNS, false);
JSONObject json = new JSONObject().put("fields", fields);
dupReturn.putAll(ValidationError.RuleDuplicate.getError(Collections.singletonMap("priority", jsonObject.getLong("priority"))));
RuleValid("valid", "conditional.fields.validation.rule.Ruleisvalid"), //
RuleSetValid("valid", "conditional.fields.validation.ruleset.RuleSetisvalid"), //
ConditionValid("valid", "conditional.fields.validation.condition.Conditionisvalid"), //
ConsequenceValid("valid", "conditional.fields.validation.consequence.Consequenceisvalid"), //
RuleValidator("Rules", new RulesValidator()), //
ConditionValidator("Condition", new ConditionValidator()), //
ConsequenceValidator("Consequence", new ConsequenceValidator());
String subSection = "Amount";
if (!(salary != null && salary.size() == 3 && salary.contains("Amount") && salary.contains("Timeframe") && salary.contains("Currency"))) {
if (!(salary != null && salary.size() == 3 && salary.contains("Amount") && salary.contains("Timeframe") && salary.contains("Currency"))) {
OUTPUT(1, "output");
dupReturn.putAll(ValidationError.RuleSetDuplicate.getError(Collections.singletonMap("priority", priority)));
private static final String RULES_VALIDATOR = "Rules";
private static final String CONDITION_VALIDATOR = "Condition";
private static final String CONSEQUENCE_VALIDATOR = "Consequence";
private static final String VALID = "valid";
private static final String TYPE = "type";
private static final String RULES = "rules";
private static final String OWNER = "owner";
private static final String PRIORITY = "priority";
private static final String DESCRIPTION = "description";
private static final String CONDITIONS = "conditions";
private static final String CONSEQUENCES = "consequences";
validationMap.putAll(ValidationError.ConditionConsequenceSame.getError(Collections.singletonMap("fields", CSVUtil.makeCSV(invalidConditionConsequeces))));
validationMap.putAll(ValidationError.RuleSetMaxError.getError(Collections.singletonMap("max", dynamicConfig.getIntDynamicProperty(null, "icims.config.conditional.field.logic.max.rulesets"))));
final Map<String, Object> map = Collections.singletonMap("max", maxAllowedRules);
validationMap.putAll(ValidationError.DuplicateConditions.getError(Collections.singletonMap("condition", duplicates.toString())));
OUTPUT("output");
private static final DataDescriptor[] descriptor = {new DataDescriptor("lessLabel", "Show Less button label", DataDescriptor.FIELD_TEXT), new DataDescriptor("moreLabel", "Show More button label", DataDescriptor.FIELD_TEXT), //
private static final DataDescriptor[] descriptor = {new DataDescriptor("lessLabel", "Show Less button label", DataDescriptor.FIELD_TEXT), new DataDescriptor("moreLabel", "Show More button label", DataDescriptor.FIELD_TEXT), //
new DataDescriptor("displayName", "Group Name", DataDescriptor.FIELD_TEXT)};
dynamicDescriptors.add(new DataDescriptor("size", "Default # of Groups Displayed", DataDescriptor.FIELD_DROPDOWN, getDropdownNumbers()));
dynamicDescriptors.add(new DataDescriptor("size", "Default # of Groups Displayed", DataDescriptor.FIELD_DROPDOWN, getDropdownNumbers()));
dynamicDescriptors.add(new DataDescriptor("min", "Minimum # of Groups Displayed", DataDescriptor.FIELD_DROPDOWN, getDropdownNumbers()));
dynamicDescriptors.add(new DataDescriptor("min", "Minimum # of Groups Displayed", DataDescriptor.FIELD_DROPDOWN, getDropdownNumbers()));
dynamicDescriptors.add(new DataDescriptor("max", "Maximum # of Groups Displayed", DataDescriptor.FIELD_DROPDOWN, getDropdownNumbers()));
dynamicDescriptors.add(new DataDescriptor("max", "Maximum # of Groups Displayed", DataDescriptor.FIELD_DROPDOWN, getDropdownNumbers()));
dynamicDescriptors.add(new DataDescriptor("CityLink", "City", DataDescriptor.FIELD_DROPDOWN, questionNames));
dynamicDescriptors.add(new DataDescriptor("StateLink", "State", DataDescriptor.FIELD_DROPDOWN, questionNames));
dynamicDescriptors.add(new DataDescriptor("ZipLink", "Zip/Postal Code", DataDescriptor.FIELD_DROPDOWN, questionNames));
dynamicDescriptors.add(new DataDescriptor("CountryLink", "Country", DataDescriptor.FIELD_DROPDOWN, questionNames));
dynamicDescriptors.add(new DataDescriptor("CountyLink", "County", DataDescriptor.FIELD_DROPDOWN, questionNames));
String msg = DynamicConfig.getDynamicProperty(data.getForm().getName(), "forms.messages.complete", "Thanks");
String msg = DynamicConfig.getDynamicProperty(data.getForm().getName(), "forms.messages.complete", "Thanks");
String msg = DynamicConfig.getDynamicProperty(data.getForm().getName(), "forms.messages.printinstructions", "Thanks");
String msg = DynamicConfig.getDynamicProperty(data.getForm().getName(), "forms.messages.complete", "Thanks");
writeParameter(out, "user", String.valueOf(token.getUpdatedBy().getId()));
writeParameter(out, "token", token.getToken());
String ie = BrowserFamily.ie.equals(ua.getBrowserFamily()) ? "iform-ie" : "";
if (param != null && !"user".equalsIgnoreCase(param) && !"token".equalsIgnoreCase(param) && !"password".equalsIgnoreCase(param)) {
if (param != null && !"user".equalsIgnoreCase(param) && !"token".equalsIgnoreCase(param) && !"password".equalsIgnoreCase(param)) {
if (param != null && !"user".equalsIgnoreCase(param) && !"token".equalsIgnoreCase(param) && !"password".equalsIgnoreCase(param)) {
if (name.startsWith("icims") || "override".equals(name) || "override_saved".equals(name)) return;
return ("true".equalsIgnoreCase(booleanString) || "yes".equalsIgnoreCase(booleanString) || "1".equalsIgnoreCase(booleanString));
googleAddress = googleAddress.replaceAll("\\s+", "_");
new DataDescriptor("label", BeanLocatorHelper.getBean(MessageService.class).getMessage("checkbox.java.Label_1"), DataDescriptor.FIELD_TEXT, new String[] {DataDescriptor.SCREENING_QUESTION}), //
printValue(value ? "Yes" : "No", true);
printValue(value ? "Yes" : "No", true);
super("Profile5", true, (allowCompanyCreation ? "Company" : null));
new DataDescriptor("sensitive", BeanLocatorHelper.getBean(MessageService.class).getMessage("datadescriptor.java.SensitiveData_1"), FIELD_ONOFF)//
new DataDescriptor("sensitive", messageService.getMessage("datadescriptor.java.SensitiveData_1"), FIELD_ONOFF)//
new DataDescriptor("month", //
private String ampm = "am";
this.ampm = "pm";
this.ampm = "am";
new DataDescriptor("min", messageService.getMessage("decimalfield.java.MinimumValue_1"), DataDescriptor.FIELD_TEXT), //
new DataDescriptor("max", messageService.getMessage("decimalfield.java.MaximumValue_2"), DataDescriptor.FIELD_TEXT)//
String digits = matcher.group("digits");
ret.setStringArrayValue(new String[] {"Opt Out"});
return containsData(elementName) || "yes".equals(PageContext.getRequest().getParameter("cancel"));
DataDescriptor[] descriptor = {new DataDescriptor("nolink", "Disable Links", DataDescriptor.FIELD_ONOFF)}; // InstanceSafe
new DataDescriptor("allowedFileTypes", "Allowed File Types", DataDescriptor.FIELD_MULTISELECT, generateFileTypesOptions()) //
String fileName = getParameterForMaskedFileField("filename");
String portal = PortalConfig.getBooleanProperty("ccc.onboard.enable") ? "onboard" : "jobs";
super("job", false);
DataDescriptor[] descriptor = {new DataDescriptor(DATA_MIN, "Minimum # of Characters", DataDescriptor.FIELD_TEXT), //
new DataDescriptor(DATA_MAX, "Maximum # of Characters", DataDescriptor.FIELD_TEXT), //
new DataDescriptor(DATA_COLS, "Display Width (Portals and iForms) (pixels)", DataDescriptor.FIELD_TEXT, new String[] {DataDescriptor.IFORM_QUESTION}), //
new DataDescriptor(DATA_ROWS, "Display Height (pixels)", DataDescriptor.FIELD_TEXT, new String[] {DataDescriptor.IFORM_QUESTION})}; // InstanceSafe
new DataDescriptor("nodeid", "List Options", DataDescriptor.FIELD_LISTEDITOR), //
new DataDescriptor("listPropKey", "List Options", DataDescriptor.HIDDEN) //
DataDescriptor[] descriptor = {new DataDescriptor("nodeid", "List Options", DataDescriptor.FIELD_LISTEDITOR), //
new DataDescriptor("listPropKey", "List PropKey", DataDescriptor.HIDDEN), //
new DataDescriptor("listType", "List Type", DataDescriptor.HIDDEN)}; // InstanceSafe
if (StringUtils.isBlank(ext)) throw new IOException("Error: Could not extract file extension for image resizing.");
if (output.size() == 0) throw new IOException("Error: Failed to resize image");
classes.add("hide");
classes.add("disabled");
private static final String COMPANY = "Company";
private static final String PERSON = "Person";
private static final String CONTACT = "contact";
private static final String JOB = "Job";
private static final String APPROVAL = "Approval";
private static final String ROOM = "room";
private final DataDescriptor[] descriptor = {new DataDescriptor("presql", "Multi-Select Dropdown Options", DataDescriptor.FIELD_DROPDOWN, dropDownDataService.getDropDownOptionListNames()), //
new DataDescriptor(DataDescriptor.LIST, "Custom Options (One per line)", DataDescriptor.FIELD_LISTBUILDER), //
new DataDescriptor("size", "Display Height (pixels)", DataDescriptor.FIELD_TEXT)}; // InstanceSafe
new DataDescriptor("size", "Display Height (pixels)", DataDescriptor.FIELD_TEXT)}; // InstanceSafe
new DataDescriptor("listPropKey", "List PropKey", DataDescriptor.HIDDEN), //
new DataDescriptor("listType", "List Type", DataDescriptor.HIDDEN)};
DataDescriptor[] descriptor = {new DataDescriptor(MIN_DESCRIPTOR_KEY, "Minimum Value", DataDescriptor.FIELD_TEXT), new DataDescriptor(MAX_DESCRIPTOR_KEY, "Maximum Value", DataDescriptor.FIELD_TEXT)}; // InstanceSafe
DataDescriptor[] descriptor = {new DataDescriptor(MIN_DESCRIPTOR_KEY, "Minimum Value", DataDescriptor.FIELD_TEXT), new DataDescriptor(MAX_DESCRIPTOR_KEY, "Maximum Value", DataDescriptor.FIELD_TEXT)}; // InstanceSafe
DataDescriptor[] descriptor = {new DataDescriptor("min", "Minimum # of Characters", DataDescriptor.HIDDEN), new DataDescriptor("max", "Maximum # of Characters", DataDescriptor.FIELD_TEXT)}; // InstanceSafe
DataDescriptor[] descriptor = {new DataDescriptor("min", "Minimum # of Characters", DataDescriptor.HIDDEN), new DataDescriptor("max", "Maximum # of Characters", DataDescriptor.FIELD_TEXT)}; // InstanceSafe
DataDescriptor[] descriptor = {new DataDescriptor("min", "Minimum # of Characters", DataDescriptor.HIDDEN), new DataDescriptor("max", "Maximum # of Characters", DataDescriptor.FIELD_TEXT)}; // InstanceSafe
DataDescriptor[] descriptor = {new DataDescriptor("min", "Minimum # of Characters", DataDescriptor.HIDDEN), new DataDescriptor("max", "Maximum # of Characters", DataDescriptor.FIELD_TEXT)}; // InstanceSafe
setInvalidReason("forms.messages.formerror.textfield.undermin", Collections.singletonMap("Min", min));
setInvalidReason("forms.messages.formerror.textfield.overmax", Collections.singletonMap("Max", max));
String fieldLabel = "Password";
String fieldLabel = "Password";
super("contact", false);
new DataDescriptor("validate", messageService.getMessage("textfield.java.Validation_3"), DataDescriptor.FIELD_DROPDOWN, dropDownDataService.getValidationOptions(), new String[] {DataDescriptor.PROFILE_FIELD})}; // InstanceSafe
setInvalidReason("forms.messages.formerror.textbox.undermin", Collections.singletonMap("Min", min));
setInvalidReason("forms.messages.formerror.textbox.overmax", Collections.singletonMap("Max", max));
String groupName = "person".equalsIgnoreCase(profile) ? "PersonProfileFields" : "CompProfileFields";
String profileType = isAddress ? "address" : profile;
new DataDescriptor("min", messageService.getMessage("textfield.java.MinimumNumberOfCharacters_1"), DataDescriptor.FIELD_TEXT), //
new DataDescriptor("max", messageService.getMessage("textfield.java.MaximumNumberOfCharacters_2"), DataDescriptor.FIELD_TEXT), //
new DataDescriptor("name", "Radio Button Group Name", DataDescriptor.FIELD_TEXT), //
new DataDescriptor("checkhtml", "HTML for Checked Box (Default)", DataDescriptor.FIELD_TEXT, new String[] {DataDescriptor.IFORM_QUESTION}), //
new DataDescriptor("nocheckhtml", "HTML for Non-Checked Box (Default)", DataDescriptor.FIELD_TEXT, new String[] {DataDescriptor.IFORM_QUESTION}), //
new DataDescriptor("checkhtmlweb", "HTML for Checked Box (Web View)", DataDescriptor.FIELD_TEXT, new String[] {DataDescriptor.IFORM_QUESTION}), //
new DataDescriptor("nocheckhtmlweb", "HTML for Non-Checked Box (Web View)", DataDescriptor.FIELD_TEXT, new String[] {DataDescriptor.IFORM_QUESTION}), //
new DataDescriptor("checkhtmlhtm", "HTML for Checked Box (HTML View)", DataDescriptor.FIELD_TEXT, new String[] {DataDescriptor.IFORM_QUESTION}), //
new DataDescriptor("nocheckhtmlhtm", "HTML for Non-Checked Box (HTML View)", DataDescriptor.FIELD_TEXT, new String[] {DataDescriptor.IFORM_QUESTION}), //
new DataDescriptor("checkhtmldoc", "HTML for Checked Box (Word View)", DataDescriptor.FIELD_TEXT, new String[] {DataDescriptor.IFORM_QUESTION}), //
new DataDescriptor("nocheckhtmltxt", "HTML for Non-Checked Box (Text View)", DataDescriptor.FIELD_TEXT, new String[] {DataDescriptor.IFORM_QUESTION})}; // InstanceSafe
new DataDescriptor("nocheckhtmldoc", "HTML for Non-Checked Box (Word View)", DataDescriptor.FIELD_TEXT, new String[] {DataDescriptor.IFORM_QUESTION}), //
new DataDescriptor("checkhtmltxt", "HTML for Checked Box (Text View)", DataDescriptor.FIELD_TEXT, new String[] {DataDescriptor.IFORM_QUESTION}), //
private final DataDescriptor[] descriptor = {new DataDescriptor("presql", "Radio Options", DataDescriptor.FIELD_DROPDOWN, dropDownDataService.getDropDownOptionListNames()),
new DataDescriptor(DataDescriptor.LIST, "Custom Options (One per line)", DataDescriptor.FIELD_LISTBUILDER)}; // InstanceSafe
new DataDescriptor("presql", "Radio Options", DataDescriptor.FIELD_DROPDOWN, dropDownDataService.getDropDownOptionListNames()), //
new DataDescriptor("list", "Custom Options (One per line)", DataDescriptor.FIELD_LISTBUILDER)//
new DataDescriptor("list", "Custom Options (One per line)", DataDescriptor.FIELD_LISTBUILDER)//
Object bean = TagHelper.lookup(this.pageContext, "bean");
super.setOnchange("window.document.body.onbeforeunload = null;this.form.action=this.form.action+'&uploadResume=1';this.form.submit();");
private static final String NAME = "\" name=\"";
private static final String STYLE_DISPLAY_INLINE_BLOCK = "style=\"display: inline-block;\"";
new DataDescriptor("validate", messageService.getMessage("textfield.java.Validation_3"), DataDescriptor.FIELD_DROPDOWN, dropDownDataService.getValidationOptions(), new String[] {DataDescriptor.PROFILE_FIELD})//
new DataDescriptor("depth", messageService.getMessage("valuelisteditorfield.java.ListEditorDepth_2"), DataDescriptor.HIDDEN),
new DataDescriptor("min", messageService.getMessage("valuelisteditorfield.java.MinimumOfCharacters_4"), DataDescriptor.FIELD_TEXT), //
new DataDescriptor("max", messageService.getMessage("valuelisteditorfield.java.MaximumOfCharacters_5"), DataDescriptor.FIELD_TEXT), //
new DataDescriptor("depth", messageService.getMessage("valuelisteditorfield.java.ListEditorDepth_6"), DataDescriptor.FIELD_TEXT), //
String path = portal ? "portal/css/page" : "css/rounded/page";
pb.setBrowser(browserString.replaceAll("^(.+?)\\d.*$", "$1"));
return BaseController.buildRedirectView(request, QuestionsController.PATH, PortalUtils.getCurrentJobId()).addObject("global", "1");
INCOMPLETE(0, "Incomplete"), // Portal application is incomplete.
COMPLETED(1, "Completed"), // Portal application is completed.
INCOMPLETE_MIGRATED(2, "Incomplete Migrated"), // Pre-existing incomplete portal application which is migrated.
COMPLETED_MIGRATED(3, "Completed Migrated"), // Pre-existing completed portal application which is migrated.
PARTIAL_COMPLETED(4, "Partial Completed"),
WITHDRAWN_MIGRATED(5, "Withdrawn Migrated"),
WITHDRAWN(6, "Withdrawn");
STARTED(0, "Started"), // Just started on the step.
SAVED(1, "In Progress"), // "Saved" at the step.
COMPLETE(2, "Completed"), // Completed the step.
INCOMPLETE(Integer.MIN_VALUE, "Not Started"); // If no status or record saved, it's incomplete.
return CandidateController.buildRedirectView(request, UrlHash.hashUrl("candidate?mode=apply&apply=yes"), jobID).addObject("back", "none");
return EeoController.buildRedirectView(request, EeoController.PATH, PortalUtils.getCurrentJobId()).addObject("back", eeoController.getBackPage(request));
public static final org.apache.avro.Schema SCHEMA$ = new org.apache.avro.Schema.Parser().parse("{\"type\":\"record\",\"name\":\"JobApplicationStatusChangeMessage\",\"namespace\":\"com.icims.workflow\",\"fields\":[{\"name\":\"actionId\",\"type\":\"string\"},{\"name\":\"submittalId\",\"type\":\"long\"},{\"name\":\"personId\",\"type\":\"long\"},{\"name\":\"jobId\",\"type\":\"long\"},{\"name\":\"updatedDate\",\"type\":\"string\"},{\"name\":\"updatedBy\",\"type\":\"long\"},{\"name\":\"status\",\"type\":\"string\"},{\"name\":\"customerId\",\"type\":\"long\"}]}");
if (formName.startsWith("Packet:")) {
if (formName.startsWith("Packet:")) {
return BaseController.buildRedirectView(request, JobController.PATH, PortalUtils.getCurrentJobId()).addObject("mode", "submit_apply");
return BaseController.buildRedirectView(request, DashboardController.PATH, null).addObject("registered", "yes");
return BaseController.buildRedirectView(request, DashboardController.PATH, null).addObject("registered", "yes");
if (request.getParameter("from") != null) mav.addObject("from", request.getParameter("from"));
return CandidateController.buildRedirectView(request, UrlHash.hashUrl("candidate?mode=apply&apply=yes"), jobID).addObject("back", "none");
return JOB_APPLICATION_CHANGE_TOPIC + (isProductionDB ? "" : "Test");
validateListPropKey("icims.config.appstatus.default", "Status for Default Submission");
validateListPropKey("icims.config.appstatus.vendor", "Status for Vendor Submission");
validateListPropKey("icims.config.appstatus.resumeimport", "Status for Resume Import Submission");
validateListPropKey("ccc.submittals.withdraw.status", "Withdrawal Status");
validateListPropKey("icims.config.appstatus.indeed.easy.apply", "Status for Indeed Easy Apply Submission");
validateListPropKey("ccc.submittals.referred.status", "Status for Referral Submission");
private static final String SLOT = "slot";
private static final String LIST = "list";
NONE("Off", 0), FULLTEXT("Keyword Search", 1), QUICKSEARCH("Keyword and Quick Search", 2);
NONE("Off", 0), FULLTEXT("Keyword Search", 1), QUICKSEARCH("Keyword and Quick Search", 2);
if (StringUtils.equalsIgnoreCase(value, "Off")) {
} else if (StringUtils.equalsIgnoreCase(value, "Keyword Search")) {
NONE("Off", 0), FULLTEXT("Keyword Search", 1), QUICKSEARCH("Keyword and Quick Search", 2);
} else if (StringUtils.equalsIgnoreCase(value, "Keyword and Quick Search")) {
FIELD("field"), //
CRITERIA("criteria"), //
RELATION("relation"), //
KEYWORD_ALL("keyword_all"), KEYWORD_ANY("keyword_any"), KEYWORD_BOOLEAN("keyword_bool"), KEYWORD_CONCEPT("keyword_concept"), INVALID("invalid");
FIELD("field"), //
CRITERIA("criteria"), //
RELATION("relation"), //
KENDO_DATE("date"), //
KENDO_NUMBER("number");
NUMBER(2, "number", new NumberSearchFilterInputValidator()), //
DISTANCE(30, "distance", new DefaultSearchFilterInputValidator()), //
if (StringUtils.equalsIgnoreCase(value, "tab")) {
} else if (StringUtils.equalsIgnoreCase(value, "preview")) {
reservedWords.add("NEAR");
searchString = searchString.replaceAll("\\s+", " ");
JOB("Job", ProfileDefinitionType.JOB), //
PERSON("Person", ProfileDefinitionType.PERSON), //
COMPANY("Company", ProfileDefinitionType.COMPANY), //
CONTACT("Contact", null), //
TASK("Task", null), //
APPROVAL("Approval", null), //
EXPENSES("Expenses", null), //
OFFER("Offer", null); //
if (StringUtils.startsWith(tableName, "Profile")) {
private static final String API_DATE_TIME_FORMAT = "yyyy-MM-dd hh:mm a";
assert ("criteria".equals(node.getAttributeValue(ListAttributeDefinition.SEARCH_VISUALIZATION_NODE_TYPE)));
TODAY("Today", new Pair<>("{DATE:START}", "{DATE:END}"), DateFilterType.DATE), //
YESTERDAY("Yesterday", new Pair<>("{DATE:START}{DATE:-1}", "{DATE:END}{DATE:-1}"), DateFilterType.DATE), //
TOMORROW("Tomorrow", new Pair<>("{DATE:START}{DATE:1}", "{DATE:END}{DATE:1}"), DateFilterType.DATE), //
BEFORE_TODAY("Before Today", new Pair<>("", "{DATE:END}{DATE:-1}"), DateFilterType.DATE), //
TODAY_UPTO_INCLUSIVE("Up To Today", new Pair<>("", "{DATE:END}"), DateFilterType.DATE), //
AFTER_TODAY("After Today", new Pair<>("{DATE:START}{DATE:1}", ""), DateFilterType.DATE), //
AFTER_NOW("After Yesterday", new Pair<>("{DATE:START}", null), DateFilterType.DATE), //
TOMORROW_TO_24MONTHS("Tomorrow to Next 24 Months", new Pair<>("{DATE:START}{DATE:1}", "{DATE:END}{MONTH:24}{DATE:-1}"), DateFilterType.DATE), //
LAST_WORKDAY("Since Last Workday", new Pair<>("{DATE:START}{WEEKDATE:-1}{HOUR:17}", "{DATE:END}"), DateFilterType.DATE), //
THIS_WEEK("This Week", new Pair<>("{DATE:START}{DAY:1}", "{DATE:END}{DAY:7}"), DateFilterType.DATE), //
THIS_MONTH("This Month", new Pair<>("{DATE:START}{MONTH:START}", "{DATE:END}{MONTH:END}"), DateFilterType.DATE), //
THIS_QUARTER("This Quarter", new Pair<>("{DATE:START}{QUARTER:START}", "{DATE:END}{QUARTER:END}"), DateFilterType.DATE), //
THIS_YEAR("This Year", new Pair<>("{DATE:START}{YEAR:START}", "{DATE:END}{YEAR:END}"), DateFilterType.DATE), //
LAST_WEEK("Last Week", new Pair<>("{DATE:START}{DATE:-7}{DAY:1}", "{DATE:END}{DATE:-7}{DAY:7}"), DateFilterType.DATE), //
LAST_MONTH("Last Month", new Pair<>("{DATE:START}{MONTH:-1}{MONTH:START}", "{DATE:END}{MONTH:-1}{MONTH:END}"), DateFilterType.DATE), //
LAST_QUARTER("Last Quarter", new Pair<>("{DATE:START}{MONTH:-3}{QUARTER:START}", "{DATE:END}{MONTH:-3}{QUARTER:END}"), DateFilterType.DATE), //
LAST_YEAR("Last Year", new Pair<>("{DATE:START}{YEAR:-1}{YEAR:START}", "{DATE:END}{YEAR:-1}{YEAR:END}"), DateFilterType.DATE), //
NEXT_WEEK("Next Week", new Pair<>("{DATE:START}{DATE:7}{DAY:1}", "{DATE:END}{DATE:7}{DAY:7}"), DateFilterType.DATE), //
NEXT_MONTH("Next Month", new Pair<>("{DATE:START}{MONTH:1}{MONTH:START}", "{DATE:END}{MONTH:1}{MONTH:END}"), DateFilterType.DATE), //
NEXT_QUARTER("Next Quarter", new Pair<>("{DATE:START}{MONTH:3}{QUARTER:START}", "{DATE:END}{MONTH:3}{QUARTER:END}"), DateFilterType.DATE), //
NEXT_YEAR("Next Year", new Pair<>("{DATE:START}{YEAR:1}{YEAR:START}", "{DATE:END}{YEAR:1}{YEAR:END}"), DateFilterType.DATE), //
LAST_TO_NEXT_WEEK("Last to Next Week", new Pair<>("{DATE:START}{DATE:-7}{DAY:1}", "{DATE:END}{DATE:7}{DAY:7}"), DateFilterType.DATE), //
LAST_TO_NEXT_MONTH("Last to Next Month", new Pair<>("{DATE:START}{MONTH:-1}{MONTH:START}", "{DATE:END}{MONTH:1}{MONTH:END}"), DateFilterType.DATE), //
LAST_TO_NEXT_QUARTER("Last to Next Quarter", new Pair<>("{DATE:START}{MONTH:-3}{QUARTER:START}", "{DATE:END}{MONTH:3}{QUARTER:END}"), DateFilterType.DATE), //
LAST_TO_NEXT_YEAR("Last to Next Year", new Pair<>("{DATE:START}{YEAR:-1}{YEAR:START}", "{DATE:END}{YEAR:1}{YEAR:END}"), DateFilterType.DATE), //
PAST_7DAYS("Past 7 Days", new Pair<>("{DATE:START}{DATE:-6}", "{DATE:END}"), DateFilterType.DATE), //
PAST_30DAYS("Past 30 Days", new Pair<>("{DATE:START}{DATE:-29}", "{DATE:END}"), DateFilterType.DATE), //
PAST_60DAYS("Past 60 Days", new Pair<>("{DATE:START}{DATE:-59}", "{DATE:END}"), DateFilterType.DATE), //
PAST_90DAYS("Past 90 Days", new Pair<>("{DATE:START}{DATE:-89}", "{DATE:END}"), DateFilterType.DATE), //
PAST_6MONTHS("Past 6 Months", new Pair<>("{DATE:START}{MONTH:-6}{DATE:1}", "{DATE:END}"), DateFilterType.DATE), //
PAST_12MONTHS("Past 12 Months", new Pair<>("{DATE:START}{MONTH:-12}{DATE:1}", "{DATE:END}"), DateFilterType.DATE), //
PAST_24MONTHS("Past 24 Months", new Pair<>("{DATE:START}{MONTH:-24}{DATE:1}", "{DATE:END}"), DateFilterType.DATE), //
NEXT_7DAYS("Next 7 Days", new Pair<>("{DATE:START}", "{DATE:END}{DATE:6}"), DateFilterType.DATE), //
NEXT_30DAYS("Next 30 Days", new Pair<>("{DATE:START}", "{DATE:END}{DATE:29}"), DateFilterType.DATE), //
NEXT_60DAYS("Next 60 Days", new Pair<>("{DATE:START}", "{DATE:END}{DATE:59}"), DateFilterType.DATE), //
NEXT_90DAYS("Next 90 Days", new Pair<>("{DATE:START}", "{DATE:END}{DATE:89}"), DateFilterType.DATE), //
NEXT_12MONTHS("Next 12 Months", new Pair<>("{DATE:START}", "{DATE:END}{MONTH:12}{DATE:-1}"), DateFilterType.DATE), //
NEXT_24MONTHS("Next 24 Months", new Pair<>("{DATE:START}", "{DATE:END}{MONTH:24}{DATE:-1}"), DateFilterType.DATE), //
FIRST_QUARTER("1st Quarter", new Pair<>("{DATE:START}{QUARTER:1}{QUARTER:START}", "{DATE:END}{QUARTER:1}{QUARTER:END}"), DateFilterType.DATE), //
SECOND_QUARTER("2nd Quarter", new Pair<>("{DATE:START}{QUARTER:2}{QUARTER:START}", "{DATE:END}{QUARTER:2}{QUARTER:END}"), DateFilterType.DATE), //
THIRD_QUARTER("3rd Quarter", new Pair<>("{DATE:START}{QUARTER:3}{QUARTER:START}", "{DATE:END}{QUARTER:3}{QUARTER:END}"), DateFilterType.DATE), //
FOURTH_QUARTER("4th Quarter", new Pair<>("{DATE:START}{QUARTER:4}{QUARTER:START}", "{DATE:END}{QUARTER:4}{QUARTER:END}"), DateFilterType.DATE),
PAST_HOUR("Past Hour", new Pair<>("{HOUR:-1}", "{HOUR:0}"), DateFilterType.TIME), //
PAST_2HOURS("Past 2 Hours", new Pair<>("{HOUR:-2}", "{HOUR:0}"), DateFilterType.TIME), //
PAST_6HOURS("Past 6 Hours", new Pair<>("{HOUR:-6}", "{HOUR:0}"), DateFilterType.TIME), //
PAST_48HOURS("Past 48 Hours", new Pair<>("{HOUR:-48}", "{HOUR:0}"), DateFilterType.TIME), //
PAST_72HOURS("Past 72 Hours", new Pair<>("{HOUR:-72}", "{HOUR:0}"), DateFilterType.TIME);
PAST_12HOURS("Past 12 Hours", new Pair<>("{HOUR:-12}", "{HOUR:0}"), DateFilterType.TIME), //
PAST_24HOURS("Past 24 Hours", new Pair<>("{HOUR:-24}", "{HOUR:0}"), DateFilterType.TIME), //
output.setTypeName("Contact");
output.setTypeName("Contact");
if (("LIST".equalsIgnoreCase(type) || "SUBLIST".equalsIgnoreCase(type))) {
private static final String KEY_LEVEL = "Key";
private static final String EXPRESSION_LEVEL = "Expression";
private static final String PROFILE_LEVEL = "Profile";
private static final String VALUE_LEVEL = "Value";
private static final String D_PREFIX = "$D{";
output.setTypeName("Expenses");
BeanLocatorHelper.getBean(SearchEngineService.class).forceFullSearchEngineReset("ColumnFormatSearch", "getBaseFieldDefinitionBySchemaId", "Error State");
if (schemaId.contains("$F{")) {
GroupListNode relationNode = findByNodeType(list, relation.getFromTable().getName(), relation.getName(), "relation", excludeHidden);
IFieldDefinition field = table.findField(StringUtil.abstractSubstring(fieldString, "$F{", "}"));
private static final String HOUR_FORMAT = "hh:mm a";
String prefix = "filter[filters]";
if (param.startsWith(prefix) && !param.contains("[logic]")) {
criteriaSchema = StringUtils.replace(schemaId, "$F{", "$C{");
CONTAINS("contains", 0L, "kendosearchresultsjsonbuilder.java.kendooperator.contains.label") {
private static final String COLUMNS = "COLUMN";
} else if (parts[i].startsWith("$F{")) {
searchString = searchString.replaceAll("\\s+", " ");
if (warn.getMessage().indexOf("Null value is eliminated by an aggregate") >= 0) continue;
if (warn.getMessage().indexOf("The full-text search condition contained noise word(s)") >= 0) continue;
if ("iform".equals(iFormMaskType[0])) {
String[] fieldsFromParent = abstractFieldString(conExp, "$S{P}");
conExp = replaceString(conExp, "$S{C}.", "");
int fpos = conExp.indexOf("$F{", pos);
else if (StringUtils.indexOf(dataTransferStorageInformation[SchedulerUtil.DATA_TRANSFER_STORAGE_TYPE_INDEX], "email") != -1 && !scheduledJob.isPaused()) {
CS("cs"), //
DE("de"), //
ES("es"), //
HI("hi"), //
HR("hr"), //
IT("it"), //
NO("no"), //
searchEngineService.scheduleFullSearchEngineReset("ResetSearchEngineProcessor", "handleProcessor", "Product Status Changed");
StringBuilder msg = new StringBuilder("Can't create the relations, need to add more tables.");
if (variableStr.startsWith("Global")) {
String fieldName = "$F{" + StringUtil.abstractSubstring(reference, "$F{", "}") + "}";
if (StringUtils.containsIgnoreCase(schemaId, "rank")) {
PREVIOUS_SEARCH_ALLOWED_TABS.add("LIMITED");
if (StringUtils.containsIgnoreCase(schemaId, "rank")) {
StringBuilder results = new StringBuilder("<form data-rating=\"").append(fieldName).append("\" ");
if (!config.startsWith("auto")) {
if (externalized && !multilingualVariableService.resolveVariable(parsedString).contains("{value}")) {
int max = schemaId.lastIndexOf("Job");
if (schemaId.lastIndexOf("Person") > max) {
max = schemaId.lastIndexOf("Person");
if (schemaId.indexOf("Company") > max) {
muri = new MutableURI(null, null, "icims2", "module=AppSearchEngine&action=searchFrame", null);
String variableName = relativeField.replace("$E{", "$V{");
for (String relativeValue : DataSchemaHelper.extractValues(sql, "Value")) {
CRITERIA("criteria"), //
FIELD("field"), //
if (!term.isEmpty() && !"in".equals(term) && (term.length() > 1 || (int)term.charAt(0) > 127 || (int)term.charAt(0) == 35)) {
if (StringUtils.endsWith(node.getFieldDefinition().getSchemaId(), ".$F{TodayDateTime}")) return false;
if (!StringUtils.endsWith(schemaId, "$F{PersonID}")) {
String relationSchemaId = schemaId.substring(0, schemaId.indexOf(".$F{PersonID}"));
return schema.replaceAll("\\$F", "\\$T") + ".$F{PersonID}";
StringBuilder error = new StringBuilder("Batched search failure!\n\n");
if (warn.getMessage().indexOf("Null value is eliminated by an aggregate") >= 0) continue;
if (warn.getMessage().indexOf("The full-text search condition contained noise word(s)") >= 0) continue;
} else if (!StringUtils.startsWith(typeName, "Profile")) {
if (!StringUtils.equalsIgnoreCase("ok", validationResult)) {
return new JSONObject().put("running", true).toString();
if (!StringUtils.equalsIgnoreCase("ok", validationResult)) {
return new JSONObject().put("running", true).toString();
if (originalOutput.getGroupByDefinitions().size() <= 1) return generateChartSeries(reader, schemaId, "pie", isDate, itemLimit, sortOrder, allowSearchResults, ignoreSelected);
if (StringUtils.endsWithIgnoreCase(groupBys.get(0).getSchemaId(), "$F{TOTAL}")) {
JSONObject result = new JSONObject().put("filter", filters);
searchString = searchString.replaceAll("\\s+", " ");
searchString = StringUtils.replace(searchString, "\\s+", " ");
List<Node> tempList = DOMHelper.selectNodes(optionXml, "Data/Option");
private static final String PENDING = "pending";
private static final String PERSON = "Person";
private static final String PROGRESS = "progress";
private static final String RESULT = "result";
private static final String STATUS = "status";
private static final String SUCCESS = "success";
private static final String DEFAULT_INTEGRATION_MESSAGE = "No Errors on Conversation";
private static final String DEFAULT_INTEGRATION_TROUBLESHOOTING = "No errors have occurred on this conversation";
private static final String DEFAULT_ERROR_INTEGRATION_MESSAGE = "No further information";
pb.setCustomizedMessage("List of Search filters (Group inheritence is not displayed)");
private static final String DEFAULT_ERROR_INTEGRATION_TROUBLESHOOTING = "No further troublshooting information";
pb.setMessage("Must be a DevAdmin");
String blankFilter = "{\"operator\":\"&\"}";
String message = "Submittal could not be found.";
String message = "The status parameter did not match the submittal's previous status.";
String message = "Could not find previous status.";
throw new SearchActionException(SearchActionException.MODE_ERRORPAGE, SearchActionException.ERROR_GENERIC, "Invalid Status List");
SelectedList selectedList = searchEngineBo.getSelectedListForAction(reader, "Hire", -1, isSearchBrowser);
pb.setAppointmentType("Interview");
pb.setAppointmentType("Interview");
pb.setAppointmentType("Appointment");
(Integer.valueOf(Contact.INTERVIEW_SCHEDULE).equals(contact.getStatus()) ? "interview" : "appointment");
(Integer.valueOf(Contact.INTERVIEW_SCHEDULE).equals(contact.getStatus()) ? "interview" : "appointment");
typeSelect.add("Excel");
typeSelect.add("TAB");
if (!pb.getTypeSelect().contains("Excel")) pb.setError(messageService.getMessage("appsearchactionadapter.java.ExportingSearchesWithGrou_1339"));
questionCount = "all";
JSONObject ret = new JSONObject().put("ok", "");
JSONObject webpost = new JSONObject().put("postType", Long.toString(posttype)).put("posted", "false").put("portalId", "0");
if (request.getParameter(SEARCH_BROWSER) != null) return "ok";
String backUrl = "icims2?module=AppSearchEngine&action=searchFrame&table=" + (meetingSearch ? "Meeting" : ("Submittal&slot=" + slot));
this.allowPreviousSearch = "LIMITED".equals(tab);
} else if (key.charAt(0) == SavedSearch.PREFIX_PROCESSOR || key.indexOf("_Rank_") != -1 || key.indexOf("Keywords") != -1) {
this.profileImage = "search";
this.queryString = GeneralUtil.setQueryStringValue(queryString, "slot", resultsBean.getSlot());
query = GeneralUtil.setQueryStringValue(query, "module", null);
query = GeneralUtil.setQueryStringValue(query, "action", null);
query = GeneralUtil.setQueryStringValue(query, "hashed", null);
pb.setManageSearchTemplatesURLFragment(useManageSearchTemplatesKendoGrid ? "module=AppManageTemplatesAdapter&action=manageSearchTemplates" : "module=AppSearchEngine&action=manageTemplates");
pb.setManageSearchTemplatesURLFragment(useManageSearchTemplatesKendoGrid ? "module=AppManageTemplatesAdapter&action=manageSearchTemplates" : "module=AppSearchEngine&action=manageTemplates");
pb.setManageOutputTemplatesURLFragment(useManageSearchTemplatesKendoGrid ? "module=AppManageTemplatesAdapter&action=manageOutputTemplates" : "module=AppSearchEngine&action=manageTemplates");
pb.setManageOutputTemplatesURLFragment(useManageSearchTemplatesKendoGrid ? "module=AppManageTemplatesAdapter&action=manageOutputTemplates" : "module=AppSearchEngine&action=manageTemplates");
viewOptions.add(new SearchFormPageBean.SearchViewOption(messageService.getMessage("appsearchengineadapter.java.Default_1"), "grid", true));
if (node != null && "field".equals(node.getAttributeValue(ListAttributeDefinition.SEARCH_VISUALIZATION_NODE_TYPE))) {
String which = globalDefault ? "defaultGlobal" : "default";
String which = globalDefault ? "defaultGlobal" : "default";
private static final String STALENESS_PARAM = "staleness";
private static final String FIELDS_PARAM = "fields";
searchOrOutput = "all";
throw new JMRuntimeException("Unable to initialize DAOs to evaluate attributes.");
return String.format("No instance found for customer %s", customer.getCustomerName());
String dDescription = "Change Data Capture Monitoring";
dConstructors[0] = new MBeanConstructorInfo("ChangeDataCaptureMXBeanImpl(): No-parameter constructor", //
return String.format("CDC Backlog report: %s", datasourceReport);
private static final String NAME = "Submittal Full Text";
throw new ChangeDataCaptureException("CDC: Unable to log invalidly formed Event");
String message = String.format("CDC: %s", IDIF.serializeEvent(e));
private static final String NAME_TEMPLATE = "%s Delete";
CollectionField educationCollection = new CollectionField().name("education");
ProfileIDIFHelper.addAttribute(educationEntry, convertListNodeToIDIF("lists.school", "school", education.getSchool()));
ProfileIDIFHelper.addAttribute(educationEntry, convertListNodeToIDIF("lists.school.degree", "degree", education.getDegree()));
ProfileIDIFHelper.addAttribute(educationEntry, convertListNodeToIDIF("lists.school.major", "major", education.getMajor()));
ProfileIDIFHelper.addAttribute(educationEntry, new StringField().name("minor").value(education.getMinor()));
ProfileIDIFHelper.addAttribute(educationEntry, new StringField().name("rank").value(education.getRank()));
DEFAULT(0, "All Data"), ALLDATA(1, "All Data"), MINUTE1(2, "1 Minute"), HOUR1(3, "1 Hour"), DAY1(4, "1 Day"), MONTH1(5, "1 Month"), YEAR1(6, "1 Year"), YEAR5(7, "5 Years");
DEFAULT(0, "All Data"), ALLDATA(1, "All Data"), MINUTE1(2, "1 Minute"), HOUR1(3, "1 Hour"), DAY1(4, "1 Day"), MONTH1(5, "1 Month"), YEAR1(6, "1 Year"), YEAR5(7, "5 Years");
DEFAULT(0, "All Data"), ALLDATA(1, "All Data"), MINUTE1(2, "1 Minute"), HOUR1(3, "1 Hour"), DAY1(4, "1 Day"), MONTH1(5, "1 Month"), YEAR1(6, "1 Year"), YEAR5(7, "5 Years");
DEFAULT(0, "All Data"), ALLDATA(1, "All Data"), MINUTE1(2, "1 Minute"), HOUR1(3, "1 Hour"), DAY1(4, "1 Day"), MONTH1(5, "1 Month"), YEAR1(6, "1 Year"), YEAR5(7, "5 Years");
DEFAULT(0, "All Data"), ALLDATA(1, "All Data"), MINUTE1(2, "1 Minute"), HOUR1(3, "1 Hour"), DAY1(4, "1 Day"), MONTH1(5, "1 Month"), YEAR1(6, "1 Year"), YEAR5(7, "5 Years");
DEFAULT(0, "All Data"), ALLDATA(1, "All Data"), MINUTE1(2, "1 Minute"), HOUR1(3, "1 Hour"), DAY1(4, "1 Day"), MONTH1(5, "1 Month"), YEAR1(6, "1 Year"), YEAR5(7, "5 Years");
DEFAULT(0, "All Data"), ALLDATA(1, "All Data"), MINUTE1(2, "1 Minute"), HOUR1(3, "1 Hour"), DAY1(4, "1 Day"), MONTH1(5, "1 Month"), YEAR1(6, "1 Year"), YEAR5(7, "5 Years");
DEFAULT(0, "All Data"), ALLDATA(1, "All Data"), MINUTE1(2, "1 Minute"), HOUR1(3, "1 Hour"), DAY1(4, "1 Day"), MONTH1(5, "1 Month"), YEAR1(6, "1 Year"), YEAR5(7, "5 Years");
return "Initial Data Transfer V2 Thread";
private static final String PROGRESS_FOLDER = "progress";
throw new IDTException("Error uploading status file", e);
throw new FileStorageException("error initiating S3 multi part upload");
throw new FileStorageException("Could not put text file in S3");
throw new FileStorageException("Could not locate text file in S3");
INFORMATIONAL(1, false, "Informational", "tasktype.java.InformationalToString_2"), //
FORM(2, false, "Form", "tasktype.java.FormToString_3"), //
INTEGRATION(3, false, "Integration", "tasktype.java.IntegrationToString_4"), //
IN_PROGRESS(0, "In-Progress"), OPEN(1, "Open"), COMPLETE(2, "Complete"), INFORMATIONAL(3, "Informational Only"), PENDING(4, "Pending"), UNKNOWN(Integer.MIN_VALUE, "error");
IN_PROGRESS(0, "In-Progress"), OPEN(1, "Open"), COMPLETE(2, "Complete"), INFORMATIONAL(3, "Informational Only"), PENDING(4, "Pending"), UNKNOWN(Integer.MIN_VALUE, "error");
IN_PROGRESS(0, "In-Progress"), OPEN(1, "Open"), COMPLETE(2, "Complete"), INFORMATIONAL(3, "Informational Only"), PENDING(4, "Pending"), UNKNOWN(Integer.MIN_VALUE, "error");
IN_PROGRESS(0, "In-Progress"), OPEN(1, "Open"), COMPLETE(2, "Complete"), INFORMATIONAL(3, "Informational Only"), PENDING(4, "Pending"), UNKNOWN(Integer.MIN_VALUE, "error");
GENERAL(0, true, "General", "tasktype.java.GeneralToString_1"), //
FILE_UPLOAD(5, false, "File Upload", "tasktype.java.FileUploadToString_6"), //
UNKNOWN(4, false, "Unknown", "tasktype.java.defaultToString_5");
return "New Notification";
return "Reminder Notification";
return "Overdue Notification";
return "Resend Notification";
return "Reminder and Overdue Notifications";
return "iform";
if (StringUtils.isNotBlank(formSection) && !StringUtils.equals("default", formSection)) {
ASSIGNEE(1, "Associated Person", "editlibrarytask.jsp.AssociatedPerson_11"), //
PERSON(2, "Specific Person", "editlibrarytask.jsp.SpecificPerson_13"), //
SCHEMA(3, "Relational Person", "editlibrarytask.jsp.RelationalPerson_15");
ASSIGNED_DATE(1, "Days After Task Assigned"), //
START_DATE_AFTER(2, "Days After Start Date"), //
START_DATE_BEFORE(3, "Days Before Start Date");
return "After Task Assigned";
return "After Start Date";
return "Before Start Date";
return "After Task Assigned";
query.addEntity("t", "Task");
String profileType = profileDef != null ? profileDef.getFriendlyName() : "Unknown";
String hidden = taskDefn.isHidden() ? "Yes" : "No";
String hidden = taskDefn.isHidden() ? "Yes" : "No";
String operation = "&operation=" + (editable ? "edit" : "view");
String operation = "&operation=" + (editable ? "edit" : "view");
SavedFilter locks = this.searchTemplateBo.createFilterTemplate("Task");
private static final String KEY_SUBJECT = "subject"; // InstanceSafe
return "SECTIONED OUTPUT";
return "PORTAL OUTPUT";
return "EMAIL CAMPAIGN SEARCH";
return "FORM PACKET";
return "EMAIL CAMPAIGN MAIL TEMPLATE";
return "Output";
return "Search";
return "Filter";
public static final String globalTitle = "Global Group";
if (key.endsWith("Date")) {
cols.put(new JSONObject().put("name", name).put("value", schema));
if (filterParam.endsWith("Date")) {
private static String ILLEGAL_STATE_ERROR = "Parameter Map is in an invalid state.  Cannot continue.";
VALID_FILTER_ATTRIBUTES.add("value");
VALID_FILTER_ATTRIBUTES.add("operator");
VALID_GROUP_ATTRIBUTES.add("filters");
VALID_GROUP_ATTRIBUTES.add("operator");
VALID_GROUP_ATTRIBUTES.add("children");
throw new SearchTreeException("(blank)", SearchTreeExceptionType.INVALID_FILTER);
if (StringUtils.startsWith(schemaData, "LIST") || StringUtils.startsWith(schemaData, "SUBLIST") || //
APPROVALCOLUMN("approval") {
COLUMN("column") {
DATE("date") {
FILTER("filter") {
FORMULACOLUMN("formula") {
IRREGULAR("irregular") {
PORTAL("portal") {
VARIABLECOLUMN("variable") {
GRID("grid"), DAY("day"), WEEK("week"), MONTH("month"), ORGCHART("orgchart");
GRID("grid"), DAY("day"), WEEK("week"), MONTH("month"), ORGCHART("orgchart");
GRID("grid"), DAY("day"), WEEK("week"), MONTH("month"), ORGCHART("orgchart");
GRID("grid"), DAY("day"), WEEK("week"), MONTH("month"), ORGCHART("orgchart");
profileTypeName = "Person";
profileTypeName = "Candidate";
profileTypeName = "Employee";
profileTypeName = "Client";
profileTypeName = "Person";
JSONObject parameter = new JSONObject().put("name", entry.getKey()).put("value", entry.getValue().getData());
DEFAULT(""), COLUMNS("Columns"), GROUPBY("GroupBy"), ORDERBY("OrderBy"), VIEW("View"), SECTION("Section");
DEFAULT(""), COLUMNS("Columns"), GROUPBY("GroupBy"), ORDERBY("OrderBy"), VIEW("View"), SECTION("Section");
DEFAULT(""), COLUMNS("Columns"), GROUPBY("GroupBy"), ORDERBY("OrderBy"), VIEW("View"), SECTION("Section");
return "OUTPUT";
return "SEARCH";
return "FILTER";
return "ENTRANCE CRITERIA FILTER";
return "PREVIOUS SEARCH";
return "PREVIOUS OUTPUT";
return "Public";
private static final String SHARED = "yes";
private static final String PRIVATE = "no";
return "Private";
return "Public (Editable)";
return "Public (Locked)";
private static final String SHARED = "shared";
.setString("title", SavedFilter.globalTitle).setString(TYPE_NAME, typeName).setInteger(SHARED, 1).uniqueResult();
throw new PermissionDeniedException("Cannot save this template because a " + (withOwnerId ? "private" : "public") + " template with name \"" + template.getTitle() + "\" already exists"
throw new PermissionDeniedException("Cannot save this template because a " + (withOwnerId ? "private" : "public") + " template with name \"" + template.getTitle() + "\" already exists"
private static final String[] translators = new String[] {"DEFAULTID", "SYSTEMID", "NICKNAME"}; // InstanceSafe
if (StringUtils.equalsIgnoreCase(value, "All Templates") || //
StringUtils.equalsIgnoreCase(value, "My Templates")) {
private static final String API_NAME_DESCRIPTION = "description";
private static final String API_NAME_TITLE = "title";
private static final String API_NAME_SHARED = "shared";
private static final String API_NAME_CRITERIA = "criteria";
private static final String API_NAME_TYPE = "type";
private static final String API_NAME_TEMPLATES = "templates";
throw new SearchTemplateTranslationException("Provided search template is null.");
throw new SearchTemplateTranslationException("Provided search template is null.");
} else if ("Public (Editable)".equalsIgnoreCase(shared)) {
} else if ("Public (Locked)".equalsIgnoreCase(shared)) {
String reason = "Unknown";
throw new SearchTemplateTranslationException("Failed to save template.");
private int maxValueLength;
String error = messageService.getMessage("timetofilllistvalidator.error.maxlimit_1", Collections.singletonMap("max", maxFieldsAllowed));
if (params.length != 6) throw new Exception("Required to enter complete FTP/SFTP Server Information.");
throw new Exception("Invalid file transfer server type");
throw new IOException("Failed to reconnect to the FTP server", e);
MARKETING_USER("icims.marketing.api.user", "Marketing API", false, "956a80cb391eff27e7257fff9ea22e61"), // MARKETING_SALT
LICENSE_USER("icims.license.api.user", "Licensing API", false, "956a80cb391eff27e7257fff9ea22e61"), // MARKETING_SALT
HIRERIGHT_USER("hireright-mulesoft", "HireRight Integration", false, "C7CEB0D25D80F861D15F90730F402B75"), // HIRERIGHT_SALT
PRIME_ORCHESTRATION_USER("icims.orchestration.api.user", "Prime Orchestration", true), //
UX_SERVICES_USER("icims.ux.service.api.user", "UX Services", true), //
MOBILE_SERVICES_USER("icims.mobile.api.user", "Mobile Services", true), //
SOCIAL_DISTRO_USER("socialdistrointernal", "Social Distribution", true), //
TOOLS_API_USER("icims.tools.api.user", "Tools API", true);
ENTITLEMENTS_USER("icims.entitlement.api.user", "Entitlements", true), //
INTERNAL_API_USER("icims.internal.api.user", "Internal API", true), //
if (data == null) throw new IOException("No data");
throw new IOException("Cannot write to this DataSource");
InstanceException exception = new InstanceException("Missing request security token.");
InstanceException exception = new InstanceException("Invalid security token.");
throw new DataFormatException("CSV row has over 10,000 lines - aborting.");
throw new DataFormatException("CSV entry has an opening quote but no closing quote.");
sensitiveParameters.add("password");
throw new MultipartException("This is not a multipart request.", new FileUploadBase.InvalidContentTypeException());
if (StringUtils.containsIgnoreCase(moduleParam[0], "form")) {
private static final String[] ALLOWED_ACTIONS_IPRESTRICT = {"showForm", "formsLogin", "singleSignOnForms", "password", "resetPassword", "removeEmail"};
if (StringUtils.equals(action, "index") && request.getParameter("r") != null) return false;
DateTimeFormatter formatter = DateTimeFormat.forPattern("yyyy-MM-dd hh:mm a");
DateTimeFormatter formatter = DateTimeFormat.forPattern("yyyy-MM-dd hh:mm a");
if (!checkForFields(json, new String[] {"currency", "amount"}).isEmpty()) {
if (!checkForFields(json, new String[] {"currency", "amount"}).isEmpty()) {
amount = json.getDouble("amount");
if (name.startsWith("get")) {
} else if (name.startsWith("is")) {
private static final String CMS_OLD_GEN = "CMS Old Gen";
ignoreTags.add("HEAD");
ignoreTags.add("SCRIPT");
return input.replaceAll("\\s+", " ").trim();
path = StringUtils.substringAfter(path, "file:");
"95", "96", "97", "98", "99", "9a", "9b", "9c", "9d", "9e", "9f", "a0", "a1", "a2", "a3", "a4", "a5", "a6", "a7", "a8", "a9", "aa", "ab", "ac", "ad", "ae", "af", "b0", "b1", "b2", "b3", "b4", "b5", "b6", "b7", "b8", "b9", "ba", "bb",
"bc", "bd", "be", "bf", "c0", "c1", "c2", "c3", "c4", "c5", "c6", "c7", "c8", "c9", "ca", "cb", "cc", "cd", "ce", "cf", "d0", "d1", "d2", "d3", "d4", "d5", "d6", "d7", "d8", "d9", "da", "db", "dc", "dd", "de", "df", "e0", "e1", "e2",
"bc", "bd", "be", "bf", "c0", "c1", "c2", "c3", "c4", "c5", "c6", "c7", "c8", "c9", "ca", "cb", "cc", "cd", "ce", "cf", "d0", "d1", "d2", "d3", "d4", "d5", "d6", "d7", "d8", "d9", "da", "db", "dc", "dd", "de", "df", "e0", "e1", "e2",
"bc", "bd", "be", "bf", "c0", "c1", "c2", "c3", "c4", "c5", "c6", "c7", "c8", "c9", "ca", "cb", "cc", "cd", "ce", "cf", "d0", "d1", "d2", "d3", "d4", "d5", "d6", "d7", "d8", "d9", "da", "db", "dc", "dd", "de", "df", "e0", "e1", "e2",
"e3", "e4", "e5", "e6", "e7", "e8", "e9", "ea", "eb", "ec", "ed", "ee", "ef", "f0", "f1", "f2", "f3", "f4", "f5", "f6", "f7", "f8", "f9", "fa", "fb", "fc", "fd", "fe", "ff"};
if (!StringUtils.isBlank(formSection) && !"default".equals(formSection)) {
private static final String COMPANY = "Company";
private static final String CONTACT = "Contact";
private static final String JOB = "Job";
private static final String MEETING = "Meeting";
private static final String PERSON = "Person";
private static final String OFFER = "Offer";
listNodeID = listNodeID.replaceAll("\\d+\\((\\d+)\\)", "$1");
} else if (searchTable.startsWith("Profile")) {
} else if (searchTable.startsWith("Profile")) {
String dueDate = tData.getDueDate().toString("MM/dd/yyyy");
originalHashableParams.add("module");
originalHashableParams.add("candids");
originalHashableParams.add("list");
originalHashableParams.add("candid");
originalHashableParams.add("mode");
originalHashableParams.add("preview");
originalHashableParams.add("page");
originalHashableParams.add("action");
hashableParams.add("back");
hashableParams.add("apply");
hashableParams.add("withdraw");
hashableParams.add("form");
return "Completed";
return "Requested";
return "Unknown";
Exception exception = new Exception("Could not retrieve video service status");
String error = "ERROR";
throw new InvalidStateException("No Instance mounted when trying to hash url.");
protected static final String NOT_SET_VALUE = "not set";
sourceWithPiiSourcenameMutable.add("Email a Friend");
sourceWithPiiSourcenameMutable.add("Social Networks");
sourceWithPiiSourcenameMutable.add("Referral");
sourceWithPiiSourcenameMutable.add("Employee Referral");
CAREERS_PORTAL("careers"), //
CONNECT_PORTAL("connect"), //
PLATFORM("platform");
INTRO("home"), //
JOB_APPLY("apply"), //
REFERRAL("referral"), //
ASSESSMENTS("assessments"), //
OFFER("offer"), //
CONNECT_WELCOME("welcome"), //
CONNECT_INTERESTS("interests"), //
CONNECT_RESUME("resume"), //
IcimsHttpHeader.populateApplicationIcimsHeaders(request, response, "App", "SPA");
String module = mUri.getRawQueryParameter("module");
String action = mUri.getRawQueryParameter("action");
if (mUri.getRawQueryParameter("theme") != null) throw new RuntimeException("theme parameter is already defined! URI: " + uri);
writer.writeAttribute("domain", url.trim());
addContentSecurityPolicyHeader(response, "portal");
addContentSecurityPolicyHeader(response, "platform");
throw new ServletException("Could not initialize minify JS libraries", e);
StringBuilder results = new StringBuilder("<form data-rating=\"").append(field.getFieldDefinition().getFieldName()).append("\" ");
private static final String[] scale = {"Bytes", "KB", "MB", "GB"};
private static final String[] scale = {"Bytes", "KB", "MB", "GB"};
private static final String[] scale = {"Bytes", "KB", "MB", "GB"};
private static final String[] scale = {"Bytes", "KB", "MB", "GB"};
private String format = "short";
String scaleSuffix = "bytes";
this.setDynaAttribute("format", UserDateTimeInfo.getPattern(DateTimePattern.getPattern(format)));
keyName = "email";
protected String label = "label";
label = "label";
private static final String OMITTED = "OMITTED";
StringBuilder registerGroupLoop = new StringBuilder("<script>if (typeof registerGroupLoop === 'function') { registerGroupLoop(");
if (StringUtils.isBlank(brandingType) || "default".equals(brandingType) || form == null || form.getBrandingId() >= DEFAULT_PORTAL_POST_TYPE) {
