using System;
using System.ComponentModel.DataAnnotations;

namespace OnSale.Commom.Entities
{
    public class ProductImage
    {
        public int Id { get; set; }

        [Display(Name = "Image")]
        public Guid ImageId { get; set; }

        //TODO: Pending to put the correct paths
        [Display(Name = "Image")]
        public string ImageFullPath => ImageId == Guid.Empty
            ? $"https://onsalepablo.azurewebsites.net/images/noimage.png"
            : $"https://onsale12.blob.core.windows.net/products/{ImageId}";
    }

}
