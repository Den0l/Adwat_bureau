//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Adwat_bureau_WPF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Lawyer
    {
        public int ID_Lawyer { get; set; }
        public string LawyerSurname { get; set; }
        public string LawyerName { get; set; }
        public string LawyerMiddleName { get; set; }
        public int Seniority { get; set; }
        public string DiplomaUniversity { get; set; }
        public Nullable<int> Client_ID { get; set; }
    
        public virtual Clients Clients { private get; set; }
    }
}
