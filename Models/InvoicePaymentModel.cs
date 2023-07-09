namespace Zoho.Models;

public class Invoice
{
    public int InvoiceId { get; set; }
    public string InvoiceNumber { get; set; }
    public string CustomerName { get; set; }
    public decimal Amount { get; set; }
    
}

public class Payment
{
    public int PaymentId { get; set; }
    public int InvoiceId { get; set; }
    public decimal Amount { get; set; }
    public DateTime PaymentDate { get; set; }
   
}

