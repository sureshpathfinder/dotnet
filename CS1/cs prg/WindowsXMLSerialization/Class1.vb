Public Class Book
    Public bookname As String
    Public pubs As String
    Public price As Double
End Class

Class BookSerialization
    Function getxml(ByVal b As Book) As String
        Dim os As New System.Xml.Serialization.XmlSerializer(GetType(Book))
        Dim sw As New System.IO.StringWriter
        os.Serialize(sw, b)

        Return sw.ToString()
    End Function

    Sub loadxml(ByRef b As Book, ByVal xml As String)
        Dim os As New System.xml.Serialization.XmlSerializer(GetType(Book))
        Dim sr As New System.IO.StringReader(xml)
        b = CType(os.Deserialize(sr), Book)
    End Sub
End Class

