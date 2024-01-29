return "<span data-column='startDate'>" + (data.startDate != null ? kendo.toString(data.startDate, "MM/dd/yyyy hh:mm tt") : resourceBundle.get('icims.eventmanager.js.no.information')) + "</span>";
return "<span data-column='endDate'>" + (data.endDate != null ? kendo.toString(data.endDate, "MM/dd/yyyy hh:mm tt") : resourceBundle.get('icims.eventmanager.js.no.information')) + "</span>";
updateSummary('startDate', newDate.format('MM/DD/YYYY'));
updateSummary('interval', $(this).find('option:selected').text().toLowerCase());
backUrl = SetQueryStringValue(backUrl, "expirations", expiration.val());
if ($elem.attr('type') === 'radio' && $elem.val() == '1') {
updateSummary('days', resourceBundle.get('scheduleemail.js.everyStarting_3', {'daysOfWeekText':daysOfWeekText}));
wildcard: '%QUERY',
9: 'tab',
13: 'enter'
var labelText = $input.attr('fieldLabel') || 'Item';
document.id('form1').set("send", {
if(!isValidFilterValue(filters[i], filterObj.value, filterObj.secondaryValue, dateFormatter)) throw "Invalid Filter";
if("Person" == document.id("table").value) {
if(filterContainer.get('joinerType') == 'filter') {
if (tableName !== 'contact' && workflow === '1') {
if (tableName === "contact") {
tableName = "Person";
ret.push(buildJSON('web', postType, post, portal));
webPostJSON.push(buildJSON('web', postType, posted, portal));
vendors.push(buildJSON('vendor', id, input.get('checked')));
JSONput(postJSON, 'vendors', buildVendorPosts());
JSONput(postJSON, 'web', buildWebPosts());
JSONput(postJSON, 'web', buildWebPosts());
webPostState.set(webPostPb ? 'WEB' : 'PORTAL');
webPostState.set(webPostPb ? 'WEB' : 'PORTAL');
webPostState.set('PORTAL');
var WEB = 'WEB';
var PORTAL = 'PORTAL';
if (results == "OK") {
if (resumeFrame.nodeName === "OBJECT") {
if (linkedAccount === resumeType && resumeType !== 'linkedin') {
if (resumeType === 'linkedin') {
var currentResumeTypeActive = 'traditional';
if (linkedInRSCEnabled && resumeType === 'linkedin') {
glyphType = $(this).children('.glyphicons').length ? "glyphicons" : "social";
className = $(this).children('.social').attr('class') || 'social';
if (results != "OK") {
if (results != "OK") {
fontFamily: 'Noto Sans',
jobLabel = "job";
if (target.getAttribute('role') === 'necessity') {
var start = cal.state.getStartMoment().startOf('day'),
end = cal.state.getEndMoment().add(1, 'days').startOf('day');
end = cal.state.getEndMoment().add(1, 'days').startOf('day');
var interactableBlock = interact('[mutable=true] .appointment', {context: container});
var interactableBlockOpp = interact('[mutable=true] .calendar-block-resize-dragger', {context: container});
appointment: 'appointment',
busy: 'busy',
free: 'free'
room: 'room',
person: 'person'
day: 'day'
_timeFormat = settings.timeFormat || 'YYYY/MM/DD h:mm A',
_hourMinuteFormat = settings.hourMinuteFormat || 'h:mm A',
_longDateFormat = settings.longDateFormat || 'dddd, MMMM Do YYYY',
var hourRenderer = state.getStartMoment().startOf('day').subtract(1, 'hour'),
var hourRenderer = state.getStartMoment().startOf('day').subtract(1, 'hour'),
start.add(1, 'day');
var newDate = state.getStartMoment().startOf('day').add(dateIncrease, 'days');
var newDate = state.getStartMoment().startOf('day').add(dateIncrease, 'days');
var dateHeader = '<div class="day">';
if (state.getCurrentMoment().startOf('day').isAfter(state.getStartMoment().startOf('day'))) {
period = hour < 12 ? 'AM' : 'PM';
period = hour < 12 ? 'AM' : 'PM';
if (state.getCurrentMoment().startOf('day').isBefore(state.getEndMoment().startOf('day'))) {
var scrollDistance = state.getCurrentMoment().diff(state.getStartMoment().startOf('day'), 'days') * 60 * 24;
var wholeLength = end.diff(start, 'minutes');
blockViewData.hour = start.hours() + (start.diff(state.getStartMoment().startOf('day'), 'days') * 24);
blockViewData.hour = start.hours() + (start.diff(state.getStartMoment().startOf('day'), 'days') * 24);
var scrollDistance = state.getCurrentMoment().diff(state.getStartMoment().startOf('day'), 'days') * 60 * 24;
var scrollDistance = state.getCurrentMoment().diff(state.getStartMoment().startOf('day'), 'days') * 60 * 24;
var scrollDistance = state.getCurrentMoment().diff(state.getStartMoment().startOf('day'), 'days') * 60 * 24;
resultDiv.set('class', 'NoDisplay');
elem.set('class', 'alert alert-info');
elem.set('class', 'alert alert-info');
span.set('class', 'glyphicons glyphicons-info-sign');
elem.set('class', 'alert alert-success');
elem.set('class', 'alert alert-success');
span.set('class', 'glyphicons glyphicons-ok-sign');
elem.set('class', 'alert alert-danger');
elem.set('class', 'alert alert-danger');
span.set('class', 'glyphicons glyphicons-exclamation-sign');
messageBox.set("class","NoDisplay");
messageBox.set("class","NoDisplay");
value: 'month',
value: 'week',
AKSB.q.push(["mark", c, b || (new Date).getTime()])
AKSB.q.push(["measure", c, b, a || (new Date).getTime()])
AKSB.q.push(["done", c])
(a.frameElement || a).style.cssText = "width: 0; height: 0; border: 0; display: none";
})(window,document,'script','//www.google-analytics.com/analytics.js','uga');
formData.append('library', $('#library').prop('checked'));
messageBox.set("class", "NoDisplay");
var _view = settings.view || 'week';
$alert.alert('close');
acceptance = 'accepted circle_ok glyphicons-ok-sign';
acceptance = 'declined circle_remove glyphicons-remove-sign';
acceptance = 'tentative circle_question_mark glyphicons-question-sign';
acceptance = 'undecided hourglass glyphicons-hourglass';
value: 'day',
css: 'glyphicons glyphicons-filter all'
css: 'filter-icon declined'
css: 'filter-icon tentative'
css: 'filter-icon notdecided'
css: 'filter-icon accepted'
var format = this.view.state.getView() === 'month' ? this.calendar.state.getShortDateFormat() : this.calendar.state.getDateFormat();
} else if ($(this).data('step') === 'next') {
} else if ($(this).data('step') === 'today') {
appointment.range = '0 minutes';
attendee.acceptance = 'accepted glyphicons';
attendee.acceptance = 'declined glyphicons';
attendee.acceptance = 'tentative glyphicons';
var startDifference = Math.max(firstDayOfView.diff(allDayStart, 'days'), 0);
var endDifference = Math.max(allDayEnd.diff(lastDayOfView, 'days'), 0);
var realDifference = allDayEnd.diff(allDayStart, 'days');
appointment.left = Math.max(allDayStart.diff(firstDayOfView, 'days'), 0) * (100/7);
var keyDiff = this.keyEnd.diff(this.keyStart, 'minutes');
var start = currentDate.startOf('week');
var end = currentDate.clone().endOf('week');
return start.format('D ' + endMonth) + ' - ' + end.format('D MMMM, YYYY');
return start.format('MMMM D') + ' - ' + end.format(endMonth + ' D, YYYY');
now.add(1, 'hour');
var beginWeek = currentDate.startOf('week');
headers.push(beginWeek.format('D ddd'));
beginWeek.add(1, 'day');
var beginWeek = currentDate.startOf('week');
beginWeek.add(1, 'day');
if (sendUpdateResult == "cancel") return;
window.opener.top.frames['main_body'].refreshPanel(null, 'Contact');
if (option.value === 'other') {
_timeFormat = settings.timeFormat || 'h:mm A',
_longDateFormat = settings.longDateFormat || 'dddd, MMMM Do YYYY',
_longDateNoYearFormat = settings.longDateNoYearFormat || 'dddd, MMMM Do',
_unit = settings.unit || 'day',
outer.style.overflow = 'scroll';
throw new TypeError('`CSS.escape` requires an argument.');
var videoUrlVariables = ['Recipient:$T{Person}.$F{VideoUrl}', 'Recipient:$T{Person}.$F{VCLCantRecordUrl}'];
var videoUrlVariables = ['Recipient:$T{Person}.$F{VideoUrl}', 'Recipient:$T{Person}.$F{VCLCantRecordUrl}'];
alert("Please enter the body of your message before saving.");
alert("Please enter the subject of your message before saving.");
if(autoSelectChildren && userControl.hasClass('explicit')) userControl.set('dirty', true);
'class': isExplicitlySelected ? 'explicit' : 'inherited',
'class': isExplicitlySelected ? 'explicit' : 'inherited',
document.write("Could not display the page content. Please double check your browser settings and try again.");
throw "Unrecognized object for length helper";
data['overflowTitle'] = 'More';
if (element[j].tagName.toUpperCase() === "INPUT" && element[j].type.toLowerCase() === "radio") { // radio button
if (element[j].tagName.toUpperCase() === "INPUT" && element[j].type.toLowerCase() === "radio") { // radio button
if (element.tagName.toUpperCase() === "INPUT" && element.type.toLowerCase() === "checkbox") {
if (element.tagName.toUpperCase() === "INPUT" && element.type.toLowerCase() === "radio") {
if (element.tagName.toUpperCase() === "INPUT" && element.type.toLowerCase() === "radio") {
if (element.tagName.toUpperCase() === "INPUT" && element.type.toLowerCase() === "file") {
if (element.tagName.toUpperCase() === "INPUT" && element.type.toLowerCase() === "file") {
var MooTreeIcon = ['I','L','Lminus','Lplus','Rminus','Rplus','T','Tminus','Tplus','closed','doc','open','minus','plus'];
var MooTreeIcon = ['I','L','Lminus','Lplus','Rminus','Rplus','T','Tminus','Tplus','closed','doc','open','minus','plus'];
this.div.gadget.className = 'mooTree_gadget ' + this.getImgClass( ( this.control.grid ? ( this.control.root == this ? (this.nodes.length ? 'R' : '') : (this.last?'L':'T') ) : '') + (this.nodes.length ? (this.open?'minus':'plus') : '') );
this.div.gadget.className = 'mooTree_gadget ' + this.getImgClass( ( this.control.grid ? ( this.control.root == this ? (this.nodes.length ? 'R' : '') : (this.last?'L':'T') ) : '') + (this.nodes.length ? (this.open?'minus':'plus') : '') );
if(this.div.sub) this.div.sub.style.display = this.open ? 'block' : 'none';
document.id('listNodeIFrame').set('src', 'about:blank');
'text': 'loading',
this.insertField(this.createField({fieldType:'ERROR',value: data.errors[i]}), 'ERROR');
if(where == 'ERROR') field.inject(document.id('PERSONAL_row'), 'before');
else if(where == 'PERSONAL') field.inject(document.id('GLOBAL_row'), 'before');
search.set('chart', ret.chart);
search.set('date', ret.date);
el.set('dirty',false);
this.shareTree.get('-1').getUserControl().set('dirty',true).swapClass('inherited','explicit');
node.insertField(node.createField({fieldType:'ERROR',value:resourceBundle.get('managewidgets.js.PleaseSelectAnItemToEditO_670')}), 'ERROR');
['button', 'input', 'a'].contains(event.target.get('tag'))
if(text && text != "ok") {
panel.set('downloaded', 'false');
if(returnJSON[node] != "ok") {
chart.set('stale', true);
if (window.pb) pb.fullScreenPropkey = (screen == 'full');
if (screen == "full") {
$elem.raty('destroy');
$elem.raty('score');
$elem.raty('reload');
elem.raty('score', self.savedRating.value);
if (H > 11) { value["a"]="PM"; }
else { value["a"]="AM"; }
else if (val.substring(i_val,i_val+2).toLowerCase()=="pm") {ampm="PM";}
if (val.substring(i_val,i_val+2).toLowerCase()=="am") {ampm="AM";}
if (val.substring(i_val,i_val+2).toLowerCase()=="am") {ampm="AM";}
else if (val.substring(i_val,i_val+2).toLowerCase()=="pm") {ampm="PM";}
if (hh<12 && ampm=="PM") { hh=hh-0+12; }
else if (hh>11 && ampm=="AM") { hh-=12; }
generalFormats=new Array('y-M-d','MMM d, y','MMM d,y','y-MMM-d','d-MMM-y','MMM d');
generalFormats=new Array('y-M-d','MMM d, y','MMM d,y','y-MMM-d','d-MMM-y','MMM d');
generalFormats=new Array('y-M-d','MMM d, y','MMM d,y','y-MMM-d','d-MMM-y','MMM d');
if (clone.get('html').test('radio')){
window.top.location.href = SetQueryStringValue(SetQueryStringValue(cleanHref(window.top.location.href), 'action', 'index'), 'navr', url);
var launch = (window.parent.location && window.parent.location.search) ? getQueryVariable('launch', queryStringMinusQuestion) : false;
menu.style.display = 'block'; // Show the menu.
var title = resourceBundle.get('utils.js.CandidateSearch_123') || 'Candidate Search';
if (sendUpdateResult == 'cancel') return;
if (approve=="approve") alert(resourceBundle.get('approval.js.YourApprov_5'));
else if ($("#mode").val()=="screen") {
document.location = SetQueryStringValue(document.location.search,"approve",approve);
if (approve=="approve") alert(resourceBundle.get('approval.js.YourApprov_5'));
var formOrPacket = 'Packet';
newRow.set('key', key);
SubmitApproval('Approve', false);
SubmitApproval('Decline', false);
if(retBeginApproval != "ok") {
if (resp.substring(0,2)=="ok") {
if (resp=="ok") {
if ($("#mode").val()=="tab") {
alert(resourceBundle.get('validate.js.YouCanOnlyUploadAFileOfTh_722') + "\r\n\r\n" + validFileTypes.replace(/ /g,'\r\n'));
throw 'webform is dependent on dependentDropdowns module';
setupTypeToSearchDropdown("question", true, selectedQuestion, function() {
setupTypeToSearchDropdown("answer", loadAnswersOnStart, selectedAnswerOption);
['fieldDependencyId','formName','name','question','operator','answer', 'answer_text', 'action','dependentFieldGroup'].each(function(key) {
['fieldDependencyId','formName','name','question','operator','answer', 'answer_text', 'action','dependentFieldGroup'].each(function(key) {
alert('linkElem (' + questionName + (copyToProfile ? '_prepopCopydata_column_link) could not be found' : '_prepopdata_column_link) could not be found'));
alert('linkElem (' + questionName + (copyToProfile ? '_prepopCopydata_column_link) could not be found' : '_prepopdata_column_link) could not be found'));
throw('linkElem (' + questionName + (copyToProfile ? '_prepopCopydata_column_link) could not be found' : '_prepopdata_column_link) could not be found'));
throw('linkElem (' + questionName + (copyToProfile ? '_prepopCopydata_column_link) could not be found' : '_prepopdata_column_link) could not be found'));
alert("Internal Error: Prepopulation data could not be derived from column picker.");
var opt = new Option('Prepopulate with Profile Link Field');
opt.title = 'This iForm field will intially be prepopulated with value from the Profile Link Field';
var opt1 = new Option('Prepopulate with Custom Text');
opt1.title = 'This iForm field will intially be prepopulated with custom text value';
var opt2 = new Option('Prepopulate with Search Column Value');
opt2.title = 'This iForm field will initially be prepopulated with data from the selected search column';
var opt4 = new Option('Copy to Profile Field');
opt4.title = 'This iForm field will be copied to the selected profile field';
form.action = "icims2?module=AppForm&action=editInputData&showAdvanced=" + showAdvanced + "&type=" + encodeURIComponent(inputType) + "&callback=" + encodeURIComponent(resultField.id) + "&fieldType=" + (isCustomField ? "fields" : "iforms") + (isGroup ? "&isGroup="+fieldId : "") + (formName != null ? "&form="+formName : '') + "&fieldName="+fieldName;
if (document.id(elem).hasClass('default')) elem.value = "<default/>";
var folderChange = 'Job Approval' === $('#approvalType').val() && 'false' === $('#pendingApproval').val();
if (retBeginApproval != 'ok') {
text: 'key',
if (isInvalid || isInvalidIE || isInvalidFF) throw "Invalid Browser";
return "one";
return "other";
return escape[chr] || "&amp;";
.replace(/"/g, '\\"')    // closing quote character
startRule = "start";
if (input.substr(pos, 6) === "plural") {
result1 = "plural";
matchFailed("\"plural\"");
matchFailed("\"select\"");
if (input.substr(pos, 6) === "offset") {
result1 = "offset";
matchFailed("\"offset\"");
expectedHumanized = "end of input";
foundHumanized = found ? quote(found) : "end of input";
begin: 'function(d){\nvar r = "";\n',
end  : "return r;\n}"
element.style.backgroundColor = "red";
if (element.tagName.toUpperCase() === "INPUT" && element.type.toLowerCase() === "checkbox") {
} else if (element.tagName.toUpperCase() === "INPUT" && element.type.toLowerCase() === "radio") {
} else if (element.tagName.toUpperCase() === "INPUT" && element.type.toLowerCase() === "radio") {
element.style.backgroundColor = "red";
if (element.tagName.toUpperCase() === "INPUT" && element.type.toLowerCase() === "checkbox") {
} else if (element.tagName.toUpperCase() === "INPUT" && element.type.toLowerCase() === "radio") {
} else if (element.tagName.toUpperCase() === "INPUT" && element.type.toLowerCase() === "radio") {
.prepend('<span class="glyphicons glyphicons-exclamation-sign"></span><span class="sr-only">Error</span>');
localStorage.setItem([profileId, $(this).attr('id'), 'collapsed'].join('-'), 'true');
localStorage.setItem([profileId, $(this).attr('id'), 'collapsed'].join('-'), 'false');
var localStorageInfo = localStorage.getItem([profileId, $collapse.attr('id'), 'collapsed'].join('-'));
document.location.href = SetQueryStringValue(document.location.search, "status", elem.options[elem.selectedIndex].value);
if (ret2 != null && ret2 == "OK") {
} else if (ret2 == "OK") {
} else if (ret2.substring(6)=="CYCLE") {
} else if (ret2.substring(6)=="EXISTS") {
window.opener.newGroup_callback("OK", primaryid);
var canvas = document.body.querySelector('canvas');
var elements = document.body.querySelector('canvas') ? $('div.text') : $('div.t');
ICIMS.setInnerHtml(this, ICIMS.getText(this).replace(regex, '$1<span class="highlightedText">$2</span>$3'));
var refreshUrl = SetQueryStringValue(cleanHref(window.location.href), 'delay', delay);
if ("document" in self) {
if (!('Element' in view)) return;
, protoProp = "prototype"
force !== false && "add"
'template{display:none}'
'elements': options.elements || 'abbr article aside audio bdi canvas data datalist details dialog figcaption figure footer header hgroup main mark meter nav output picture progress section summary template time video',
document.getElementById('iCIMS_NoCookiesMessage').style.display = 'block';
A( "js", "Yes");
A( "jo", navigator.javaEnabled()?"Yes":"No");
A( "jo", navigator.javaEnabled()?"Yes":"No");
if ('interactive' == this.readyState) {
if( $('#gdpr_container').attr('style') === "display: block;")  {
OpenNewWindow(resetAnchor.href ,'width=450,height=270,toolbar=no,resizable,location=no,directories=no,status=no,scrollbars=yes');
var jun1utc = new Date("1 Jun 2006 00:00:00 UTC");
var jan1utc = new Date("1 Jan 2006 00:00:00 UTC");
var jan1 = new Date("1 Jan 2006 00:00:00");
var jun1 = new Date("1 Jun 2006 00:00:00");
var formId = (page == 'candidate') || (page == 'eeo') ? 'profileForm' : (page == 'questions') ? 'questions' : '';
var html = "<div class=\"iCIMS_Expandable_Nav_Wrapper\">";
if(result[0] !=='candidateSearchSessionUUID' && result[0] !== 'launch') {
var backLabel = pb.i18n['showprofileframe_handlebars.jsp.Back_421'] || 'Back';
'<div class="searchCrumbContainer">',
'profileMethod': 'Resume'
'profileMethod': 'Online Form'
'resumeUploadMethod': 'Computer'
'resumeUploadMethod': 'Google Drive'
'eeProductList': 'search results',
'eeProductList': 'search results',
post('addEventListener', 'play');
post('addEventListener', 'pause');
post('addEventListener', 'finish');
'profileMethod': 'No Social Account'
wildcard: '%QUERY',
9: 'tab',
13: 'enter'
childNode.div.main.set('path', childNode.data.path);
'type': 'category'
'type': type || 'category',
search.set('chart', ret.chart);
search.set('date', ret.date);
apiSearchUrl: 'module=AppChart&action=chartFromApiRequest',
{value: 'Bar Chart', label: 'Bar Chart', id: 'barRadio', name: 'chartGroup', type: 'radio'},
{value: 'Bar Chart', label: 'Bar Chart', id: 'barRadio', name: 'chartGroup', type: 'radio'},
{value: 'Donut Chart', label: 'Donut Chart', id: 'donutRadio', name: 'chartGroup', type: 'radio'},
{value: 'Donut Chart', label: 'Donut Chart', id: 'donutRadio', name: 'chartGroup', type: 'radio'},
{value: 'Line Chart', label: 'Line Chart', id: 'lineRadio', name: 'chartGroup', type: 'radio'},
{value: 'Line Chart', label: 'Line Chart', id: 'lineRadio', name: 'chartGroup', type: 'radio'},
{value: 'Pie Chart', label: 'Pie Chart', id: 'pieRadio', name: 'chartGroup', type: 'radio'},
{value: 'Pie Chart', label: 'Pie Chart', id: 'pieRadio', name: 'chartGroup', type: 'radio'},
{value: 'Scatter Chart', label: 'Scatter Chart', id: 'scatterRadio', name: 'chartGroup', type: 'radio'},
{value: 'Scatter Chart', label: 'Scatter Chart', id: 'scatterRadio', name: 'chartGroup', type: 'radio'},
{value: 'Time Series', label: 'Time Series', id: 'dateRadio', name: 'chartGroup', type: 'radio'},
{value: 'Time Series', label: 'Time Series', id: 'dateRadio', name: 'chartGroup', type: 'radio'},
{value: 'Orientation', label: 'View horizontal', id: 'orientationCheckbox', group: '', type: 'checkbox'}
{value: 'Orientation', label: 'View horizontal', id: 'orientationCheckbox', group: '', type: 'checkbox'}
insertTree('mooTree', 'User Groups', groups, true, false, true, false);
var _viewType = (state ? 'default' : 'legacy');
var message = '<p><span class="glyphicons glyphicons glyphicons-info-sign"></span>E-mail validation detected following concerns:</p>';
var resultText = data[i].value.replace(re, "<strong>$&</strong>");
if ($(element).attr('type') === 'email') {
if ($(element).attr('type') === 'email') {
keywordObj.fullTextTypes = ICIMS.jsonDecode('[{"type":"Person","enabled":"1"},{"type":"Submittal","enabled":"1"}]');
massAction('status()');
return "receipt";
var event = document.createEvent("Event");
event.initEvent("change", false, true);
launchToReplaceCurrentWindow(massActionUrl_offer(url, slot), 'self');
var loginURL = "https://" + cccURL + "/" + (onboard == "true" ? "onboard" : "jobs") + "/login?loginAs=" + encryptedLogin +
url = SetQueryStringValue(url, "row", row);
if ('btn-group active' === children[i].className) {
if(groupBoxes[i].parentElement.nodeName === "LABEL") {
if(elem.parentElement.nodeName === "LABEL") elem.parentElement.addClass('checkbox-checked');
if(boxes[i].parentElement.nodeName === "LABEL") {
datePicker.today.set('hr', 0);
datePicker.today.set('min', 0);
datePicker.today.set('hr', 23);
datePicker.today.set('min', 59);
this.breadcrumbs.grab(this.createRelationBreadcrumb('Home', relations.length), 'top');
var category = this.selectedCategory == "-1" ? "All Columns" : this.selectedCategory;
if(typeOf(json[i][attribute]) != 'collection') category.set(attribute, json[i][attribute]);
title: "Host",
title: "Category",
return new Alert('warning', 'glyphicons glyphicons-warning-sign', text, options);
return new Alert('warning', 'glyphicons glyphicons-warning-sign', text, options);
title: "Event ID",
title: "Event Name",
title: "Folder",
profileLinkQuickSearch('Job', ' ', '', 'availableItems', false, selectedFilter.get("url"), true, '&includeHiddenFilters=1&C_$T{Job}.$C{Status}_Value=D' + document.id("openJobStatusIds").value, searchID, outputID);
profileLinkQuickSearch('Job', ' ', '', 'availableItems', false, selectedFilter.get("url"), true, '&includeHiddenFilters=1&C_$T{Job}.$C{Status}_Value=D' + document.id("openJobStatusIds").value + "&C_$T{Job}.$T{JobContent3024}.$C{ContentIntPersonIn}_Value=D@userid", searchID, outputID);
profileLinkQuickSearch('Job', ' ', '', 'availableItems', false, selectedFilter.get("url"), true, '&includeHiddenFilters=1&C_$T{Job}.$C{Status}_Value=D' + document.id("openJobStatusIds").value + "&C_$T{Job}.$T{JobContent3023}.$C{ContentIntPersonIn}_Value=D@userid", searchID, outputID);
profileLinkQuickSearch('Job', ' ', '', 'availableItems', false, selectedFilter.get("url"), true, extraParams, searchID, outputID);
profileLinkQuickSearch('Job', ' ', '', 'availableItems', false, selectedFilter.get("url"), true, '&includeHiddenFilters=1&C_$T{Job}.$C{Status}_Value=D' + document.id("allJobStatusIds").value + '&C_$T{Job}.$C{JobID}_Value=D' + csv, searchID, outputID, " - ", sortAvailableList);
if (table.toLowerCase() == "company" && isAddress) {
option.set("profile", table);
if (id !== 'any') this.update('any', newStatus);
if (item[0] === 'actions' && item[1] === 'OfferWizard') {
if (item[0] === 'actions' && item[1] === 'Hire') {
if (item[0] === 'actions' && item[1] === 'Hire') {
jQuery('select:first').focus();
title: "Start Date",
format: "{0:MM/dd/yyyy HH:mm tt}", // How Kendo should understand the date format
return new Alert('success', 'glyphicons glyphicons-ok-sign', text, options);
return new Alert('success', 'glyphicons glyphicons-ok-sign', text, options);
return new Alert('info', 'glyphicons glyphicons-info-sign', text, options);
return new Alert('info', 'glyphicons glyphicons-info-sign', text, options);
return new Alert('danger', 'glyphicons glyphicons-exclamation-sign', text, options);
return new Alert('danger', 'glyphicons glyphicons-exclamation-sign', text, options);
return [...document.querySelectorAll(`[name*=${escapedId}], [id*=${escapedId}], [for*=${escapedId}]`)];
const formattedValue = salaryConsequenceFields[outputId][outputId] === '(blank)' ? salaryConsequenceFields[outputId][outputId] : fullSalary;
fieldObj[key] = '(blank)';
const formattedValue = salaryConsequenceFields[salaryFieldId][salaryFieldId] === '(blank)' ? salaryConsequenceFields[salaryFieldId][outputId] : fullSalary;
const formattedValue = salaryConsequenceFields[salaryFieldId][salaryFieldId] === '(blank)' ? salaryConsequenceFields[salaryFieldId][salaryFieldId] : fullSalary;
const formattedValue = salaryConsequenceFields[salaryFieldId][salaryFieldId] === '(blank)' ? salaryConsequenceFields[salaryFieldId][salaryFieldId] : fullSalary;
ajax.url = replaceUrlParam(ajax.url, 'filter', consequence.actionValue);
title: "End Date",
format: "{0:MM/dd/yyyy HH:mm tt}", // How Kendo should understand the date format
gte: "On or After",
lt: "Before"
title: 'Add User'
title: "Change User Group"
title: "Remove Users"
title: "Change Licenses Count for Integration"
title: "Manually Update Licenses Count"
$alertText.text('This action will have no effect on your number of remaining full access user licenses.');
title: "<input class='checkAll' type='checkbox' />"
title: "First Name",
title: "Last Name",
title: "Login Name",
title: "Last Login",
format: "{0:MM/dd/yyyy HH:mm tt}", // How Kendo should understand the date format
return "<span data-column='lastLogin' data-userId='" + data.userId + "'>" + (data.lastLogin !== null ? kendo.toString(data.lastLogin, "MM/dd/yyyy HH:mm tt") : resourceBundle.get('icims.licensemanager.js.never')) + "</span>";
gte: "On or After",
lt: "Before"
title: "Group Name",
title: "License Count",
title: "Number of Users in Group",
title: "Can Login to iCIMS Talent Platform",
title: "Edit License Count",
label: 'Edit License Count',
controller.changeLoginStatus(groupId, 'integration', event.target.checked, function(success) {
var data = utils.getGroupById(groupId, 'integration');
label: 'Cancel',
label: 'Add User',
label: 'Cancel',
label: 'Move Selected Users'
var alertBase = 'alert modal-alert';
$alertText.text("Your number of remaining full access user licenses will be unaffected from this operation.");
label: 'Cancel',
label: 'Remove Selected Users'
label: 'Cancel',
label: 'Update License Count'
$alertText.text("Please enter a valid number greater than 0.");
label: 'Cancel',
label: 'Update Purchased License Count'
$alertText.text("Please enter a valid number greater than 0.");
if (res === "ok") {
if (res === "ok") {
var newCount = operation === "add" ? currentNum + count : currentNum - count;
state.remainingLicenses = operation === "add" ? state.remainingLicenses + count : state.remainingLicenses - count;
var baseAlertClasses = 'alert modal-alert';
$alertText.text("You do not have sufficient full access user licenses to add a user to this group.");
if ((licenseType && licenseType === "limited") || utils.getGroupWrapperById(destinationGroup).attr('data-licensetype') === "limited") {
$alertText.text("This action will not affect your remaining full access user license count.");
var msg = msg || 'An unexpected error occured. Please try again later. If the error persists please contact support.';
message = 'Loading, please wait...';
return jQuery(item).on((event || 'click') + '.modal', function () { return _this.show(); });
return jQuery(item).on((event || 'click') + '.modal', function () { return _this.hide(); });
eventOut = 'click';
eventIn = 'click';
eventIn = 'focus';
const escapeId = cssEscape(`Row.${fieldId}`);
if (ctx.stack && !ctx.type) { return stylize(ctx.stack, 'red'); }
error.push(stylize((ctx.line - 1) + ' ' + extract[0], 'grey'));
stylize(stylize(stylize(extract[1][ctx.column], 'bold') +
extract[1].slice(ctx.column + 1), 'red'), 'inverse');
extract[1].slice(ctx.column + 1), 'red'), 'inverse');
error.push(stylize((ctx.line + 1) + ' ' + extract[2], 'grey'));
message += stylize(ctx.type + 'Error: ' + ctx.message, 'red');
message += stylize(' in ', 'red') + ctx.filename +
stylize(' on line ' + ctx.line + ', column ' + (ctx.column + 1) + ':', 'grey');
message += stylize(ctx.callLine, 'grey') + ' ' + ctx.callExtract + '/n';
message += stylize('from ', 'red') + (ctx.filename || '') + '/n';
return '"' + a[0].trim() + '":"' + a[1].replace(/"/g, '\\"') + '"';
message = message.replace(`{{${key}}}`, value);
iconName: 'check',
iconColor: 'positive',
iconColor: 'negative',
iconColor: 'negative',
iconColor: 'negative',
query.filters.push({ field: 'TOffer_FRecent', operator: 'contains', value: 'yes' });
query.filters.push({ field: 'TOffer_FRecent', operator: 'contains', value: 'yes' });
DRAFT: 'draft',
ARCHIVED: 'archived'
CONTINUE: 'continue',
ARCHIVE: 'archive',
DOWNLOAD: 'download',
RESCIND: 'rescind',
SKIP: 'skip',
EDIT: 'edit',
EXTEND: 'extend',
RESTORE: 'restore',
[OFFER_ACTIONS.CONTINUE]: { resource: 'offer', scopes: ['modify'] },
archive: { resource: 'offer', scopes: ['delete'] },
restore: { resource: 'offer', scopes: ['delete'] },
download: { resource: 'offer', scopes: ['view'] },
downloadSigned: { resource: 'offer', scopes: ['view'] },
resend: { resource: 'offer', scopes: ['extend'] },
rescind: { resource: 'offer', scopes: ['extend'] },
edit: { resource: 'offer', scopes: ['extend', 'modify'] },
edit: { resource: 'offer', scopes: ['extend', 'modify'] },
edit: { resource: 'offer', scopes: ['extend', 'modify'] },
extend: { resource: 'offer', scopes: ['extend'] },
editAccess: { resource: 'offer.permission', scopes: ['view', 'change'] }
editAccess: { resource: 'offer.permission', scopes: ['view', 'change'] }
user: 'User',
group: 'User Group'
something: 'default value'
const viewType = state ? 'default' : 'legacy';
title: 'TITLE',
description: 'DESCRIPTION',
body: 'BODY',
trashed: 'TRASHED',
permissions: 'PERMISSIONS'
{ 'id': 1, 'status': 'draft', 'display': 'offerletter:status.display.draft', folder: OFFER_PREDEFINED_FILTERS.DRAFT },
const args = `status=yes, toolbar=no, location=no, menubar=no, directories=no, resizable=yes, scrollbars=yes, height=${height}, width=${width}, left=${((screen.width-width)/2)}, top=${((screen.height-height)/2)}`;
alert('Error: Cannot open pop-up. Please make sure pop-up blockers are disabled.');
let bodyContent = 'The attached resume is submitted for your consideration.';
const _mailtoUrl = `mailto:${emailInfo.resumeAddress[0]}+${lang}@${emailInfo.resumeAddress[1]}?subject=Resume for consideration - displayid:&body=${bodyContent}`;
