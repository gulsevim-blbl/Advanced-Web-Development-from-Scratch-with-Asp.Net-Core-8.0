using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspnetcore_basics.Models //namespace adı projenizin adı ve hangi klasörde ise onun adı ile aynı olmalı
{
    public class Course
    {
        public int Id { get; set; } //prop yazıp iki kere tab yaparsanız otomatik olarak oluşturur

        public string? Title { get; set; } //? işareti null olabileceğini belirtir
        
        public string? Image { get; set; } //bu resimler wwwroot klasörünün içindeki images klasöründe olacak. static dosyalar wwwroot klasörünün içinde olmalı. 
        public string? Description { get; set; }
    
    }
}