using System.Data.Common;

public class Sale 
{
    public int Id;
    public DateTime SaleDate;
    public string ProductName;
    public double ProductValue;
    public int ProductAmount;
    public string Seller;
    public string Buyer;
    public int WarrantyTime;

    public Sale(int Id,DateTime SaleDate,string ProductName,double ProductValue,int ProductAmount,string Seller,string Buyer,int WarrantyTime)
    {
    this.Id = Id; 
    this.SaleDate = SaleDate; 
    this.ProductName = ProductName; 
    this.ProductValue = ProductValue; 
    this.ProductAmount = ProductAmount; 
    this.Seller = Seller; 
    this.Buyer = Buyer; 
    this.WarrantyTime = WarrantyTime; 
    }

}