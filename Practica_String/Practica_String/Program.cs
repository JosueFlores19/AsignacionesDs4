string cuento = File.ReadAllText(@"D:\Proyectos visual\Practica_String\cuento.txt");
// Se crea un objeto StreamWriter para abrir/crear el archivo "resultado.txt" y escribir en él
// Este objeto facilita la escritura de texto en el archivo de forma eficiente y ordenada
// Usamos "using" para asegurarnos que el archivo se cierre correctamente al terminar la escritura,
// liberando recursos del sistema automáticamente.
using (StreamWriter sw = new StreamWriter("resultado.txt"))
{
    // 1. string.Concat() - Concatenar dos cadenas sin separador
    string concat = string.Concat("Bitín", "Explorador");
    sw.WriteLine("1. Une 'Bitín' con 'Explorador': " + concat);

    // 2. string.Join() - Une elementos de arreglo en una cadena con separador definido
    string[] oraciones = cuento.Split('.');
    string join = string.Join(" | ", oraciones);
    sw.WriteLine("2. Junta oraciones por '.': " + join);

    // 3. string.Format() - Formato de cadena con marcadores para insertar valores
    int letras = cuento.Length;
    int palabras = cuento.Split(new[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Length;
    sw.WriteLine(string.Format("3. El cuento tiene {0} caracteres y {1} palabras.", letras, palabras));

    // 4. Interpolación ($"...") - Inserta variables directamente en cadena texto
    string nombre = "Bitín";
    string meta = "una meta desconocida";
    sw.WriteLine($"4. El protagonista es {nombre} y busca {meta}.");

    // 5. Convert.ToString() - Convierte valores (números) a cadenas
    sw.WriteLine("5. La longitud del cuento es: " + Convert.ToString(cuento.Length));

    // 6. IndexOf() - Busca la primera posición donde aparece una subcadena
    int posMundo = cuento.IndexOf("mundo");
    sw.WriteLine("6. Primera posición de 'mundo': " + posMundo);

    // 7. LastIndexOf() - Busca la última posición donde aparece una subcadena
    int posCerosUltima = cuento.LastIndexOf("ceros");
    sw.WriteLine("7. Última posición de 'ceros': " + posCerosUltima);

    // 8. Contains() - Verifica si la cadena contiene cierta subcadena (true/false)
    bool contieneNube = cuento.Contains("Nube");
    sw.WriteLine("8. ¿Contiene 'Nube'? " + (contieneNube ? "Sí" : "No"));

    // 9. StartsWith() - Indica si la cadena empieza con cierto texto
    bool empiezaVasto = cuento.StartsWith("En el vasto universo");
    sw.WriteLine("9. ¿Empieza con 'En el vasto universo'? " + empiezaVasto);

    // 10. EndsWith() - Indica si la cadena termina con cierto texto
    bool terminaCerosUnos = cuento.Trim().EndsWith("ceros y unos.");
    sw.WriteLine("10. ¿Termina con 'ceros y unos.'? " + terminaCerosUnos);

    // 11. Substring() - Extrae un fragmento (subcadena) de la cadena principal
    int idxCiudad = cuento.IndexOf("ciudades luminosas");
    string ciudadLum = idxCiudad >= 0 ? cuento.Substring(idxCiudad, "ciudades luminosas".Length) : "No encontrado";
    sw.WriteLine("11. Extrae 'ciudades luminosas': " + ciudadLum);

    // 12. Remove() - Elimina caracteres desde una posición dada (aquí primeros 15)
    string removido = cuento.Length > 15 ? cuento.Remove(0, 15) : "";
    sw.WriteLine("12. Resto sin 15 primeros caracteres: " + removido);

    // 13. Replace() - Sustituye todas las apariciones de una subcadena por otra
    string reempBitin = cuento.Replace("Bitín", "ProgramaX");
    sw.WriteLine("13. Reemplaza 'Bitín' por 'ProgramaX': " + reempBitin);

    // 14. Insert() - Inserta una cadena después de una posición específica
    int idxFirewall = cuento.IndexOf("firewall");
    string insertFirewall = idxFirewall >= 0 ?
        cuento.Insert(idxFirewall + "firewall".Length, "(IMPORTANTE)") : cuento;
    sw.WriteLine("14. Inserta '(IMPORTANTE)' después de 'firewall': " + insertFirewall);

    // 15. PadLeft() - Rellena la cadena a la izquierda con un carácter hasta longitud dada
    string padLeftBitin = "Bitín".PadLeft(10, '*');
    sw.WriteLine("15. 'Bitín' con * a la izq.: " + padLeftBitin);

    // 16. PadRight() - Rellena la cadena a la derecha con un carácter hasta longitud dada
    string padRightNube = "Nube".PadRight(12, '-');
    sw.WriteLine("16. 'Nube' con - a la der.: " + padRightNube);

    // 17. Trim() - Elimina espacios al inicio y final de la cadena
    string fragTrim = "  firewall  ";
    sw.WriteLine("17. Extra ('  firewall  ') sin espacios: '" + fragTrim.Trim() + "'");

    // 18. TrimStart() - Elimina solo espacios iniciales
    string inicio = "   Mundo binario";
    sw.WriteLine("18. Solo inicio ('   Mundo binario'): '" + inicio.TrimStart() + "'");

    // 19. TrimEnd() - Elimina solo espacios finales
    string final = "Bitín explorador   ";
    sw.WriteLine("19. Solo final ('Bitín explorador   '): '" + final.TrimEnd() + "'");

    // 20. Split() - Divide la cadena en palabras usando separadores
    string[] palabrasCuento = cuento.Split(new[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
    sw.WriteLine("20. Primeras 10 palabras del cuento: " + string.Join(", ", palabrasCuento.Take(10)));

    // 21. Equals() - Compara dos cadenas exactamente (case sensitive)
    bool igualNube = "Nube".Equals("nube");
    sw.WriteLine("21. ¿'Nube' es igual a 'nube'? " + igualNube);

    // 22. Compare() - Compara dos cadenas alfabéticamente, devuelve entero <0,0,>0
    int compBitinFirewall = string.Compare("Bitín", "Firewall");
    sw.WriteLine("22. Comparación alfabética ('Bitín', 'Firewall'): " + compBitinFirewall);

    // 23. CompareTo() - Compara cadenas similar a Compare(), devuelve número según orden
    int compToNubeCielo = "Nube".CompareTo("Cielo");
    sw.WriteLine("23. CompareTo entre 'Nube' y 'Cielo': " + compToNubeCielo);

    // 24. IsNullOrEmpty() - Verifica si una cadena es null o cadena vacía ("")
    string vacia = "";
    sw.WriteLine("24. ¿Cadena vacía es nula/vacía? " + string.IsNullOrEmpty(vacia));

    // 25. IsNullOrWhiteSpace() - Verifica si cadena es null o solo espacios
    string espacios = "   ";
    sw.WriteLine("25. ¿Cadena con solo espacios es nula/espacios? " + string.IsNullOrWhiteSpace(espacios));

    // 26. ToLower() - Convierte toda la cadena a minúsculas
    sw.WriteLine("26. Cuento en minúsculas: " + cuento.ToLower());

    // 27. ToUpper() - Convierte toda la cadena a mayúsculas
    sw.WriteLine("27. Cuento en mayúsculas: " + cuento.ToUpper());

    // 28. ToLowerInvariant() - Convierte cadena a minúsculas sin considerar cultura local
    sw.WriteLine("28. 'NUBE' a minúsculas: " + "NUBE".ToLowerInvariant());

    // 29. ToUpperInvariant() - Convierte cadena a mayúsculas sin considerar cultura local
    sw.WriteLine("29. 'bitín' a mayúsculas: " + "bitín".ToUpperInvariant());
}
Console.WriteLine("¡Todos los resultados guardados en resultado.txt!");