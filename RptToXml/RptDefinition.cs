using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Ref: http://stackoverflow.com/questions/10283206/c-sharp-setting-getting-the-class-properties-by-string-name

namespace RptToXml.Model
{
    class RptDefinition
    {
        public RptDefinition()
        {
            Report = new Report();
        }
        public Report Report { get; set; }
    }
    class Report 
    {
        public Report()
        {
            Summaryinfo = new Summaryinfo();
            ReportOptions = new ReportOptions();
            PrintOptions = new PrintOptions();
            SubReports = new List<Report>();
            Database = new Database();
            DataDefinition = new DataDefinition();
            ReportDefinition = new ReportDefinition();
        }
        public String Name {get; set;}
        public String FileName { get; set; }
        public Boolean HasSavedData { get; set; }
        public Summaryinfo Summaryinfo { get; set; }
        public ReportOptions ReportOptions {get; set;}
        public PrintOptions PrintOptions { get; set; }
        public List<Report> SubReports { get; set; }
        public Database Database { get; set; }
        public DataDefinition DataDefinition { get; set; }
        public ReportDefinition ReportDefinition { get; set; } 
    }
    class Summaryinfo
    {
        public String KeywordsinReport { get; set; }
        public String ReportAuthor { get; set; }
        public String ReportComments { get; set; }
        public String ReportSubject { get; set; }
        public String ReportTitle { get; set; }
    }
    class ReportOptions
    {
        public Boolean EnableSaveDataWithReport { get; set; }
        public Boolean EnableSavePreviewPicture { get; set; }
        public Boolean EnableSaveSummariesWithReport { get; set; }
        public Boolean EnableUseDummyData { get; set; }
        public String initialDataContext { get; set; }
        public String initialReportPartName { get; set; }
    }
    #region Print Options
    class PrintOptions
    {
        public int PageContentHeight { get; set; }
        public int PageContentWidth {get; set;}
        public String PaperOrientation {get; set;}
        public String PaperSize {get; set;}
        public String PaperSource {get; set;}
        public String PrinterDuplex {get; set;}
        public String PrinterName {get; set;}
        public PageMargins PageMargins {get; set;}
        public PageMarginConditionFormulas PageMarginConditionFormulas { get; set; }
    }
    class PageMargins
    {
        public int bottomMargin {get; set;}
        public int leftMargin { get; set;}
        public int rightMargin { get; set;}
        public int topMargin {get; set;}
    }
    class PageMarginConditionFormulas
    {
        public String Top {get; set;}
        public String Bottom {get; set;}
        public String Left {get; set;}
        public String Right {get; set;}
    }
    #endregion
    #region Database
    class Database 
    {
        public Database()
        {
            TableLinks = new List<_TableLink>();
            Tables = new List<_Table>();
        }
        public List<_TableLink> TableLinks {get; set;}
        public List<_Table> Tables {get; set;}
    }
    class _TableLink
    {
        public _TableLink()
        {
            SourceFields = new List<TableLinkFields>;
            DestinationFields = new List<TableLinkFields>;
        }
        public String JoinType {get; set;}
        public List<TableLinkFields> SourceFields{get; set;}
        public List<TableLinkFields> DestinationFields{get; set;}
    }
    class TableLinkFields
    {
        public String FormulaName {get; set;}
        public String Kind {get; set;}
        public String Name {get; set;}
        public int NumberOfBytes {get; set;}
        public String ValueType {get; set;}
    }
    class _Table
    {
        public _Table()
        {
            Feilds = new List<Feild>();
        }
        public String Alias {get; set;}
        public String ClassName {get; set;}
        public String Name {get; set;}
        public ConnectionInfo ConnectionInfo {get; set;}
        public List<Feild> Feilds {get; set;}
    }
    class ConnectionInfo
    {
        public object this[string propertyName]
        {
            get { return this.GetType().GetProperty(propertyName).GetValue(this, null); }
            set { this.GetType().GetProperty(propertyName).SetValue(this, value, null); }
        }
        public String Database_DLL {get; set;}
        public String QE_DatabaseName {get; set;}
        public String QE_DatabaseType {get; set;}
        public String QE_LogonProperties {get; set;}
        public String QE_ServerDescription {get; set;}
        public String QE_SQLDB {get; set;}
        public String SSO_Enabled {get; set;}
        public String UserName {get; set;}
        public String Password {get; set;}
        public String Command { get; set; }
    }
    class Feild
    {
        public String Description {get; set;}
        public String FormulaForm {get; set;}
        public String HeadingText {get; set;}
        public Boolean IsRecurring {get; set;}
        public String Kind {get; set;}
        public int Length {get; set;}
        public String LongName {get; set;}
        public String Name {get; set;}
        public String ShortName {get; set;}
        public String Type {get; set;}
        public int UseCount {get; set;}
    }
    #endregion
    #region Data Definition
    class DataDefinition
    {
        public DataDefinition()
        {
            Groups = new List<_Group>();
            SortFields = new List<_SortField>();
            FormulaFieldDefinitions = new List<_FormulaFieldDefinition>();
            GroupNameFieldDefinitions = new List<_GroupNameFieldDefinition>();
            ParameterFieldDefinitions = new List<_ParameterFieldDefinition>();
            RunningTotalFieldDefinitions = new List<_RunningTotalFieldDefinition>();
            SpecialVarFieldDefinitions = new List<_SpecialVarFieldDefinition>();
            SQLExpressionFields = new List<_SQLExpressionFieldDefinition>();
            SummaryFields = new List<_SummaryFieldDefinition>();
        }
        public String GroupSelectionFormula { get; set; }
        public String RecordSelectionFormula { get; set; }
        public List<_Group> Groups { get; set; }
        public List<_SortField> SortFields { get; set; }
        public List<_DatabaseFieldDefinition> DatabaseFieldDefinitions { get; set; }
        public List<_FormulaFieldDefinition> FormulaFieldDefinitions { get; set; }
        public List<_GroupNameFieldDefinition> GroupNameFieldDefinitions { get; set; }
        public List<_ParameterFieldDefinition> ParameterFieldDefinitions { get; set; }
        public List<_RunningTotalFieldDefinition> RunningTotalFieldDefinitions { get; set; }
        public List<_SpecialVarFieldDefinition> SpecialVarFieldDefinitions { get; set; }
        public List<_SQLExpressionFieldDefinition> SQLExpressionFields { get; set; }
        public List<_SummaryFieldDefinition> SummaryFields { get; set; }
    }
    class _Group
    {
        public String ConditionField { get; set; }
    }
    class _SortField
    {
        public String Field { get; set; }
        public String SortDirection { get; set; }
        public String SortType { get; set; }
    }
    class _DatabaseFieldDefinition
    {
        public String FormulaName { get; set; }
        public String Kind { get; set; }
        public String Name { get; set; }
        public int NumberOfBytes { get; set; }
        public string TableName { get; set; }
        public String ValueType { get; set; }
    }
    class _FormulaFieldDefinition
    {
        public String FormulaName { get; set; }
        public String Kind { get; set; }
        public String Name { get; set; }
        public int NumberOfBytes { get; set; }
        public String ValueType { get; set; }
        public String Text { get; set; }
    }
    class _GroupNameFieldDefinition
    {
        public String FormulaName { get; set; }
        public String Group { get; set; }
        public String GroupNameFieldName { get; set; }
        public String Kind { get; set; }
        public String Name { get; set; }
        public int NumberOfBytes { get; set; }
        public String ValueType { get; set; }
    }
    class _ParameterFieldDefinition
    {
        public String EditMask { get; set; }
        public Boolean EnableAllowEditingDefaultValue { get; set; }
        public Boolean EnableAllowMultipleValue { get; set; }
        public Boolean EnableNullValue { get; set; }
        public String FormulaName { get; set; }
        public Boolean HasCurrentValue { get; set; }
        public String Kind { get; set; }
        public String Name { get; set; }
        public int NumberOfBytes { get; set; }
        public String ParameterFieldName { get; set; }
        public String ParameterFieldUsage { get; set; }
        public String ParameterType { get; set; }
        public String ParameterValueKind { get; set; }
        public String PromptText { get; set; }
        public String ReportName { get; set; }
        public String ValueType { get; set; }
    }
    class _RunningTotalFieldDefinition 
    {
        public String EvaluationConditionType { get; set; }
        public String FormulaName { get; set; }
        public String Group { get; set; }
        public String Kind { get; set; }
        public String Name { get; set; }
        public int NumberOfBytes { get; set; }
        public String Operation { get; set; }
        public int OperationParameter { get; set; }
        public String ResetConditionType { get; set; }
        public String SecondarySummarizedField { get; set; }
        public String SummarizedField { get; set; }
        public String ValueType { get; set; }
    }
class _SpecialVarFieldDefinition 
{
        public String FormulaName { get; set; }
        public String Kind { get; set; }
        public String Name { get; set; }
        public int NumberOfBytes { get; set; }
        public String SpecialVarType { get; set; }
        public String ValueType { get; set; }

}
    class _SQLExpressionFieldDefinition
    {
        public String FormulaName { get; set; }
        public String Kind { get; set; }
        public String Name { get; set; }
        public int NumberOfBytes { get; set; }
        public string Text { get; set; }
        public String ValueType { get; set; }
    } //Stub
    class _SummaryFieldDefinition
    {
        public String FormulaName { get; set; }
        public String Group { get; set; }
        public String Kind { get; set; }
        public String Name { get; set; }
        public int NumberOfBytes { get; set; }
        public String Operation { get; set; }
        public int OperationParameter { get; set; }
        public String SecondarySummarizedField { get; set; }
        public String SummarizedField { get; set; }
        public String ValueType { get; set; }
    }
    #endregion
    #region Report Definition
    class ReportDefinition
    {
        public List<_Area> Areas { get; set; }
    }
    class _Area
    {
        public String Kind { get; set; }
        public String Name { get; set; }
        public _AreaFormat AreaFormat { get; set; }
        public List<_Section> Sections { get; set; }
    }
    class _AreaFormat
    {
        public Boolean EnableHideForDrillDown { get; set; }
        public Boolean EnableKeepTogether { get; set; }
        public Boolean EnableNewPageAfter { get; set; }
        public Boolean EnableNewPageBefore { get; set; }
        public Boolean EnablePrintAtBottomOfPage { get; set; }
        public Boolean EnableResetPageNumberAfter { get; set; }
        public Boolean EnableSuppress { get; set; }
    }
    class _Section
    {
        public int Height { get; set; }
        public String Kind { get; set; }
        public String Name { get; set; }
    }
    class _SectionFormat
    {
        public String CssClass { get; set; }
        public Boolean EnableKeepTogether { get; set; }
        public Boolean EnableKeepTogether { get; set; }
        public Boolean EnableKeepTogether { get; set; }
        public Boolean EnableKeepTogether { get; set; }
        public Boolean EnableKeepTogether { get; set; }
        public Boolean EnableKeepTogether { get; set; }
        public Boolean EnableKeepTogether { get; set; }
        public Boolean EnableKeepTogether { get; set; }
        public _SectionAreaConditionFormulas SectionAreaConditionFormulas { get; set; }
    }
    class _SectionAreaConditionFormulas
    {

    }
    #endregion
}
