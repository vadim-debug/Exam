//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Popov
{
    using System;
    using System.Collections.Generic;
    
    public partial class Orders
    {
        public int Id { get; set; }
        public Nullable<int> User_Id { get; set; }
        public Nullable<int> Product_ID { get; set; }
        public string Name { get; set; }
    
        public virtual Product Product { get; set; }
        public virtual Users Users { get; set; }
    }
}