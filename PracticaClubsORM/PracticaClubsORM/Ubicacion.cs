//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PracticaClubsORM
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ubicacion
    {
        public int UbicacionID { get; set; }
        public Nullable<int> ClubID { get; set; }
        public string Ciudad { get; set; }
        public string Direccion { get; set; }
        public string CodigoPostal { get; set; }
    
        public virtual Clubs Clubs { get; set; }
    }
}
