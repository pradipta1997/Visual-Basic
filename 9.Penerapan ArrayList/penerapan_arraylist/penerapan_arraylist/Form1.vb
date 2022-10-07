Public Class frmPenerapanArrayList
    Private Sub btnCheckArrayList_Click(sender As Object, e As EventArgs) Handles btnCheckArrayList.Click

        Dim i As Integer
        Dim itemList As New ArrayList()

        'MENAMBAHKAN ARRAYLIST
        itemList.Add("Item 4")
        itemList.Add("Item 5")
        itemList.Add("Item 2")
        itemList.Add("Item 1")
        itemList.Add("Item 3")

        MsgBox("Shows Added Items")

        'LOOPING VARIABEL i
        For i = 0 To itemList.Count - 1

            MsgBox(itemList.Item(i))
        Next

        'MENYISIPKAN ARRAYLIST
        itemList.Insert(3, "Item6")

        'MENGURUTKAN/SORTING ARRAYLIST
        itemList.Sort()

        'MENGHAPUS SALAH SATU ARRAYLIST
        'itemList.Remove("Item 1")

        'MENGHAPUS ITEM DENGAN NO INDEX SECARA SPESIFIK
        itemList.RemoveAt(3)

        MsgBox("Shows final items the ArrayList")

        For i = 0 To itemList.Count - 1

            MsgBox(itemList.Item(i))
        Next

    End Sub
End Class
