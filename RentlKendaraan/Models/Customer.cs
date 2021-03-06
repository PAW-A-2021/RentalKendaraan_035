using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace RentlKendaraan.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Peminjamen = new HashSet<Peminjaman>();
        }

        public int IdCustomer { get; set; }

        [Required(ErrorMessage = "Nama Customer Tidak Boleh Kosong")]
        public string NamaCustomer { get; set; }

        [RegularExpression("^[0-9]*$", ErrorMessage = "Hanya Boleh Diisi Oleh Angka")]
        public string Nik { get; set; }

        [Required(ErrorMessage = "Alamat Tidak Boleh Kosong")]
        public string Alamat { get; set; }

        [MinLength(10, ErrorMessage = "No Hp Minimal 10 Angka")]
        [MaxLength(13, ErrorMessage = "No Hp Maximal 13 Angka")]
        public string NoHp { get; set; }

        public int? IdGender { get; set; }

        public virtual Gender IdGenderNavigation { get; set; }
        public virtual ICollection<Peminjaman> Peminjamen { get; set; }
    }
}