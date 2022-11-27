
// This file was generated automatically on 26/11/2022 18:38:33 from the PocketBase schema for Application orm-csharp-test (https://orm-csharp-test.pockethost.io)
//
// PocketBaseClient-csharp project: https://github.com/iluvadev/PocketBaseClient-csharp
// Issues: https://github.com/iluvadev/PocketBaseClient-csharp/issues
// License (MIT): https://github.com/iluvadev/PocketBaseClient-csharp/blob/main/LICENSE
//
// pocketbase-csharp-sdk project: https://github.com/PRCV1/pocketbase-csharp-sdk 
// pocketbase project: https://github.com/pocketbase/pocketbase

using PocketBaseClient.Orm;
using PocketBaseClient.Orm.Json;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace TestingModel
{
    public partial class TestForRelated : ItemBase
    {
        [JsonPropertyName("number_unique")]
        [JsonPropertyName("number_nonempty")]
        [Required(ErrorMessage = "number_nonempty is required")]
        [JsonPropertyName("number_nonempty_unique")]
        [Required(ErrorMessage = "number_nonempty_unique is required")]

    }
}
