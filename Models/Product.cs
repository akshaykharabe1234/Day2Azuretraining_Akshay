/* -------------------------------------------------------------------------------------------------
   Copyright (C) Siemens Healthcare GmbH 2023, All rights reserved. Restricted.
   ------------------------------------------------------------------------------------------------- */
   
namespace WebAppWithSQLDB.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string? ProductName { get; set; }
        public int Quantity { get; set; }
    }
}
