Projede Ms SQL ve Microsoft SQL Server Management Studio kulanılmıştır.
Öncelikle veritabanını oluşturmanız gerekir. Bunun için "Netflix.sql" adında bir script verilmiştir. 
Bu scripti "new query" olarak execute edip veritabanını oluşturabilirsiniz.
Programı çalıştırabilmek için kendi bağlantı adresinizi kodun içerisine implement etmeniz gerekir.
Bunun için yapmanız gereken şey Ms SQL ilk açıldığı anda sizi karşılayan ekrandan "Server Name: ..." yazan kısımdaki adresi kopyalayıp,
"Veritabanı.cs" classındaki 14. sastırda yer alan "string kisisel_baglanti_stringi = ..." alanına yapıştırmanız gerekir.