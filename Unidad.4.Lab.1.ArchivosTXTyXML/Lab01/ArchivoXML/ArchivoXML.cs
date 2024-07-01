using System.Xml;

Console.WriteLine("Presione una tecla para generar el archivo agendaxml.xml con los datos de agenda.txt");
Console.ReadKey();
escribirXML();
Console.WriteLine("Archivo agendaxml.xml generado correctamente\n\nPresione una tecla para ver su contenido");
Console.ReadKey();
Console.WriteLine();
leerXML();
Console.ReadKey();


static void escribirXML()
{
    XmlTextWriter escritorXML = new XmlTextWriter("agendaxml.xml", null);
    escritorXML.Formatting = Formatting.Indented;
    escritorXML.WriteStartDocument(true);
    escritorXML.WriteStartElement("DocuemntElement");
    StreamReader lector = File.OpenText("C:\\Users\\eugen\\Documents\\Labs .NET\\Labs\\Unidad.4.Lab.1.ArchivosTXTyXML\\Lab01\\Lab01\\agenda.txt");
    string linea;
    do
    {
        linea =lector.ReadLine();
        if (linea != null)
        {
            string[] valores = linea.Split(';');
            escritorXML.WriteStartElement("contactos");
            escritorXML.WriteStartElement("nombre");
            escritorXML.WriteValue(valores[0]);
            escritorXML.WriteEndElement();
            escritorXML.WriteStartElement("apellido");
            escritorXML.WriteValue(valores[1]);
            escritorXML.WriteEndElement();
            escritorXML.WriteStartElement("e-mail");
            escritorXML.WriteValue(valores[2]);
            escritorXML.WriteEndElement();
            escritorXML.WriteStartElement("telefono");
            escritorXML.WriteValue(valores[3]);
            escritorXML.WriteEndElement();
            escritorXML.WriteEndElement();
        }
    }
    while (linea != null);
    escritorXML.WriteEndElement(); // cerramos el tag de Docuemnt Element
    escritorXML.WriteEndDocument();
    escritorXML.Close();

    lector.Close();
}

static void leerXML()
{
    XmlTextReader lectorXML = new XmlTextReader("agendaxml.xml");

    string tagAnterior = "";
    while (lectorXML.Read())
    {
        if (lectorXML.NodeType == XmlNodeType.Element)
        {
            tagAnterior = lectorXML.Name;
        }
        else if (lectorXML.NodeType == XmlNodeType.Text)
        {
            Console.WriteLine(tagAnterior + ": " + lectorXML.Value);
        }
    }
    lectorXML.Close();
}
