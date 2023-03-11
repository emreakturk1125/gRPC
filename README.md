 
# ------------------- gRPC Nedir -----------------

-> gRPC birçok dil için desteği mevcuttur.<br>
-> Remote Procedure Call kütüphanesidir.<br>
-> Farklı bir sunucuda olan fonksiyonu tetikleme işlemidir. Kendi ortamındaki bir fonksiyonmuş gibi çağıma işlemidir.<br>
-> Http/2 protocol ü üzerinden, aynı zamanda binary protocol da denilmektedir. İletişim binary formatta yapılır. Json ve xml formatlarını da destekler<br>
-> Binary format diğer formatlara göre daha hızlıdır.<br>

# ------------- Hangi durumlarda tercih edilebilir -----------

-> Client ve server arasındaki veri iletimini hızlandırmak için<br>
-> CPU, Memory, bant genişliği kullanımının önemli ve kritik olduğu durumlarda JSON yerine BINARY formatta olduğu için tercih edilebilir<br>
-> Microservice mimaride birbirinden bağımsız servisler arasındaki veri alışverişi monolitic uygulamalara göre<br>
-> IOT nesnelerin interneti dediğimiz cihazlar arası iletişim için iyi bir seçenektir.<br>


-> Restful (metinsel tabanlı) servisler external(dış) bir client tarafından tüketilmek için daha uygun yapıya sahiptir.<br>
-> gRPC (binary tabanlı) internal davranış sergileyen microservis gibi mimarilere daha uygundur<br>


# -------------------- gRPC nin kullandığı protocol ----------------------

-> Protocol Buffers(Protobuf) binary serilizasyon protokolüdür.


# ----------------   gRPC ve Restful arasındaki farklar ----------------------

* restful<br>

-> metinsel tabanlı<br>
-> Restful servisler de istemciye bir sonuc döndürülecekse  verinin bütün oluşturulmasını beklemen gerekiyor en response dönüyor<br>

* gRPC<br>

-> Binary tabanlı<br>
-> gRPC de veri oluşturdıkça stream olarak parça parça, binary formatında gönderebilirsin (örneğin youtube videosu izleyebilmek içim tüm videonun yüklenmesine gerek yok parça parça yüklenir)<br>


# ------------------------ gRPC iletişim tipleri --------------------

-> Unary; tek bir istek gönderilir ve tek bir response   alınır<br>
-> Server Streaming;  Server Streaming türünde bir imzadır. tek bir istek gönderilir ve birden fazla response alınır<br>
-> Client Streaming; Birden fazla istek yapılıyor stream olarak ve tek bir response alınır<br>
-> Bi-Directional Streaming; Stream request gönderilir ve stream response alınır<br>


# ------  Proto dosyası --------------

-> grpcClient içindeki proto dosyası, grpcServer deki proto dosyası ile aynı olmak zorundadır.<br>
-> gRPC üzerinden yapılacak iletişim için dilden bağımsız ortak bir nokta oluşturmaya yarar.<br>
-> Client ve server arasındaki mesajlaşma, servis türlerinin tanımlamalarının yapıldığı dosyadır. Ortak protokoldür.<br>
-> Proto, dil tarafından desteklenen proto compiler tarafından compile edildikten sonra ilgili proje için gerekli sınıflar oluşturulur.<br>
 





