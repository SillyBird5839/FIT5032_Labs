//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lab20240627Database2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Student
    {
        public Student()
        {
            this.Units = new HashSet<Unit>();
        }
    
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    
        public virtual ICollection<Unit> Units { get; set; }
    }
}
