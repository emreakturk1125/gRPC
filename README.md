 
# ------------------- gRPC Nedir -----------------

-> gRPC birçok dil için desteği mevcuttur.
-> Remote Procedure Call kütüphanesidir.
-> Farklı bir sunucuda olan fonksiyonu tetikleme işlemidir. Kendi ortamındaki bir fonksiyonmuş gibi çağıma işlemidir.
-> Http/2 protocol ü üzerinden, aynı zamanda binary protocol da denilmektedir. İletişim binary formatta yapılır. Json ve xml formatlarını da destekler
-> Binary format diğer formatlara göre daha hızlıdır.

# ------------- Hangi durumlarda tercih edilebilir -----------

-> Client ve server arasındaki veri iletimini hızlandırmak için
-> CPU, Memory, bant genişliği kullanımının önemli ve kritik olduğu durumlarda JSON yerine BINARY formatta olduğu için tercih edilebilir
-> Microservice mimaride birbirinden bağımsız servisler arasındaki veri alışverişi monolitic uygulamalara göre
-> IOT nesnelerin interneti dediğimiz cihazlar arası iletişim için iyi bir seçenektir.


-> Restful (metinsel tabanlı) servisler external(dış) bir client tarafından tüketilmek için daha uygun yapıya sahiptir.
-> gRPC (binary tabanlı) internal davranış sergileyen microservis gibi mimarilere daha uygundur


# -------------------- gRPC nin kullandığı protocol ----------------------

-> Protocol Buffers(Protobuf) binary serilizasyon protokolüdür.


# ----------------   gRPC ve Restful arasındaki farklar ----------------------

* restful

-> metinsel tabanlı
-> Restful servisler de istemciye bir sonuc döndürülecekse  verinin bütün oluşturulmasını beklemen gerekiyor en response dönüyor

* gRPC

-> Binary tabanlı
-> gRPC de veri oluşturdıkça stream olarak parça parça, binary formatında gönderebilirsin (örneğin youtube videosu izleyebilmek içim tüm videonun yüklenmesine gerek yok parça parça yüklenir)


#------------------------ gRPC iletişim tipleri --------------------

-> Unary; tek bir istek gönderilir ve tek bir response   alınır
-> Server Streaming;  Server Streaming türünde bir imzadır. tek bir istek gönderilir ve birden fazla response alınır
-> Client Streaming; Birden fazla istek yapılıyor stream olarak ve tek bir response alınır
-> Bi-Directional Streaming; Stream request gönderilir ve stream response alınır


# ------  Proto dosyası --------------

-> grpcClient içindeki proto dosyası, grpcServer deki proto dosyası ile aynı olmak zorundadır.
-> gRPC üzerinden yapılacak iletişim için dilden bağımsız ortak bir nokta oluşturmaya yarar.
-> Client ve server arasındaki mesajlaşma, servis türlerinin tanımlamalarının yapıldığı dosyadır. Ortak protokoldür.
-> Proto, dil tarafından desteklenen proto compiler tarafından compile edildikten sonra ilgili proje için gerekli sınıflar oluşturulur.
 





