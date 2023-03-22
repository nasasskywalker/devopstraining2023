﻿using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace CatalogAPI.Models
{
    //user2 modifying the code
    // add sub catalog name

    [Table("Catalog")]
    public class Catalog
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        [Column("Catalog_Id")]
<<<<<<< HEAD
	//CatalogId add length contraint by user3
=======
	//rename CatalogId by user2
>>>>>>> 3ac8e68a4ba6567d229e099fb4b8082180492588
        public long CatalogId { get; set; }
        [Column("Catalog_Name")]
        [Required]
        [StringLength(50)]
	//user3 modifying the code
	// add additional constraint to catalognames
        public string? CatalogName { get; set; }

        //[JsonIgnore]       
       // public Collection<Product> ProductList { get; set; }


    }
}
