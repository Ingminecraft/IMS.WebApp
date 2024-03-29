﻿using IMS.CoreBusiness;
using IMS.UseCases.PluginInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Plugins.InMemory
{
    public class InventoryTransactionRepository : IInventoryTransactionRepository
    {
        public List<InventoryTransaction> _inventoryTransaction = new List<InventoryTransaction>();

        public void PurchaseAsync(string poNumber, Inventory inventory, int quantity, string doneBy, double price)
        {
            this._inventoryTransaction.Add(new InventoryTransaction
                {
                    PONumber = poNumber,
                    InventoryId = inventory.InventoryId,
                    QauntityBefore = inventory.Quantity,
                    ActivityType = InventoryTransactionType.PurchaseInventory,
                    QauntityAfter = inventory.Quantity + quantity,
                    TransactionDate = DateTime.Now,
                    DoneBy = doneBy,
                    UnitPrice = price
                });
        }
    }
}
