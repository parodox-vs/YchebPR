//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ychkapustnikov.AppData
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProductIngredients
    {
        public int ProductID { get; set; }
        public int IngredientID { get; set; }
        public decimal Quantity { get; set; }
        public byte[] Timestamp { get; set; }
    
        public virtual Ingredients Ingredients { get; set; }
        public virtual Products Products { get; set; }
    }
}
