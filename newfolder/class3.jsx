template: '#= kendo.toString(new Date(parseInt(acceptedOnTimestamp)), \'MM/dd/yyyy hh:mm tt\') #'
<BusyIndicator aria-label="Saving" fullscreen />
<Alert variant={this.state.statusUpdateFailed ? 'error' : 'warning'} className={'forced-auto-launch-alert'}>{this.state.statusUpdateFailed ?
{t('common:page', {currentPage, totalPages})}
export default translate(['common', 'offerletter'])(DocumentOutline);
<div className={`${radialProgressColor} fix`}></div>
{ title: 'Paragraph', block: 'p', toggle: false },
{ title: 'Heading 1', block: 'h1', onformat: applyGUID },
{ title: 'Heading 2', block: 'h2', onformat: applyGUID },
{ title: 'Heading 3', block: 'h3', onformat: applyGUID },
this.blankLine = '<p><br data-mce-bogus="1" /></p>';
a: ['href', 'name', 'target', 'title'],
} else if ($element.context.data === 'Â ') {
return tinymce.activeEditor.getContent({ format: 'raw' });
"if (navigator.userAgent.search('Edge') >= 0) {	// Edge is SPECIAL"
if (e.command === 'Indent') {
<div className={`tiny-mce-wrapper ${this.state.initialized ? '' : 'not-initialized'}`}>
'table colorpicker spellchecker powerpaste hr link media image textcolor print noneditable icimsvariable icimsattachment icimsrollups lists',
powerpaste_word_import: 'clean',
textAlign: 'center'
className={`shadow-letter page ${this.state.pageSize}`}
className={`shadow-builder page ${this.state.pageSize}`}
export default translate(['common', 'offerletter'], { withRef: true })(
icon = 'ok';
const PROCESSING = 'PROCESSING';
alertInfo = {variant: 'warning', translationKey: 'esignature:configuration.error.alerts.unhandled'};
const PROCESSING = 'PROCESSING';
const PROCESSING = 'PROCESSING';
} else if (!proposedConfig.publicKey.toUpperCase().includes('BEGIN PUBLIC KEY')) {
} else if (proposedConfig.privateKey !== null && !proposedConfig.privateKey.toUpperCase().includes('BEGIN RSA PRIVATE KEY')) {
<Button id="esignature-saveButton" variant="primary" alt={this.props.t('esignature:configuration.buttons.altText.saveintegration')}
<Button id="esignature-deleteButton" variant="danger" alt={this.props.t('esignature:configuration.buttons.altText.deleteintegration')}
variant="primary" {...buttonProps} alt={this.props.t('esignature:configuration.buttons.altText.nextbutton')}
const cssClass = this.props.isUpdate ? 'update' : 'create';
const cssClass = this.props.isUpdate ? 'update' : 'create';
<div className={`icimsfilterpanel container-fluid ${this.props.className}`}>
emptyMsg: 'No Results Found'
options.push(<li role="separator" className="divider" key={`divider-${ index }`}>{option.dividerTitle}</li>);
<a href={recruiter.link} title={t('common:recruiter')}>{recruiter.display}</a>
trigger: is.ios() ? 'click' : 'manual',
trigger: is.ios() ? 'click' : 'manual',
keys: 'Command + C'
style={is.ios() ? 'default' : 'primary'}
this.refs.combobox.getComboBoxElement().find('.k-i-arrow-s').replaceWith('<span class="caret"></span>');
template: `<span class='filter-dropdown-item'>#: ${this.props.dropDownTextField} #<span class="glyphicons glyphicons-ok"></span></span>`
something: 'default value'
<span className="icimsMobilePager-index-button">{`${this.props.currentItemIndex + 1} of ${this.props.pageItems.length}`}</span>
<Button className="addButton primaryPickerButton" variant="primary">{addButtonLabel}</Button>
emptyMsg: 'No Results Found'
{(this.props.iconLocation === 'start') ? iconDisplay : null}
<div className="btn-group btn-group-justified pull-right flatlistitem-button-group" role="group" aria-label="Basic example">
{(this.props.iconLocation === 'end') ? iconDisplay : null}
editPlaceholder: 'Enter Title',
iconLocation: 'start',
{(this.props.iconLocation === 'start') ? iconDisplay : null}
activeClassName="editing"
<div className="btn-group btn-group-justified pull-right flatlistitem-button-group" role="group" aria-label="Basic example">
{(this.props.iconLocation === 'end') ? iconDisplay : null}
editPlaceholder: 'Enter Title',
iconLocation: 'start'
staticElement: 'span',
const activeglyph = (opt.id === activeId) ? this.props.activeGlyph : 'blank';
message: 'Loading, please wait...',
something: 'default value'
$(this.refs.tags).find('[data-add-link]').text('Add Tag');
$(this.refs.tags).find('[data-add-link]').prepend('<span class="icims-tags-icon glyphicons glyphicons-tag"></span>');
alert('Please specify a valid record number'); // eslint-disable-line
let nlogic = 'and';
nlogic = 'or';
logic: 'and',
template: (templateData) => `<div class="checkbox-wrapper"><input id='${prefix}-${templateData[idKey]}' type='checkbox' class='${this.props.checkboxClassName} checkbox' value='${templateData[idKey]}' /></div>`
col.groupHeaderTemplate = '<input type="checkbox" class="groupcheckbox" value="#= value #"/> #= value #';
col.filterable.itemTemplate = (templateData) => `<li class='k-item'><label class='k-label'><input type='checkbox' name='${templateData.field}' value='#= data.id #'/>#= data.${key} || data.all #</label></li>`;
<div className={`grid-wrapper ${gwrapperClass}`}>
subLabelClasses = 'text-danger text-italic';
alert(data.error || 'An error occurred while attempting to change the status.'); // eslint-disable-line
<div id="icimsSubmittalButtonsContainer" className={`row submittal-container ${this.props.view}`}>
<Button variant="primary" size="small" className="integration-status-response-link"
<Button className="next-button" variant="primary" onClick={this.handleNextButtonClick}>{this.props.nextButtonText}</Button>
const checkTemplate = '<input type="checkbox" class="checkbox" name="uid[]" value="#= value #" />';
$grid.find('.k-grid-header').find('[data-title="headercheckbox"]').empty().append('<input type="checkbox" class="headercheckbox" />');
t('common:loading')
export default translate(['common', 'offerletter'])(Approver);
icon: 'job',
export default translate(['common', 'offerletter'])(OfferJobSearch);
<nav className={`navbar navbar-default offer-navbar offer-acknowledgement-navbar offer-navbar-${shouldShowAtTop(showAtTop)}`}>
export default translate(['common', 'offerletter'])(connect(mapStateToProps, mapDispatchToProps)(OfferLetterHeader));
export default translate(['common', 'offerletter'])(connect(mapStateToProps, null)(OfferPageMessage));
if (!updatedCategory.label.replace(/\s/g, '').length) return { msg: 'empty' };
if (defaultCategories.find((category) => t(category.label).toLowerCase() === updatedCategory.label.toLowerCase())) return { msg: 'pinned' };
if (categories.find((category) => (OfferCategories.isExists(category, updatedCategory)))) return { msg: 'exists' };
confirmText={t('common:confirm')}
cancelText={t('common:cancel')}
{this.isEntitled('create') ?
icon="add"
variant="link"
alt="add category"
busyText={t('common:loading')}
return this.isEntitled('view') ? (
export default translate(['common', 'offerletter'])(OfferCategories);
icon="close"
variant="link"
return this.isEntitled('modify') ?
icon="pencil"
variant="link"
role={'link'}
export default translate(['common', 'offerletter'])(OfferCategory);
copy: {resource: 'offer.template', scopes: ['view', 'create']},
copy: {resource: 'offer.template', scopes: ['view', 'create']},
title={t(`common:${defaultAction}`)}
{t(`common:${defaultAction}`)}
title={t(`common:${defaultAction}`)}
{t(`common:${action}`)}
return (permissions.CAN_VIEW.toLowerCase() === 'yes');
return (permissions.CAN_EDIT.toLowerCase() === 'yes');
return (permissions.CAN_DELETE.toLowerCase() === 'yes');
<a tabIndex={0} role={'link'} className="name-link">
{item.category ? <span><Icon name="folder" alt="Folder" className="folder-icon" /><p>{item.category.label}</p></span> : null}
let defaultAction = 'edit';
let actions = ['delete', 'copy'];
defaultAction = 'restore';
export default translate(['common', 'offerletter'])(OfferTemplateResultItem);
defaultAction = DEFAULT_ACTIONS[statusValue + (this.props.offer.deliveryTypeValue === 'portal' ? '.portal' : '')];
if (offer.status.statusValue === APPROVAL_APPROVED && offer.deliveryTypeValue === 'download') {
.then(() => offer.deliveryTypeValue === 'portal')
variant={defaultAction === EXTEND || defaultAction === DOWNLOAD || defaultAction === DOWNLOAD_SIGNED ? 'primary' : 'default'}
variant={defaultAction === EXTEND || defaultAction === DOWNLOAD || defaultAction === DOWNLOAD_SIGNED ? 'primary' : 'default'}
confirmText={t('common:ok')}
cancelText={t('common:cancel')}
export default translate(['common', 'offerletter'])(OfferButtons);
const BANNED = { symbol: 'banned', color: 'negative' };
const CHECK = { symbol: 'check', color: 'positive' };
"[DRAFT]: { symbol: 'pencil'	},"
className={`offer-candidate ${autoFocus ? 'nextInLine' : ''}`}
role={'link'}
export default translate(['common', 'offerletter'])(OfferResultItem);
brief = t('common:dateTime', { value: (updatedDate || createdDate) });
export default translate(['common', 'offerletter'])(OfferStatus);
busyText={t('common:loading')}
export default translate(['common', 'offerletter'])(OfferResultList);
export default translate(['common', 'offerletter'])(OfferFilterKeyword);
export default translate(['common', 'offerletter'])(OfferFilterStatus);
export default translate(['common', 'offerletter'])(OfferSort);
this.iframeRef.contentWindow.postMessage('save', `https://${document.domain}`);
{!this.state.loaded && <BusyIndicator aria-label={t('common:loading')} />}
export default translate(['common', 'offerletter'], { withRef: true })(OfferEmail);
confirmText={t('common:confirm')}
cancelText={t('common:cancel')}
return this.props.entitlements['offer.template'] && this.props.entitlements['offer.template'].includes('modify');
confirmText={t('common:edit')}
cancelText={t('common:cancel')}
confirmText={t('common:confirm')}
cancelText={t('common:cancel')}
confirmText={t('common:confirm')}
cancelText={t('common:cancel')}
role={'link'}
variant={this.state.nextTemplateId === -1 ? 'error' : 'info'}
busyText={t('common:loading')}
export default translate(['common', 'offerletter'])(OfferTemplateResultList);
export default translate(['common', 'offerletter'])(OfferTemplateSearch);
t('common:loading')
export default translate(['common', 'offerletter'])(Approver);
value: 'approve',
icon: 'check',
value: 'copy',
icon: 'copy'
return `${error ? t(error) : name} ${friendlyRelationName ? friendlyRelationName : ''}`;
let name = user ? t('common:loading') : t('common:unavailable');
let name = user ? t('common:loading') : t('common:unavailable');
label={`${order + 1} ${this.generateLabel(name)}`}
color={'negative'}
<div className={`offer-approver-info ${!user && 'unresolved'}`}>
variant="link"
icon="close"
export default translate(['common', 'offerletter'])(OfferApprover);
const name = this.state.loaded ? this.state.entityInfo.name : t('common:loading');
export default translate(['common', 'offerletter'])(OfferCard);
const details = <div>{t('common:to')}: {approvers}</div>;
export default translate(['common', 'offerletter'])(RevisionRecipients);
brief = t('common:dateTime', { value: (updatedDate || createdDate) });
export default translate(['common', 'offerletter'])(RevisionStatus);
title: t('common:people'),
icon: 'person',
title: t('common:usergroups'),
icon: 'group',
{!this.props.readOnly && this.state.editable && this.state.preset !== 'private' &&
{t('common:cancel')}
variant="primary"
{t('common:apply')}
export default translate(['common', 'offerletter'])(OfferPermissions);
<BusyIndicator aria-label={t('common:loading')} />
export default translate(['common', 'offerletter'])(OfferPermissionsModal);
if (!entitlements[entitlementsKey].includes('view')) {
variant="link"
name={preset === 'everyone' ? 'unlock' : 'lock'}
name={preset === 'everyone' ? 'unlock' : 'lock'}
name={preset === 'everyone' ? 'unlock' : 'lock'}
color={preset === 'everyone' ? 'positive' : 'default'}
color={preset === 'everyone' ? 'positive' : 'default'}
{isLoading ? t('common:loading') : t(`offerletter:permission.${preset}`)}
export default translate(['common', 'offerletter'], { wait: true })(PermissionButtonLink);
variant="link"
<MenuItem eventKey={'use'}>
<MenuItem eventKey={'edit'}>
<Button variant="link" icon="close" onClick={this.handleDelete.bind(this)}
<Button variant="link" icon="close" onClick={this.handleDelete.bind(this)}
aria-label={t('common:delete')}
<Button className="spacer" icon="close" disabled />
export default translate(['common', 'offerletter'])(PermissionEntry);
t('common:loading')
export default translate(['common', 'offerletter'])(Approver);
export default translate(['common', 'offerletter'])(OfferRevision);
export default translate(['common', 'offerletter'])(OfferRevisions);
variant={defaultAction === ACTIONS.EXTEND || defaultAction === ACTIONS.DOWNLOAD || defaultAction === ACTIONS.DOWNLOAD_SIGNED ? 'primary' : 'default'}
variant={defaultAction === ACTIONS.EXTEND || defaultAction === ACTIONS.DOWNLOAD || defaultAction === ACTIONS.DOWNLOAD_SIGNED ? 'primary' : 'default'}
confirmText={t('common:ok')}
cancelText={t('common:cancel')}
export default translate(['common', 'offerletter'])(RevisionButtons);
return 'pencil';
return 'check';
return 'banned';
return <BusyIndicator aria-label={t('common:Loading')} />;
variant="primary"
alt={t('common:preview_name', { name: t('common:template')})}
export default translate(['common', 'offerletter'], { wait: true })(TemplateGrid);
<div className={`job-info ${restricted ? 'restricted' : ''}`}>
<Pill className="template-pill">{t('common:template')}</Pill> :
icon="close"
variant="link"
export default translate(['common', 'offerletter'])(JobAssociationItem);
<Button variant={'link'} className="clear-all" onClick={this.clearAssociationList.bind(this)}>
{t('common:cancel')}
variant="primary"
{t('common:apply')}
export default translate(['common', 'offerletter'])(TemplateAssociationModal);
{this.isEntitled('view') ? this.categoryDropdown() : null}
export default translate(['common', 'offerletter'])(TemplateSearch);
export default translate(['common', 'offerletter'], { withRef: true })(OfferPreviewSidebar);
<Button icon="close" variant="link" className="sidebar-close"
<BusyIndicator aria-label={t('common:loading')} />
<Button icon="close" variant="link" className="sidebar-close"
<Icon name={'folder'} /> {template.category.label}
export default translate(['common', 'offerletter'], { withRef: true })(TemplateSidebar);
return <BusyIndicator aria-label={t('common:Loading')} />;
return <Button variant="primary" className="btn-load-more" onClick={this.handleLoadMore.bind(this)}>{t('offerletter:load_more')}</Button>;
export default translate(['common', 'offerletter'], { wait: true })(TemplateTable);
key={`page_${index + 1}`}
<BusyIndicator aria-label="Loading" />
role={this.state.hasError ? 'complementary' : 'button'}
role={this.state.hasError ? 'complementary' : 'button'}
errorMessage: 'Unable to load PDF.',
if (['contact', 'job', 'Profile5'].indexOf(profile.profileType) > -1) {
if (['contact', 'job', 'Profile5'].indexOf(profile.profileType) > -1) {
} else if (['contact', 'submittal'].indexOf(profileQuickInfo.profileType) > -1) {
{['contact', 'job', 'submittal', 'Profile5', 'Profile8', 'Profile10', 'Profile13'].indexOf(profileQuickInfo.profileType) > -1 && fields.folder ?
{['contact', 'job', 'submittal', 'Profile5', 'Profile8', 'Profile10', 'Profile13'].indexOf(profileQuickInfo.profileType) > -1 && fields.folder ?
<div className={`star-rating ${profileQuickInfo.ratingsFieldHtml ? '' : ' NoDisplay'}`}
<span className={profilecardNameClass}>{noName ? 'Blank' : this.props.name}</span>
<div className="reviewmode-talentpool-btns btn-group btn-group-justified" data-toggle="buttons">
code = action.replace('this', `document.getElementById("${id}")`);
const statuses = ['success', 'fail', 'neutral'];
const statuses = ['success', 'fail', 'neutral'];
<li className={`progress-dot progress-dot-${ props.pending } ${ props.pending !== 'neutral' && props.opened === 'neutral' ? 'progress-dot-emphasis' : '' }`}>
<li className={`progress-dot progress-dot-${ props.opened } ${ props.opened !== 'neutral' && props.closed === 'neutral' ? 'progress-dot-emphasis' : '' }`}>
<li className={`progress-dot progress-dot-${ props.closed } ${ props.closed !== 'neutral' ? 'progress-dot-emphasis' : '' }`}>
<li className={`progress-dot progress-dot-${ props.pending } ${ props.pending !== 'neutral' && props.opened === 'neutral' ? 'progress-dot-emphasis' : '' }`}>
<li className={`progress-dot-bar progress-dot-bar-${ props.opened }`}>
<li className={`progress-dot progress-dot-${ props.opened } ${ props.opened !== 'neutral' && props.closed === 'neutral' ? 'progress-dot-emphasis' : '' }`}>
<li className={`progress-dot-bar progress-dot-bar-${ props.closed }`}>
<li className={`progress-dot progress-dot-${ props.closed } ${ props.closed !== 'neutral' ? 'progress-dot-emphasis' : '' }`}>
pending: 'neutral',
opened: 'neutral',
closed: 'neutral'
type={(buttonSet.dropdownOptions.length) ? 'split-dropdown' : 'button'}
caretClassName="resultlistitem-action-btn resultlistitem-action-caret default"
something: 'default value'
$('.k-grid-pager').find('.k-link, .k-pager-numbers').wrapAll('<div class="outer-wrapper"><div class="pager-wrapper"></div></div>');
$('.k-pager-first').replaceWith(`<a href="#" title="${ftitle}" class="${fclasses}" data-page="${fpage}">${t('common:first')}</a>`);
$('.k-pager-last').replaceWith(`<a href="#" title="${ltitle}" class="${lclasses}" data-page="${lpage}">${t('common:last')}</a>`);
resultsDisplay = <IcimsAlertMessage alertType={'info'} message={emptyMsgString} />;
else return `<i>${this.getLocaleMessage('conditional.fields.any').replace('#', '\\#')}</i>`;
else return `<i>${this.getLocaleMessage('conditional.fields.blank').replace('#', '\\#')}</i>`;
alert(this.getLocaleMessage('conditional.fields.export.dnload.support'));
alert(this.getLocaleMessage('conditional.fields.export.dnload.support'));
this.refs.grid.getKendoGrid().hideColumn('actions');
const necessaryFieldParts = ['Currency', 'Amount', 'Timeframe'];
const necessaryFieldParts = ['Currency', 'Amount', 'Timeframe'];
if (e.sender.value() === 'condition') {
<IcimsAlertMessage alertType={'danger'} message={eMessage} />
className={`step-indicator ${step.id === props.currentStep && 'active'} ${step.id < props.currentStep && 'complete'}`}
<div className={`step-number-line ${index === 0 ? 'step-number-line-hidden' : ''}`} />
<div className={`step-number-line ${index === steps.length - 1 ? 'step-number-line-hidden' : ''}`} />
export default translate(['common', 'offerletter'], { wait: true })(StepIndicator);
{t('common:cancel')}
{t('common:previous')}
{this.props.finishText ? this.props.finishText : t('common:finish')}
{t('common:next')}
const tabGroups = docToUse.querySelectorAll(`ul.profileTab.nav-tabs:not(.NoDisplay) a[id=${tab}]`);
'activityheader.jsx.emailSent_1': 'Email Sent',
'activityheader.jsx.emailReceived_2': 'Email Received',
'activityheader.jsx.resumeAdded_3': 'Resume Added',
'activityheader.jsx.resumeUpdated_4': 'Resume Updated',
'activitystream.jsx.LoadMore_3': 'Load More',
'activitystream.jsx.AllActivities_1': 'All Activities',
'activitystream.jsx.NoDataExists_2': 'No data exists',
'activitystream.jsx.Loading_4': 'Loading...',
'activitystream.jsx.inSFromNow_5': 'in {s} from now',
'activitystream.jsx.sAgo_6': '{s} ago',
'activitystream.jsx.numberDays_7': '{number} days',
'activitystream.jsx.weeksWeeks_8': '{weeks} weeks',
'activitystream.jsx.weeksWeek_9': '{weeks} week',
'activityperson.jsx.byPersonFirstNamePersonLastName_1': 'By {personFirstName} {personLastName}',
'activityfooter.jsx.to_1': 'To {subject}',
'activityfooter.jsx.about_2': 'About {subject}',
'activityfooter.jsx.with_3': 'With {subject}',
'activityfooter.jsx.for_4': 'For {subject}',
'activityfooter.jsx.from_5': 'From {subject}',
'activitychilditemlist.jsx.activityObjectWasSet_1': '{activity} - {object} was set',
'activitychilditemlist.jsx.activityObjectWasUpdated_2': '{activity} - {object} was updated',
'activitychilditemlist.jsx.activityObjectWasChangeTy_3': '{activity} - {object} was {changeTypeText}',
'activitychilditemlist.jsx.objectWasSetToChangedValu_4': '{object} was set to {changedValue}',
'activitychilditemlist.jsx.objectWasSetToBlank_5': '{object} was set to [Blank]',
'activitychilditemlist.jsx.objectWasUpdatedToChanged_6': '{object} was updated to {changedValue}',
'activitychilditemlist.jsx.objectWasUpdatedToBlank_7': '{object} was updated to [Blank]',
'activitychilditemlist.jsx.objectWasChangeTypeTextTo_8': '{object} was {changeTypeText} to {changedValue}',
'activitychilditemlist.jsx.objectWasChangeTypeTextTo_9': '{object} was {changeTypeText}',
'activitychilditemlist.jsx.objectWasSet_10': '{object} was set',
'activitychilditemlist.jsx.objectWasUpdated_11': '{object} was updated',
'activitychilditemlist.jsx.objectWasChangeTypeText_12': '{object} was {changeTypeText}',
title={activityCreatedDate.format('M/D/YYYY hh:mm A')}
return <span title={startDateMoment.format('M/D/YYYY hh:mm A')}>{prettyStartDate}</span>;
return <span title={endDateMoment.format('M/D/YYYY hm:mm A')}>{prettyEndDate}</span>;
'activityheader.jsx.fileAdded_5': 'File Added',
'activityheader.jsx.fileUpdated_6': 'File Updated',
'activityheader.jsx.fileDeleted_7': 'File Deleted',
'activityheader.jsx.appointmentScheduled_8': 'Appointment Scheduled',
confirmButtonText: 'Okay'
title: 'New Alert!'
changeTimeZoneButtonText: 'Yes',
hideMessageButtonText: 'No',
neverAskAgainButtonText: 'Never ask again'
'activityheader.jsx.appointmentUpdated_9': 'Appointment Updated',
'activityheader.jsx.appointmentDeleted_10': 'Appointment Deleted',
'activityheader.jsx.noteCreated_11': 'Note Created',
'activityheader.jsx.noteUpdated_12': 'Note Updated',
'activityheader.jsx.noteDeleted_13': 'Note Deleted',
'activityheader.jsx.advanceCandidate_14': 'Advance Candidate',
'activityheader.jsx.doNotAdvanceCandidate_15': 'Do Not Advance Candidate',
'activityheader.jsx.expenseCreated_16': 'Expense Created',
'activityheader.jsx.expenseUpdated_17': 'Expense Updated',
'activityheader.jsx.expenseDeleted_18': 'Expense Deleted',
'activityheader.jsx.iformStatusUpdated_19': 'iForm Status Updated',
'activityheader.jsx.iformUpdated_20': 'iForm Updated',
'activityheader.jsx.taskAssigned_21': 'Task Assigned',
'activityheader.jsx.taskUpdated_22': 'Task Updated',
'activityheader.jsx.taskDeleted_23': 'Task Deleted',
'activityheader.jsx.suggestedTaskAdded_24': 'Suggested Task Added',
'activityheader.jsx.suggestedTaskUpdated_25': 'Suggested Task Updated',
'activityheader.jsx.suggestedTaskDeleted_26': 'Suggested Task Deleted',
'activityheader.jsx.activityActivityPending_27': '{activityActivity} Pending',
'activityheader.jsx.activityActivityStarted_28': '{activityActivity} Started',
'activityheader.jsx.activityActivityCompleted_30': '{activityActivity} Completed',
'activityheader.jsx.activityActivityCanceled_31': '{activityActivity} Canceled',
'activityheader.jsx.activityActivityRejected_32': '{activityActivity} Rejected',
'activityheader.jsx.activityActivityStopped_29': '{activityActivity} Stopped',
'activityheader.jsx.activityActivityActivity_33': '{activityActivity} Activity',
'activityheader.jsx.jobApplicationSubmitted_34': 'Job Application Submitted',
'activityheader.jsx.candidateActivityObjectFo_35': 'Candidate {activityObject} for Event',
'activityheader.jsx.candidateActivityObjectEv_36': 'Candidate {activityObject} Event',
'activityheader.jsx.candidateSubmittedForEven_37': 'Candidate Submitted for Event',
'activityheader.jsx.profileSubmitted_38': 'Profile Submitted',
'activityheader.jsx.profilePostedToPortal_39': 'Profile Posted To Portal',
'activityheader.jsx.profileUnpostedFromPortal_40': 'Profile Unposted From Portal',
'activityheader.jsx.activityPostStatusTextPos_41': '{activityPostStatusText} Posted to Portal',
'activityheader.jsx.screeningQuestionAdded_42': 'Screening Question Added',
'activityheader.jsx.screeningQuestionUpdated_43': 'Screening Question Updated',
'activityheader.jsx.screeningQuestionDeleted_44': 'Screening Question Deleted',
'activityheader.jsx.screeningQuestionPostedTo_45': 'Screening Question Posted To Portals',
'activityheader.jsx.screeningQuestionPostedTo_46': 'Screening Question Posted To Portals Updated',
'activityheader.jsx.screeningQuestionUnposted_47': 'Screening Question Unposted from Portals',
'activityheader.jsx.screeningQuestionCreated_48': 'Screening Question Created',
'activityheader.jsx.screeningQuestionUpdated_49': 'Screening Question Updated',
'activityheader.jsx.screeningQuestionDeleted_50': 'Screening Question Deleted',
'activityheader.jsx.activityActivityCreated_51': '{activityActivity} Created',
'activityheader.jsx.activityActivityEdited_52': '{activityActivity} Edited',
'activityheader.jsx.activityActivityDeleted_53': '{activityActivity} Deleted',
'activityheader.jsx.emailLinkClicked_54': 'Email Link Clicked',
'activityheader.jsx.emailOpened_55': 'Email Opened',
'activityheader.jsx.iformAddedToPacket_56': 'iForm Added to Packet',
'activityheader.jsx.iformEditedForPacket_57': 'iForm Edited for Packet',
'activityheader.jsx.iformDeletedFromPacket_58': 'iForm Deleted from Packet',
'activityheader.jsx.activityActivityAdded_59': '{activityActivity} Added',
'activityheader.jsx.loggedIn_60': 'Logged In',
'activityheader.jsx.jobApplicationCompleted_61': 'Job Application Completed',
'activityheader.jsx.screeningQuestionResponse_62': 'Screening Question Response Edited',
'activityheader.jsx.jobPostedToGoogle_63': 'Profile Submitted to Google',
'activityheader.jsx.jobRemovedFromGoogle_64': 'Profile Removed from Google',
'activitydescription.jsx.emailSubjectActivitySubje_1': 'Email subject: "{activitySubject}"',
'activitydescription.jsx.fileActivityObject_2': 'File: "{activityObject}"',
'activitydescription.jsx.noteActivityTopic_3': 'Note: "{activityTopic}"',
'activitydescription.jsx.expenseActivityExpenseTyp_4': 'Expense: {activityExpenseType} expense for "{activityOwner}"',
'activitydescription.jsx.expenseActivityExpenseTyp_5': 'Expense: {activityExpenseType} expense',
'activitydescription.jsx.iformActivityFormNameStat_6': 'iForm: "{activityFormName}" Status updated to "{activityChangedValue}"',
'activitydescription.jsx.taskActivityName_8': 'Task: "{activityName}"',
'activitydescription.jsx.activityActivityForActivi_9': '{activityActivity} for {activityForm} set to {activityChangedValue}',
'activitydescription.jsx.activityCandidatesActivit_10': '{activityCandidate}\'s {activityActivity} for {activityJob} set to {activityChangedValue}',
'activitydescription.jsx.activityActivityForActivi_11': '{activityActivity} for {activityJob} set to {activityChangedValue}',
'activitydescription.jsx.activityChangeTypeTextAct_12': '{activityChangeTypeText} {activityActivity} Status to {activityChangedValue} for {activityForm}',
'activitydescription.jsx.activityChangeTypeTextAct_13': '{activityChangeTypeText} {activityCandidate}\'s {activityActivity} Status to {activityChangedValue} for {activityJob}',
'activitydescription.jsx.activityChangeTypeTextAct_14': '{activityChangeTypeText} {activityActivity} Status to {activityChangedValue} for {activityJob}',
'activitydescription.jsx.activityOwnerSubmittedToA_15': '{activityOwner} submitted to "{activityBaseProfileType}"',
'activitydescription.jsx.activityJobTitlePostedToA_16': '"{activityJobTitle}" posted to {activityPostedTo} {startDate} and was unposted {endDate}',
'activitydescription.jsx.activityJobTitlePostedToA_17': '"{activityJobTitle}" posted to {activityPostedTo} {startDate} and will unpost {endDate}',
'activitydescription.jsx.activityJobTitlePostedToA_18': '"{activityJobTitle}" posted to {activityPostType} {startDate} and was unposted {endDate}',
'activitydescription.jsx.activityJobTitlePostedToA_19': '"{activityJobTitle}" posted to {activityPostType} {startDate} and will unpost {endDate}',
'activitydescription.jsx.activityJobTitleWillPostT_20': '"{activityJobTitle}" will post to {activityPostedTo} {startDate} and was unposted {endDate}',
'activitydescription.jsx.activityJobTitleWillPostT_21': '"{activityJobTitle}" will post to {activityPostedTo} {startDate} and will unpost {endDate}',
'activitydescription.jsx.activityJobTitleWillPostT_22': '"{activityJobTitle}" will post to {activityPostType} {startDate} and was unposted {endDate}',
'activitydescription.jsx.activityJobTitleWillPostT_23': '"{activityJobTitle}" will post to {activityPostType} {startDate} and will unpost {endDate}',
'activitydescription.jsx.activityJobTitlePostedToA_24': '"{activityJobTitle}" posted to {activityPostedTo} {startDate}',
'activitydescription.jsx.activityJobTitlePostedToA_26': '"{activityJobTitle}" posted to {activityPostType} {startDate}',
'activitydescription.jsx.activityJobTitleWillPostT_28': '"{activityJobTitle}" will post to {activityPostedTo} {startDate}',
'activitydescription.jsx.activityJobTitleWillPostT_30': '"{activityJobTitle}" will post to {activityPostType} {startDate}',
'activitydescription.jsx.activityJobTitleUnpostedF_32': '"{activityJobTitle}" unposted from {activityPostedTo} {endDate}',
'activitydescription.jsx.activityJobTitleWillUnpos_35': '"{activityJobTitle}" will unpost from {activityPostType} {endDate}',
'activitydescription.jsx.activityPostStatusTextPos_36': '{activityPostStatusText} post to {activityPostedTo}',
'activitydescription.jsx.activityJobTitleWillUnpos_33': '"{activityJobTitle}" will unpost from {activityPostedTo} {endDate}',
'activitydescription.jsx.activityJobTitleUnpostedF_34': '"{activityJobTitle}" unposted from {activityPostType} {endDate}',
'activitydescription.jsx.activityPostStatusTextPos_37': '{activityPostStatusText} post to {activityPostType}',
'activitydescription.jsx.activityManagerNameWasAdd_38': '"{activityManagerName}" was added to "{activityNewCompany}"',
'activitydescription.jsx.activityManagerNameWasAdd_39': '"{activityManagerName}" was added to "{activityNewCompany}"',
'activitydescription.jsx.activityManagerNameWasDel_40': '"{activityManagerName}" was deleted from "{activityPreviousCompany}"',
'activitydescription.jsx.activityOwnerWasPostedToA_41': '"{activityOwner}" was posted to {activityPostedTo}',
'activitydescription.jsx.activityOwnerWasPostedToA_42': '"{activityOwner}" was posted to {activityPostType}',
'activitydescription.jsx.activityOwnerWasUnpostedF_43': '"{activityOwner}" was unposted from {activityPostedTo}',
'activitydescription.jsx.activityOwnerWasUnpostedF_44': '"{activityOwner}" was unposted from {activityPostType}',
'activitydescription.jsx.activityPostStatusTextPos_45': '"{activityPostStatusText}" post to {activityPostedTo}',
'activitydescription.jsx.activityPostStatusTextPos_46': '"{activityPostStatusText}" post to {activityPostType}',
'activitydescription.jsx.iformsWorkflowTabWasModif_47': 'iForms (Workflow) tab was modified',
'activitydescription.jsx.suggestedTaskActivityName_48': 'Suggested Task: "{activityName}"',
'activitydescription.jsx.readMore_49': 'Read More',
'activitydescription.jsx.readLess_50': 'Read Less',
'activitydescription.jsx.activityGoogleJobPostPost_51': '"{activityJobTitle}" (posted to {activityPortalName}) has been submitted for indexing on Google',
'activitydescription.jsx.activityGoogleJobPostUnpo_52': '"{activityJobTitle}" (posted to {activityPortalName}) has been removed from indexing on Google',
'activity.jsx.more_1': '(more)'
future: this.props.i18n['activitystream.jsx.inSFromNow_5'].replace('{s}', '%s'),
past: this.props.i18n['activitystream.jsx.sAgo_6'].replace('{s}', '%s'),
<div className={`alert ${dangerLevel ? 'alert-danger' : 'alert-warning'}`}>
aria-label="Close"
aria-label="Close"
<Link className="announcementLink" to={url} title={`Since: ${lastAccess}`}>
<b>{count === 0 ? 'No' : count} New Announcement(s)</b>
const tabGroups = docToUse.querySelectorAll(`ul.profileTab.nav-tabs:not(.NoDisplay) a[id=${tab}]`);
'linkedin': true
const socialClass = content.replace('Social Media -', '').toLowerCase().trim();
return (<span className={`social social-${ socialClass }`} />);
<div className="factoid-content" title={factoid.hoverText} style={{display: 'block'}}>
{factoid.title === 'Source' && factoid.content ? this.sourceGlyph(factoid.content) : factoid.content}
<button type="button" className="close" data-dismiss="modal"
aria-label="Close" onClick={this.props.handleCancelAction}
aria-hidden="true" xmlns="http://www.w3.org/2000/svg" data-svgreactloader="[[&quot;http://www.w3.org/2000/svg&quot;,&quot;xlink&quot;,&quot;http://www.w3.org/1999/xlink&quot;]]"
><g fill="none" fill-rule="evenodd"><g transform="translate(2 2)"><path fill="currentColor" d="M1.54 4.848A3.312 3.312 0 0 1 4.848 1.54a3.312 3.312 0 0 1 3.308 3.308 3.312 3.312 0 0 1-3.308 3.309A3.312 3.312 0 0 1 1.54 4.848m10.382 5.623L8.921 7.469a4.818 4.818 0 0 0 .776-2.62A4.854 4.854 0 0 0 4.848 0 4.853 4.853 0 0 0 0 4.848a4.853 4.853 0 0 0 4.848 4.849c.965 0 1.864-.287 2.62-.776l3.002 3.002c.1.1.264.1.363 0l1.09-1.089c.1-.1.1-.263 0-.363"></path></g></g></svg>
autoComplete="off"
autoCorrect="off"
<g transform="translate(1.000000, 1.000000)">
<g transform="translate(0.000000, 0.136192)">
<g transform="translate(6.857143, 6.856192)">
return 'in';
title="Pin to Sidebar"
editLabel={labels.editDescription} onClickEdit={() => onEditField('description', job.description)}
export const ALERT_TYPES = { BROWSER: 'browser', TIMEZONE: 'timezone', MAIL: 'mail', SYSTEM: 'system' };
export const ALERT_TYPES = { BROWSER: 'browser', TIMEZONE: 'timezone', MAIL: 'mail', SYSTEM: 'system' };
export const ALERT_TYPES = { BROWSER: 'browser', TIMEZONE: 'timezone', MAIL: 'mail', SYSTEM: 'system' };
value: 'mobile',
export default translate(['common', 'esignature'])(EsignatureConfig);
<div className={`job-card-field ${className}`}>
"<Button	onClick={this.handleSave} variant=""primary"">{labels.save}</Button>"
if (this.state.confirmBulkDialog.okAction === 'archive') {
} else if (this.state.confirmBulkDialog.okAction === 'close') {
`${createdLabel} ${momentcreatedDate.from(createdMoment)} ${createdByLabel} ${data[COLUMNS.OWNER_NAME]}`
data[COLUMNS.SHARED] = (data[COLUMNS.SHARED].toLowerCase() === 'yes') ? this.getLocaleMessage('mailtemplate.management.templatelist.shared.label') : '';
ariaLabel: 'search templates',
alert(this.state.bean.i18n['event.manager.finish.alert']);
<IcimsAlertMessage alertType={'warning'} message={this.state.bean.i18n['launch.kiosk.social.connect.off']} />
return `<a href="${editFormViews}">${editFormViewsLabel}</a> | <a href="${editFormQuestions}">${editFormQuestionsLabel}</a> | <a href="${editFormSections}">${editFormSectionsLabel}</a> | <a href="${editFormFieldDependencies}">${editFormFieldDependenciesLabel}</a> | <a href="${manageForm}">${manageFormLabel}</a>`;
return `<a href="${web}" target="_blank">${webLabel}</a> | <a href="${html}" target="_blank">${htmlLabel}</a> (<a href="${q1}" target="_blank">${q1Label}</a>) | <a href="${doc}" target="_blank">${docLabel}</a> (<a href="${q2}" target="_blank">${q2Label}</a>)`;
emptyMsg: 'No Forms Available.',
<IcimsAlertMessage alertType={'warning'} message="Social connect is turned off for all portals" />
<IcimsAlertMessage alertType={'warning'} message="Social connect is turned off for all portals" />
altLinkCellTemplate: this.state.bean.clickToReviewMode ? '<span class="glyphicons glyphicons-address-book"></span>' : null,
fd.append('file', filepickerInput.files[0]);
icon: (pb.error ? 'warning' : 'pencil'),
icon: (pb.error ? 'warning' : 'pencil'),
body: `status=${this.state.newStatus}&comment=${this.state.newComment}&idsToUpdate=${pb.idsToUpdate.toString()}`
filters.push({ field: TEMPLATE_KENDO_QUERY_FILTER[criteria.name].column, operator: 'contains', value: criteria.value });
const operator = { operator: 'contains' };
export default translate(['common', 'offerletter'], {wait: true})(OfferTemplateManagement);
msg = msg.replace('{title}', 'this');
msg = msg.replace('{title}', 'this');
<span className="loading-text">{t('common:loading')}</span>
export default translate(['common', 'offerletter'])(
if (this.isEntitled('offer', 'view')) {
if (this.isEntitled('offer', 'view')) {
{t('common:dateUpdated', { value: offer.updatedDate })}
entitlementScope: 'view',
entitlementScope: 'view',
entitlementResource: 'offer',
entitlementScope: 'view',
this.state.entitlements['offer.template'].includes('create') &&
tabClassName="tab"
export default translate(['common', 'offerletter'])(OfferCenter);
operator: 'contains',
operator: 'contains',
filters.push({ field: KENDO_QUERY_MAP.keyword.column, operator: 'contains', value: query.keyword });
operator: 'contains'
export default translate(['common', 'offerletter'], { wait: true })(OfferManagement);
download: { resource: 'offer', scopes: ['view', 'modify'] },
download: { resource: 'offer', scopes: ['view', 'modify'] },
download: { resource: 'offer', scopes: ['view', 'modify'] },
variant="link"
title: t('common:people'),
icon: 'person',
icon: 'group',
if (activeElement.tagName.toLowerCase() === 'button' &&
const type = data.sectionIndex === 0 ? 'User' : 'List';
return deliveryTypes.reasonDisabled ? (<Alert iconAlt={t('common:error')} variant="error">{t(deliveryTypes.reasonDisabled)} </Alert>) : '';
if (activeElement.tagName.toLowerCase() === 'button' &&
const type = data.sectionIndex === 0 ? 'User' : 'List';
return (this.state.unresolvedApprover && <Alert iconAlt={t('common:error')} variant="error">{this.renderUnresolvedApproverMessage()}</Alert>);
<p>{t(`offerletter:email.helper.${this.isAutosendEnabled() ? 'autosend' : 'manual'}`)}</p>
const canModifyApproval = this.hasApprovalEntitlement('modify');
return (<BusyIndicator aria-label={t('common:loading')} />);
export default translate(['common', 'offerletter'], { withRef: true })(WizardReviewOffer);
{t('common:dateUpdated', {
context: 'long'
{t('common:dateCreated', { value: offer.createdDate })}
{t('common:dateCreated', {
context: 'long'
if (!this.isEntitled('offer', 'view')) {
if (!this.isEntitled('offer', 'view')) {
{t('common:sorry')}
{t('common:sorry')}
{t('common:sorry')}
variant="info"
<BusyIndicator className="offer-overview-loading" aria-label={t('common:loading')} />
export default translate(['common', 'offerletter'], { wait: true })(OfferOverview);
export default translate(['common', 'offerletter'])(OverviewDetails);
value: 'detail',
value: 'outline',
title: 'Page 1'
return t('common:leave');
method: this.state.template.templateId ? 'patch' : 'post',
method: this.state.template.templateId ? 'patch' : 'post',
const body = editor.getContent({ format: 'raw' });
confirmText={t('common:save')}
<FormLabel>{t('common:description')}</FormLabel>
name={'description'}
<FormLabel id="label_category">{t('common:category')}</FormLabel>
{t('common:template')}{' '}{t('common:name')}
{t('common:template')}{' '}{t('common:name')}
<FormLabel>{t('common:created')}</FormLabel>
{t('common:dateTime', { value: this.state.template.createdDate })}
<FormLabel>{t('common:modified')}</FormLabel>
{t('common:dateTime', { value: this.state.template.modifiedDate })}
icon="pencil"
variant="link"
return this.state.entitlements['offer.template.permission'].includes('view') &&
{t('common:cancel')}
<BusyIndicator aria-label={t('common:saving')} />
{(!this.state.readOnly && (this.state.entitlements['offer.template'].includes('create') ||
this.state.entitlements['offer.template'].includes('modify'))) &&
variant={this.state.isSaving ? 'default' : 'primary'}
t('common:save')}
tabClassName="tab"
title={t(`common:${tab.value}`) || t(`offerletter:${tab.value}`)}
variant="info"
export default translate(['common', 'offerletter'], { wait: true })(OfferStudio);
return t('common:leave'); //eslint-disable-line
return this.isEntitled('offer', 'view') && this.isEntitled('offer', 'modify') && this.isEntitled('offer.template', 'view');
return this.isEntitled('offer', 'view') && this.isEntitled('offer', 'modify') && this.isEntitled('offer.template', 'view');
return this.isEntitled('offer', 'view') && this.isEntitled('offer', 'modify') && this.isEntitled('offer.template', 'view');
return this.isEntitled('offer', 'view') && this.isEntitled('offer', 'modify') && this.isEntitled('offer.template', 'view');
return this.isEntitled('offer', 'view') && this.isEntitled('offer', 'modify') && this.isEntitled('offer.template', 'view');
<MenuItem eventKey="archive">{t('common:archive')}</MenuItem>
redirectToSubmittal(initTab = 'OFFER') {
this.isOfferApprovalEntitled('modify') && this.state.offer.approvers ?
cancelText={t('common:cancel')}
confirmText={t('common:ok')}
cancelText={t('common:cancel')}
confirmText={t('common:ok')}
confirmText={t('common:save')}
this.handleAdditionalAction('save');
return this.canExtend() ? t('common:finish') : t('common:save');
return this.canExtend() ? t('common:finish') : t('common:save');
return this.state.lastStep && !this.state.validationFailure && this.isOfferEntitled('extend');
{t('common:sorry')}
<BusyIndicator aria-label={t('common:saving')} />
<BusyIndicator aria-label={t('common:loading')} />
export default translate(['common', 'offerletter'], { wait: true })(OfferWizard);
{t('common:done')}
<Icon color="positive" name="success" alt={t('common:success')}
return (<BusyIndicator aria-label="Loading" />);
export default translate(['common', 'offerletter'])(WizardConfirmOffer);
const body = editor.getContent({ format: 'raw' });
const body = editor.getContent({ format: 'raw' });
<BusyIndicator aria-label={t('common:loading')} />
export default translate(['common', 'offerletter'])(WizardPrepareOffer);
icon: 'pencil',
icon: 'file',
icon: actionInfo.TASK_PAUSED ? 'play' : 'pause',
icon: actionInfo.TASK_PAUSED ? 'play' : 'pause',
icon: 'remove',
icon: 'clock',
const iconSpan = `<span class='glyphicons glyphicons-${hasError ? 'warning-sign' : 'show-thumbnails'}'></span>`;
const dropdownButton = `<button type='button' ${errorLabel} title='${hasError ? errorText : ''}' role='button' class='btn btn-${hasError ? 'warning' : 'primary'} dropdown-toggle' data-toggle='dropdown' aria-haspopup='true' aria-expanded='false'>${iconSpan}${dropdownTitle}</button>`;
return `<div class='dropdown btn-group btn-group-primary'>${dropdownButton}<ul role'menu' class='dropdown-menu pull-right actionMenu'>${actionButtons}</ul></div>`;
variant: 'info'
creator: t('common:owner'),
filters.push({ field: TEMPLATE_KENDO_QUERY_FILTER[criteria.name].column, operator: 'contains', value: criteria.value });
const operator = { operator: 'contains' };
export default translate(['common', 'offerletter'], { wait: true })(WizardSelectTemplate);
{loading && <DelayedBusyIndicator aria-label="Loading" fullscreen delay={500} />}
<Button id="saveButton" variant="primary" onClick={this.handleSave}>
<Button id="saveButton" variant="primary" onClick={this.handleSave}>{labels.save}</Button>
<Grid fluid="true" aria-live="polite" className="icims-x-admin-fields-grid">
className={index % 2 === 0 ? 'even' : 'odd'}
className={index % 2 === 0 ? 'even' : 'odd'}
icon="close"
variant="link"
template: '<a href="\\#ruleset" data-rule-set-id="${ruleSetId}">${name}</a>'
template: '<span class="glyphicons glyphicons-option-vertical"></span>'
col.filterable.itemTemplate = (templateData) => `<li class='k-item'><label class='k-label'><input type='checkbox' name='${templateData.field}' value='#= data.id #'/>#= data.${key} || data.all #</label></li>`;
<div className={`rule-grid sortable ${this.state.ruleSetId ? 'hide' : ''}`} ref="gridWrapper">
selectedTab: pb.quickInfoBean.activityPaagPaneTab && pb.activityStreamEnabled ? 'activity' : 'tags',
selectedTab: pb.quickInfoBean.activityPaagPaneTab && pb.activityStreamEnabled ? 'activity' : 'tags',
something: 'default value'
sortBean(bean, column = 'owner') {
alert(t('mobilehiringmanager:selectUserAlert'));
export default translate(['common', 'mobilehiringmanager'], { wait: true })(MobileHiringManager);
const lastLoginDate = moment(new Date(invite.lastLoginTimestamp).getTime()).format('MM/DD/YYYY h:mm a');
template: (templateData) => `<input type='checkbox' class='checkbox' value='${templateData.invitationId}' />`
title: t('common:sentBy'),
title: t('common:accepted'),
export default translate(['common', 'mobilehiringmanager'], { wait: true })(DevicesTable);
const createdDate = moment(ts.getTime()).format('MM/DD/YYYY h:mm a');
const expiresDate = moment(ets.getTime()).format('MM/DD/YYYY h:mm a');
template: (templateData) => `<input type='checkbox' class='checkbox' value='${templateData.invitationId}' />`
title: t('common:sentBy'),
title: t('common:created'),
title: t('common:expires'),
export default translate(['common', 'mobilehiringmanager'], { wait: true })(InvitesTable);
