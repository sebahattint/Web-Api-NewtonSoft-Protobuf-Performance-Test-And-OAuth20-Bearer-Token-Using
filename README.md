# NewtonSoft vs Protobuf Performans Testi ve Sonuçları

**Google ProtoBuf**

Binary serialization yapan, Google 'ın geliştirdiği bir serileştirme standardı. .Net versiyonunu npm den projenize ekleyebilirsiniz. 
Kullanım detayları ile ilgili bilgi şurada [https://github.com/mgravell/protobuf-net](https://github.com/mgravell/protobuf-net)

Bizim genel olarak kullandığımız NewtonSoft.Json dan daha hızlı ve daha düşük boyutta veri üretiyor. Web API ‘da serialization işlemlerinde NewtonSoft (json) ile Google Protobuf (binary) arasındaki performans ve veri boyutu farkını örnek bir senaryo üzerinden göstermeye çalıştım. Detaylar aşağıda.

**Varolan Web API ‘lar ve Mobil Uygulamalar için**

Daha önce yazdığımız web apilerde ProtoBuf ı uygulayabilmemiz için return ettiğimiz datanın modellerinde **[ProtoContract]** ve **[ProtoMember]** attribute lerini kullanmamız gerekiyor. Daha sonra aşağıdaki örnek test methodunda olduğu gibi serialize edebiliyoruz. ProtoBuf ın diğer bir güzelliğide, return edilen değerin kabak gibi görünmemesi (Aşağıda örnek responselar var). 

Mobil taraftada deserialize işleminin yapılması içinde gerekli implementasyonun yapılması lazım benzer şekilde. Android ve Ios için kullanımlarını nette bulabilirsiniz. Mobil uygulamalarda performansın üst düzey olmasını istiyorsak yapacağımız işlerden biri bu olabilir.

**Örnek Test Senaryosu ve Sonuçları**

**Senaryo :**

TestSerializer methoduna request atılacak ve api de 1000 kaydın serialize edilmesi işleminde geçen süre ve dönen verinin boyutu kontrol edilecek.

**Sonuçlar :**

Newtonsoft: 74 ms, 170 KB
ProtoBuf: 21 ms, 54 KB


**Kullanımı:**

<a href="https://ibb.co/FsQhJ14"><img src="https://i.ibb.co/1sC0KNG/req.jpg" alt="req" border="0"></a>

**Örnek Response ‘lar (Newtonsoft & ProtoBuf) :** 

**Newtonsoft :**

<img src="https://i.ibb.co/kGsym3T/Newtonsoft-1000-Kayit.jpg" alt="Newtonsoft-1000-Kayit" border="0">

**ProtoBuf :**

<img src="https://i.ibb.co/nfyc2tk/Proto-Buf-1000-Kayit.jpg" alt="Proto-Buf-1000-Kayit" border="0">
