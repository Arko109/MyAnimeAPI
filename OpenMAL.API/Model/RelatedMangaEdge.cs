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
    /// RelatedMangaEdge
    /// </summary>
    [DataContract]
    public partial class RelatedMangaEdge :  IEquatable<RelatedMangaEdge>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RelatedMangaEdge" /> class.
        /// </summary>
        /// <param name="node">node.</param>
        /// <param name="relationType">The type of the relationship between this work and related work.  - sequel - prequel - alternative_setting - alternative_version - side_story - parent_story - summary - full_story .</param>
        /// <param name="relationTypeFormatted">The format of relation_type for human like \&quot;Alternative version\&quot;. .</param>
        public RelatedMangaEdge(MangaForList node = default(MangaForList), string relationType = default(string), string relationTypeFormatted = default(string))
        {
            this.Node = node;
            this.RelationType = relationType;
            this.RelationTypeFormatted = relationTypeFormatted;
        }
        
        /// <summary>
        /// Gets or Sets Node
        /// </summary>
        [DataMember(Name="node", EmitDefaultValue=false)]
        public MangaForList Node { get; set; }

        /// <summary>
        /// The type of the relationship between this work and related work.  - sequel - prequel - alternative_setting - alternative_version - side_story - parent_story - summary - full_story 
        /// </summary>
        /// <value>The type of the relationship between this work and related work.  - sequel - prequel - alternative_setting - alternative_version - side_story - parent_story - summary - full_story </value>
        [DataMember(Name="relation_type", EmitDefaultValue=false)]
        public string RelationType { get; set; }

        /// <summary>
        /// The format of relation_type for human like \&quot;Alternative version\&quot;. 
        /// </summary>
        /// <value>The format of relation_type for human like \&quot;Alternative version\&quot;. </value>
        [DataMember(Name="relation_type_formatted", EmitDefaultValue=false)]
        public string RelationTypeFormatted { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RelatedMangaEdge {\n");
            sb.Append("  Node: ").Append(Node).Append("\n");
            sb.Append("  RelationType: ").Append(RelationType).Append("\n");
            sb.Append("  RelationTypeFormatted: ").Append(RelationTypeFormatted).Append("\n");
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
            return this.Equals(input as RelatedMangaEdge);
        }

        /// <summary>
        /// Returns true if RelatedMangaEdge instances are equal
        /// </summary>
        /// <param name="input">Instance of RelatedMangaEdge to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RelatedMangaEdge input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Node == input.Node ||
                    (this.Node != null &&
                    this.Node.Equals(input.Node))
                ) && 
                (
                    this.RelationType == input.RelationType ||
                    (this.RelationType != null &&
                    this.RelationType.Equals(input.RelationType))
                ) && 
                (
                    this.RelationTypeFormatted == input.RelationTypeFormatted ||
                    (this.RelationTypeFormatted != null &&
                    this.RelationTypeFormatted.Equals(input.RelationTypeFormatted))
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
                if (this.Node != null)
                    hashCode = hashCode * 59 + this.Node.GetHashCode();
                if (this.RelationType != null)
                    hashCode = hashCode * 59 + this.RelationType.GetHashCode();
                if (this.RelationTypeFormatted != null)
                    hashCode = hashCode * 59 + this.RelationTypeFormatted.GetHashCode();
                return hashCode;
            }
        }

    }

}
