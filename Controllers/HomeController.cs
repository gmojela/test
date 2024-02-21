
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System;
using MAM.Models;

public class HomeController : Controller
{
  

    public IActionResult Index(List<ItemInputModel> items)
    {
        
        return View(items ?? new List<ItemInputModel>());// handle null inputs
    }

    [HttpPost]
    public IActionResult GenerateReceipt(List<ItemInputModel> items)
    {
        var receiptViewModel = CalculateReceipt(items);
        return View("Receipt", receiptViewModel);
    }

    private ReceiptViewModel CalculateReceipt(List<ItemInputModel> items)
    {
        var totalTax = 0m;
        var totalCost = 0m;
        var receiptItems = new List<ReceiptItemViewModel>();

        foreach (var item in items)
        {
            decimal tax = CalculateTax(item.Price, item);
            decimal itemCost = item.Price + tax;

            totalTax += tax;
            totalCost += itemCost;

           
            receiptItems.Add(new ReceiptItemViewModel
            {
                Name = item.Name,
                Price = item.Price,
                Tax = tax,              
                ImportDuty = item.IsImported ? 0.05m : 0m,// flat 5% on all imports else none added
                ItemCost = itemCost
            });
        }


        return new ReceiptViewModel
        {
            ReceiptItems = receiptItems,
            TotalTax = totalTax,
            TotalCost = totalCost
        };
    }

    private decimal CalculateTax(decimal price, ItemInputModel item)
    {
        
        decimal basicTaxRate = GetTaxRate(item.IsExempt);//get tax rate for none exempt items
        
        decimal importDutyRate = item.IsImported ? 0.05m : 0m;// flat 5% on all imports else 0

        decimal totalTaxRate = basicTaxRate + importDutyRate;// total tax rate (basic + import dury if item was imported)
        //calculate tax 
        decimal tax = Math.Ceiling(item.Price * totalTaxRate / 0.05m) * 0.05m; 
        
        return tax;
    }

    private decimal GetTaxRate(bool IsExempt)
    {
        if(IsExempt)
            return 0m; // Exempt items have 0% basic tax
        return 0.1m; // Basic tax rate of 10% for standard items
       
        }
    }
