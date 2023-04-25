using System.Collections.Specialized;
using System.Collections;
using System.Security.Cryptography.X509Certificates;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Hashtable ciudades1 = CollectionsUtil.CreateCaseInsensitiveHashtable();

            ciudades1["Corrientes"] = 352646;
            ciudades1["Goya"] = 66129;
            ciudades1["Resistencia"] = 290723;
            ciudades1["Paso de la Patria"] = 5598;

            Assert.Equal(352646, ciudades1["cOrRIeNTES"]);
            Assert.Equal(66129, ciudades1["GOYA"]);
            Assert.Equal(290723, ciudades1["resisTENCIA"]);
            Assert.Equal(5598, ciudades1["Paso de LA PAtria"]);

        }
        [Fact]
        public void Test2() {
            //
            Dictionary<string, int> libros_paginas = new Dictionary<string, int>();

            libros_paginas.Add("Libro1", 300);
            libros_paginas.Add("Libro2", 250);
            libros_paginas.Add("Libro3", 380);
            libros_paginas.Add("Libro4", 500);


            Hashtable libros = CollectionsUtil.CreateCaseInsensitiveHashtable(libros_paginas);

            Assert.Equal(300, libros["LIBRO1"]);
            Assert.Equal(250, libros["LIbro2"]);
            Assert.Equal(380, libros["liBRO3"]);
            Assert.Equal(500, libros["LiBrO4"]);

        }
        [Fact]     
        public void test3() {

           SortedList ciudades2 = CollectionsUtil.CreateCaseInsensitiveSortedList();
            ciudades2.Add("Corrientes", 352646);
            ciudades2.Add("Goya", 66129);
            ciudades2.Add("Resistencia",290723);
            ciudades2.Add("Paso de la Patria", 5598);

            Assert.Equal(352646, ciudades2["cOrRIeNTES"]);
            Assert.Equal(66129, ciudades2["GOYA"]);
            Assert.Equal(290723, ciudades2["resisTENCIA"]);
            Assert.Equal(5598, ciudades2["Paso de LA PAtria"]);
        }
    }
}