using System;
using System.Collections.Generic;
using System.Text;

namespace CRMApp
{
    public class ApplicationCreateModel
    {
        public DateTime cre_time { get; set; } = DateTime.UtcNow;
        public DateTime mod_time { get; set; }
        public string application_id { get; set; }
        public int __v { get; set; }
        public string applicant { get; set; }
        public string applicationType { get; set; }
        public string bankaustralia_fname { get; set; }
        public string campaign_id { get; set; }
        public string dob { get; set; }
        public string email { get; set; }
        public string flowName { get; set; }
        public string fname { get; set; }
        public string initiatedBy { get; set; }
        public string internalFraudCheck { get; set; }
        public string lname { get; set; }
        public string mobile { get; set; }
        public string product_code { get; set; }
        public string product_type_code { get; set; }
        public string residencestatus { get; set; }
        public int section_id { get; set; }
        public string source_id { get; set; }
        public int sub_section_id { get; set; }
        public string title { get; set; }
        public string visitorstatus { get; set; }
        public string previousResidentialAddress { get; set; }
        public string residential_Address { get; set; }
        public string timeInterval { get; set; }
        public string bankaustralia_borrow { get; set; }
        public int borrow { get; set; }
        public string carkey { get; set; }
        public int loantermkey { get; set; }
        public string makekey { get; set; }
        public string modelkey { get; set; }
        public string purposeofloan { get; set; }
        public string repayfreq { get; set; }
        public string spcikey { get; set; }
        public string taxobligation { get; set; }
        public string usedCar3 { get; set; }
        public string usedCarYear { get; set; }
        public string validToMonth { get; set; }
        public string beforetax { get; set; }
        public string centerearn { get; set; }
        public bool centerlabel { get; set; }
        public string centerlinkfr { get; set; }
        public string childfre { get; set; }
        public string childpay { get; set; }
        public string earnfreq { get; set; }
        public string employed { get; set; }
        public int grossincome { get; set; }
        public bool incomekey { get; set; }
        public bool job { get; set; }
        public string nontaxfre { get; set; }
        public string nontaxpay { get; set; }
        public bool othernontaxincome { get; set; }
        public string otherpay { get; set; }
        public bool othertaxableincome { get; set; }
        public string othfr { get; set; }
        public string rent { get; set; }
        public string renti { get; set; }
        public string secondpay { get; set; }
        public bool supportandmaintenance { get; set; }
        public string taxablefreq { get; set; }
        public int totalIncome { get; set; }
        public string billsExpense { get; set; }
        public string childcarefrq { get; set; }
        public bool childkey { get; set; }
        public bool coskey { get; set; }
        public string depkey { get; set; }
        public string educationExpense { get; set; }
        public string edufrq { get; set; }
        public bool feekey { get; set; }
        public string foodExpense { get; set; }
        public string groceriesfreq { get; set; }
        public string grockey { get; set; }
        public string healthCareExpense { get; set; }
        public string healthfrq { get; set; }
        public string householdExpense { get; set; }
        public string householdfrq { get; set; }
        public string insfrq { get; set; }
        public string lifestyleExpense { get; set; }
        public string manualLoanAmount { get; set; }
        public string mediafrq { get; set; }
        public bool mediakey { get; set; }
        public bool medicalkey { get; set; }
        public string otherExpense { get; set; }
        public bool otherExpenses { get; set; }
        public string otherfrq { get; set; }
        public string perfrq { get; set; }
        public string personalExpense { get; set; }
        public bool publickey { get; set; }
        public string relstatus { get; set; }
        public string repair { get; set; }
        public int totexpenses { get; set; }
        public string transportExpense { get; set; }
        public string trasnfrq { get; set; }
        public string travelExpense { get; set; }
        public string utfrq { get; set; }
        public string utilitykey { get; set; }
        public bool vehiclekey { get; set; }
        public Asset[] assets { get; set; }
        public int totalAssetValue { get; set; }
        public Liability[] liabilities { get; set; }
        public int totalBalance_Limit { get; set; }
        public int totalMonthlyRepayment { get; set; }
        public Customfields customFields { get; set; }
        public string custom_page_3577_otp_330_1 { get; set; }
        public int Pmt { get; set; }
        public float dtiratio { get; set; }
        public string ltiratio { get; set; }
        public int ndiincome { get; set; }
        public float ndiratio { get; set; }
        public string rateOfInterest { get; set; }
        public bool timer1 { get; set; }
        public bool timer2 { get; set; }
        public Filesupload[] filesUpload { get; set; }
        public string experianStatus { get; set; }
        public bool success { get; set; }
        public string credit_score { get; set; }
        public int no_of_worst_repayment { get; set; }
        public string credit_fraud_flag { get; set; }
        public ENQUIRIES ENQUIRIES { get; set; }
        public string no_of_open_accounts { get; set; }
        public DEFAULTED DEFAULTED { get; set; }
        public string court_Action { get; set; }
        public string bankruptcy_File { get; set; }
        public string default_Commercial { get; set; }
        public string default_Active { get; set; }
        public string no_of_enquiries { get; set; }
        public OPEN_ACCOUNTS OPEN_ACCOUNTS { get; set; }
        public string Infringement_Credit { get; set; }
        public string color { get; set; }
        public string dl_verification { get; set; }
        public string dropdownid { get; set; }
        public string idCheckStatus { get; set; }
        public string idnum { get; set; }
        public string idstate { get; set; }
        public string licence { get; set; }
        public string medicare_verification { get; set; }
        public string monthdrop { get; set; }
        public string passport_verification { get; set; }
        public string pncard { get; set; }
        public string radioperform { get; set; }
        public string statelicence { get; set; }
        public string textnumbercard { get; set; }
        public string vehicleYear { get; set; }
        public bool check_status_fail { get; set; }
        public bool check_status_pass { get; set; }
        public string mogoRedirectUrl { get; set; }
        public string mogoCreateApplicationStatus { get; set; }
        public Categorysummarycredits categorySummaryCredits { get; set; }
        public Categorysummarydebits categorySummaryDebits { get; set; }
        public Categorysummaryliaibilies categorySummaryLiaibilies { get; set; }
        public string totalCreditMogo { get; set; }
        public string totalExpensesMogo { get; set; }
        public string totalliabilitiesMogo { get; set; }
        public Categorysummarytransactions categorySummaryTransactions { get; set; }
        public Categoryexpenseindustry categoryExpenseIndustry { get; set; }
        public string message { get; set; }
        public float ndiMogo { get; set; }
        public float ndiRatioMogo { get; set; }
        public string rateofinterest { get; set; }
        public bool checkboxd { get; set; }
        public Uploadbank uploadbank { get; set; }
        public int fnAprvdExpense { get; set; }
        public int fnAprvdIncome { get; set; }
        public int fnAprvdborrow { get; set; }
        public int fnDTIIratio { get; set; }
        public int fnEmi { get; set; }
        public int fnFinalNDI { get; set; }
        public float fnInterestRate { get; set; }
        public int fnLTIratio { get; set; }
        public int fnLoantermKey { get; set; }
        public float fnNDIRatio { get; set; }
        public string manualIncome { get; set; }
        public string manualInterestRate { get; set; }
        public string manualloantermkey { get; set; }
        public string manualtotexpenses { get; set; }
        public string mnborrow { get; set; }
        public string pmt { get; set; }
        public string preInterestRate { get; set; }
        public string totalLiabilities { get; set; }
    }
    public class Customfields
    {
        public string custom_page_3577_otp_330_1 { get; set; }
        public string custom_page_3213_text_303_6 { get; set; }
    }

    public class ENQUIRIES
    {
        public Record[] records { get; set; }
    }

    public class Record
    {
        public Headers headers { get; set; }
        public Total total { get; set; }
        public Subrecord[] subRecords { get; set; }
    }

    public class Headers
    {
    }

    public class Total
    {
    }

    public class Subrecord
    {
        public string orgs { get; set; }
        public string inds { get; set; }
        public string prps { get; set; }
        public string typ { get; set; }
        public string amts { get; set; }
        public string fins { get; set; }
        public string enqs { get; set; }
    }

    public class DEFAULTED
    {
    }

    public class OPEN_ACCOUNTS
    {
        public Record1[] records { get; set; }
    }

    public class Record1
    {
        public Headers1 headers { get; set; }
        public Total1 total { get; set; }
        public Subrecord1[] subRecords { get; set; }
    }

    public class Headers1
    {
    }

    public class Total1
    {
    }

    public class Subrecord1
    {
        public string name { get; set; }
        public string wrst_rp { get; set; }
        public string ind { get; set; }
        public string typ { get; set; }
        public string pay_term { get; set; }
        public string fin_resp { get; set; }
        public string open_dt { get; set; }
        public string cur_lt { get; set; }
    }

    public class Categorysummarycredits
    {
        public Record2[] records { get; set; }
    }

    public class Record2
    {
        public Subrecord2[] subRecords { get; set; }
        public Headers2 headers { get; set; }
        public Total2 total { get; set; }
    }

    public class Headers2
    {
    }

    public class Total2
    {
    }

    public class Subrecord2
    {
        public string description { get; set; }
        public string categoryCode { get; set; }
        public string monthlyAvg { get; set; }
        public int transactionNumber { get; set; }
        public string total { get; set; }
    }

    public class Categorysummarydebits
    {
        public Record3[] records { get; set; }
    }

    public class Record3
    {
        public Subrecord3[] subRecords { get; set; }
        public Headers3 headers { get; set; }
        public Total3 total { get; set; }
    }

    public class Headers3
    {
    }

    public class Total3
    {
    }

    public class Subrecord3
    {
        public string description { get; set; }
        public string categoryCode { get; set; }
        public string monthlyAvg { get; set; }
        public int transactionNumber { get; set; }
        public string total { get; set; }
    }

    public class Categorysummaryliaibilies
    {
        public Record4[] records { get; set; }
    }

    public class Record4
    {
        public Subrecord4[] subRecords { get; set; }
        public Headers4 headers { get; set; }
        public Total4 total { get; set; }
    }

    public class Headers4
    {
    }

    public class Total4
    {
    }

    public class Subrecord4
    {
        public string description { get; set; }
        public string categoryCode { get; set; }
        public string monthlyAvg { get; set; }
        public int transactionNumber { get; set; }
        public string total { get; set; }
    }

    public class Categorysummarytransactions
    {
        public Record5[] records { get; set; }
    }

    public class Record5
    {
        public Subrecord5[] subRecords { get; set; }
        public Headers5 headers { get; set; }
        public Total5 total { get; set; }
    }

    public class Headers5
    {
    }

    public class Total5
    {
    }

    public class Subrecord5
    {
        public string transactionDate { get; set; }
        public string category { get; set; }
        public string revCategoryCode { get; set; }
        public string description { get; set; }
        public object debit { get; set; }
        public object credit { get; set; }
        public string balance { get; set; }
    }

    public class Categoryexpenseindustry
    {
        public Record6[] records { get; set; }
    }

    public class Record6
    {
        public Subrecord6[] subRecords { get; set; }
        public Headers6 headers { get; set; }
        public Total6 total { get; set; }
    }

    public class Headers6
    {
    }

    public class Total6
    {
    }

    public class Subrecord6
    {
        public string description { get; set; }
        public string categoryCode { get; set; }
        public int transactionNumber { get; set; }
        public string monthlyAvg { get; set; }
    }

    public class Uploadbank
    {
        public string uploadedDocuments { get; set; }
        public string documentCollectionMode { get; set; }
        public bool requestSent { get; set; }
    }

    public class Asset
    {
        public string assetValue { get; set; }
        public string assetOwnership { get; set; }
        public string assetAddr { get; set; }
        public string entryId { get; set; }
        public Templateinfo templateInfo { get; set; }
    }

    public class Templateinfo
    {
        public string componentId { get; set; }
        public string name { get; set; }
    }

    public class Liability
    {
        public string liabValue { get; set; }
        public string liabIntRate { get; set; }
        public string liabMonthlyRepay { get; set; }
        public string liabInstitution { get; set; }
        public string liabMortgage { get; set; }
        public string entryId { get; set; }
        public Templateinfo1 templateInfo { get; set; }
    }

    public class Templateinfo1
    {
        public string componentId { get; set; }
        public string name { get; set; }
    }

    public class Filesupload
    {
        public string fileId { get; set; }
        public string referenceId { get; set; }
        public string location { get; set; }
        public string downloadUrl { get; set; }
        public string fileName { get; set; }
        public string category { get; set; }
        public string subCategory { get; set; }
        public string uploadedBy { get; set; }
        public int version { get; set; }
        public string status { get; set; }
        public DateTime createdTS { get; set; }
        public DateTime updatedTS { get; set; }
        public Metadata metadata { get; set; }
        public bool isDeleted { get; set; }
    }

    public class Metadata
    {
    }
}
