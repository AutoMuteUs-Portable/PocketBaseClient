
// This file was generated automatically on 6/12/2022 17:21:47(UTC) from the PocketBase schema for Application orm-csharp-test (https://orm-csharp-test.pockethost.io)
//
// PocketBaseClient-csharp project: https://github.com/iluvadev/PocketBaseClient-csharp
// Issues: https://github.com/iluvadev/PocketBaseClient-csharp/issues
// License (MIT): https://github.com/iluvadev/PocketBaseClient-csharp/blob/main/LICENSE
//
// pocketbase-csharp-sdk project: https://github.com/PRCV1/pocketbase-csharp-sdk 
// pocketbase project: https://github.com/pocketbase/pocketbase

using pocketbase_csharp_sdk.Json;
using PocketBaseClient.Orm;
using PocketBaseClient.Orm.Attributes;
using PocketBaseClient.Orm.Json;
using PocketBaseClient.Orm.Validators;
using PocketBaseClient.Services;
using System.ComponentModel.DataAnnotations;
using System.Net.Mail;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace PocketBaseClient.SampleApp.Models
{
    public partial class Category : ItemBase
    {
        #region Collection
        private static CollectionBase? _Collection = null;
        [JsonIgnore]
        public override CollectionBase Collection => _Collection ??= DataServiceBase.GetCollection<Category>()!;
        #endregion Collection

        #region Field Properties
        private string? _Name = null;
        [JsonPropertyName("name")]
        [PocketBaseField(id: "p221scv1", name: "name", required: false, system: false, unique: false, type: "text")]
        public string? Name
        {
           get => Get(() => _Name);
           set => Set(value, ref _Name);
        }


        #endregion Field Properties

        public override void UpdateWith(ItemBase itemBase)
        {
            base.UpdateWith(itemBase);

            if (itemBase is Category item)
            {
                Name = item.Name;

            }
        }

        public override string ToString()
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            return JsonSerializer.Serialize(this, options);
        }

        #region GetById
        public static Category? GetById(string id, bool forceLoad = false) 
            => DataServiceBase.GetCollection<Category>()!.GetById(id, forceLoad);

        public static async Task<Category?> GetByIdAsync(string id, bool forceLoad = false)
            => await DataServiceBase.GetCollection<Category>()!.GetByIdAsync(id, forceLoad);
        #endregion GetById
    }
}
