/* 
 * MyAnimeList API (beta ver.)
 *
 * MyAnimeList.net is the property of MyAnimeList, LLC. ©2019 All Rights Reserved.  ## Versioning  There are multiple versions of the API. You can specify a version by including it in the request uri:  (During closed beta, version starts with '0.')  `https://api.myanimelist.net/v2`  The version is incremented if any backwards incompatible changes are introduced to the API.  Examples of backwards incompatible changes are belows:  - Removing existing endpoints. - Removing existing fields of API responses. - Changing mean of the existing fields.  On the other hand, belows are examples of backwards compatible changes:  - Adding new endpoints. - Adding new optional request parameters. - Adding new fields to existing API responses. - Changing the order of fields in existing API responses. - Changing the contents of fields that suffixed by `_formatted`.   ## Common formats  ### List / Pagination  ```json {   \"data\": [     {...},     {...},     ...   ],   \"paging\": {     \"previous\": \"https://xxx\",     \"next\": \"https://xxx\"   } } ```      ### Date / Time format  <table> <tr> <th>Format <th>Type <th>Sample <th>Description </tr>  <tr> <td>date-time <td>string <td>\"2015-03-02T06:03:11+00:00\"  <td>ISO 8601 </tr>      <tr> <td>date <td>string <td>\"2017-10-23\" or <br>\"2017-10\" or <br>\"2017\" <td> </tr>  <tr> <td>time <td>string <td>\"01:35\" <td> </tr>  </table>  ### Error format   ```json {   \"error\": \"invalid_token\"   \"message\": \"token is invalid\", } ```  ## Common parameters  ### Parameters for endpoints that return a list  | Name | Description | | - -- | - -- | | limit |  | | offset |  |  ### Choosing fields  By default, the API doesn’t return all fields.  You can choose the fields that you want returned with the `fields` parameter.  Example:  ``` fields=synopsis,my_list_status{priority,comments} ```  ### Not Safe For Work  By default, some APIs don’t return nsfw content.  You can control this behavior with the `nsfw` parameter.  | Name | Description | | - -- | - -- | | nsfw | `true` or `false` |   ## Common status codes  | Status code | Error code | Description | | - -- - | - -- - | - -- - | | 400 Bad Request | - | Invalid Parameters | | 401 Unauthorized | invalid_token | Expired access tokens, Invalid access tokens, etc. | | 403 Forbidden | - | DoS detected etc. | | 404 Not Found | - | |  # Authentication  <!- - ReDoc-Inject: <security-definitions> - ->
 *
 * The version of the OpenAPI document: 2
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using OpenAPIDateConverter = OpenMAL.API.Client.OpenAPIDateConverter;

namespace OpenMAL.API.Model
{
    /// <summary>
    /// \&quot;synonyms\&quot; or ISO 639-1 
    /// </summary>
    [DataContract]
    public partial class WorkForListAllOfAlternativeTitles :  IEquatable<WorkForListAllOfAlternativeTitles>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkForListAllOfAlternativeTitles" /> class.
        /// </summary>
        /// <param name="synonyms">synonyms.</param>
        /// <param name="en">en.</param>
        /// <param name="ja">ja.</param>
        public WorkForListAllOfAlternativeTitles(List<string> synonyms = default(List<string>), string en = default(string), string ja = default(string))
        {
            this.Synonyms = synonyms;
            this.En = en;
            this.Ja = ja;
        }
        
        /// <summary>
        /// Gets or Sets Synonyms
        /// </summary>
        [DataMember(Name="synonyms", EmitDefaultValue=true)]
        public List<string> Synonyms { get; set; }

        /// <summary>
        /// Gets or Sets En
        /// </summary>
        [DataMember(Name="en", EmitDefaultValue=true)]
        public string En { get; set; }

        /// <summary>
        /// Gets or Sets Ja
        /// </summary>
        [DataMember(Name="ja", EmitDefaultValue=true)]
        public string Ja { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkForListAllOfAlternativeTitles {\n");
            sb.Append("  Synonyms: ").Append(Synonyms).Append("\n");
            sb.Append("  En: ").Append(En).Append("\n");
            sb.Append("  Ja: ").Append(Ja).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as WorkForListAllOfAlternativeTitles);
        }

        /// <summary>
        /// Returns true if WorkForListAllOfAlternativeTitles instances are equal
        /// </summary>
        /// <param name="input">Instance of WorkForListAllOfAlternativeTitles to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkForListAllOfAlternativeTitles input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Synonyms == input.Synonyms ||
                    this.Synonyms != null &&
                    input.Synonyms != null &&
                    this.Synonyms.SequenceEqual(input.Synonyms)
                ) && 
                (
                    this.En == input.En ||
                    (this.En != null &&
                    this.En.Equals(input.En))
                ) && 
                (
                    this.Ja == input.Ja ||
                    (this.Ja != null &&
                    this.Ja.Equals(input.Ja))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Synonyms != null)
                    hashCode = hashCode * 59 + this.Synonyms.GetHashCode();
                if (this.En != null)
                    hashCode = hashCode * 59 + this.En.GetHashCode();
                if (this.Ja != null)
                    hashCode = hashCode * 59 + this.Ja.GetHashCode();
                return hashCode;
            }
        }

    }

}
