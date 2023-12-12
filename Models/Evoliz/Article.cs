
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace TreinamentoWPF.Models.Evoliz
{
    public class Article
    {
        [JsonPropertyName("articleid")]
        [MaxLength(11)]
        public int ArticleId { get; set; }
        [MaxLength(11)]
        public int UserId { get; set; }
        [Column(TypeName = ("varchar(100)"))]
        public string? Reference { get; set; }
        [Column(TypeName = ("varchar(100)"))]
        public string? ReferenceClean { get; set; }
        [Column(TypeName = ("varchar(100)"))]
        public string? Nature { get; set; }
        public virtual SaleClassification SaleClassification { get; set; }
        [Column(TypeName = ("varchar(100)"))]
        public string? Designation { get; set; }

        [JsonPropertyName("designation_clean")]
        [Column(TypeName = ("varchar(100)"))]
        public string? DesignationClean { get; set; }
        [MaxLength(11)]
        public int Quantity { get; set; }
        [Column(TypeName = ("double(20,4)"))]
        public double? Weight { get; set; }
        [Column(TypeName = ("varchar(100)"))]
        public string? Unit { get; set; }

        [JsonPropertyName("unit_price_vat_exclude")]
        [Column(TypeName = ("decimal(20,2)"))]
        public decimal UnitPriceVatExclude { get; set; }
        [Column(TypeName = ("decimal(20,2)"))]
        public decimal unit_price_vat_include { get; set; }
        [MaxLength(11)]
        public int? Vat { get; set; }
        public bool Ttc { get; set; }
        public PurchaseClassification? PurchaseClassification { get; set; }
        public Margin? Margin { get; set; }
        public Supplier? Supplier { get; set; }
        [Column(TypeName = ("varchar(100)"))]
        public string? SupplierReference { get; set; }
        [Column(TypeName = ("varchar(100)"))]
        public string? SupplierReferenceClean { get; set; }
        public bool StockManagement { get; set; }
        [MaxLength(11)]
        public int StockedQuantity { get; set; }
        public bool Enabled { get; set; }
        [Column(TypeName = ("varchar(180)"))]
        public string? PictureLink { get; set; }
        public CustomFields? CustomFields { get; set; }
    }

    public class SaleClassification
    {
        [MaxLength(11)]
        public int Id { get; set; }
        [MaxLength(11)]
        public int Code { get; set; }
        [Column(TypeName = ("varchar(100)"))]
        public string Label { get; set; }
    }

    public class PurchaseClassification
    {
        [MaxLength(11)]
        public int Id { get; set; }
        [MaxLength(11)]
        public int? Code { get; set; }
        [Column(TypeName = ("varchar(100)"))]
        public string? Label { get; set; }
    }

    public class Margin
    {
        [Key]
        [JsonIgnore]
        public int Id { get; set; }
        [Column(TypeName = ("decimal(20,2)"))]
        public decimal? PurchaseUnitPriceVatExclude { get; set; }
        [Column(TypeName = ("decimal(20,2)"))]
        public decimal? Coefficient { get; set; }
        [Column(TypeName = ("decimal(20,2)"))]
        public decimal? MarginPercent { get; set; }
        [Column(TypeName = ("decimal(20,2)"))]
        public decimal? MarkupPercent { get; set; }
        [Column(TypeName = ("decimal(20,2)"))]
        public decimal? Amount { get; set; }
    }

    public class Supplier
    {
        [MaxLength(11)]
        [Key]
        public int? SupplierId { get; set; }
        [Column(TypeName = ("varchar(100)"))]
        public string? Code { get; set; }
        [Column(TypeName = ("varchar(150)"))]
        public string? Name { get; set; }
    }

    public class CustomFields
    {
        [Key]
        [JsonIgnore]
        public int Id { get; set; }
        public CustomFieldApi? CustomFieldApi { get; set; }
        public CustomFieldApi2? CustomFieldApi2 { get; set; }
    }

    public class CustomFieldApi
    {
        [Key]
        [JsonIgnore]
        public int? Id { get; set; }
        [Column(TypeName = ("varchar(100)"))]
        public string? Label { get; set; }
        [Column(TypeName = ("varchar(100)"))]
        public string? Value { get; set; }
    }

    public class CustomFieldApi2
    {
        [Key]
        [JsonIgnore]
        public int Id { get; set; }
        [Column(TypeName = ("varchar(100)"))]
        public string? Label { get; set; }
        [Column(TypeName = ("varchar(100)"))]
        public string? Value { get; set; }
    }

}
