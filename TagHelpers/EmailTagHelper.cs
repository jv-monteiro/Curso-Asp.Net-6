using Microsoft.AspNetCore.Razor.TagHelpers;
using System.ComponentModel.DataAnnotations;

namespace CursoUdemy.TagHelpers
{
    public class EmailTagHelper : TagHelper
    {
        [Required]
        [EmailAddress]
        public string Endereco { get; set; }

        [Required]
        public string Conteudo { get; set; }

        //sobreescreve o método process()
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
            output.Attributes.SetAttribute("href", "mailto:" + Endereco);
            output.Content.SetContent(Conteudo);
        }
    }
}
