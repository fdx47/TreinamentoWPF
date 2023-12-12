namespace TreinamentoWPF.Models.Evoliz
{
    public class CreateNewQuote
    {


        public class Rootobject
        {
            public string external_document_number { get; set; }
            public string documentdate { get; set; }
            public int clientid { get; set; }
            public int prospectid { get; set; }
            public int contactid { get; set; }
            public string _object { get; set; }
            public int validity { get; set; }
            public Term term { get; set; }
            public string comment { get; set; }
            public int analyticid { get; set; }
            public string delivery_date { get; set; }
            public float global_rebate { get; set; }
            public bool include_sale_general_conditions { get; set; }
            public int templateid { get; set; }
            public Item[] items { get; set; }
        }

        public class Term
        {
            public int penalty { get; set; }
            public bool nopenalty { get; set; }
            public bool recovery_indemnity { get; set; }
            public int discount_term { get; set; }
            public bool no_discount_term { get; set; }
            public int paytermid { get; set; }
            public string duedate { get; set; }
            public int paydelay { get; set; }
            public bool endmonth { get; set; }
            public int payday { get; set; }
            public int paytypeid { get; set; }
        }

        public class Item
        {
            public string reference { get; set; }
            public string designation { get; set; }
            public float quantity { get; set; }
            public string unit { get; set; }
            public float unit_price_vat_exclude { get; set; }
            public float vat_rate { get; set; }
            public float rebate { get; set; }
            public int sale_classificationid { get; set; }
            public int purchase_unit_price_vat_exclude { get; set; }
        }


    }
}
