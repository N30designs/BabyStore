using System.ComponentModel.DataAnnotations;
/*Esta clase es una extensión de la case Product, por ello la declaramos como 
 * partial class. Así mismo creamos una clase llamada ProductMetaData que 
 * será la responsable de modificar algunos nombres sin tener que modificar por ello
 * el código del modelo y con ello tener que cambiar todaas sus refrencias.
 * Otra posibilidad es realizarlo todo en una misma clase como hacemos en el ejemplo del Modelo 
 * Category.cs 
 * */
namespace BabyStore.Models
{
    [MetadataType(typeof(ProductMetaData))]
    public partial class Product
    {

    }

    public class ProductMetaData
    {
        [Display(Name = "Nombre de producto")]
        public string Name;
    }
}