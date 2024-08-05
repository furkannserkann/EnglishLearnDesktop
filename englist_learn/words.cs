using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace englist_learn
{
    static class words
    {

        private static String[] wordArraysName;
        public static String[] getWordArraysName()
        {
            if (wordArraysName == null)
            {
                wordArraysName = new String[getListWordArrays().Count];

                //wordArraysName[0] = "Nesneler - " + Nesneler.GetLength(0).ToString();
                //wordArraysName[1] = "Sıfatlar - " + Sifatlar.GetLength(0).ToString();
                //wordArraysName[2] = "MeyveSebze - " + Fruit.GetLength(0).ToString();
                //wordArraysName[3] = "Fiiller - " + Fiiller.GetLength(0).ToString();
                //wordArraysName[4] = "Aileiliski - " + Aileiliski.GetLength(0).ToString();
                //wordArraysName[5] = "Meslekler - " + Meslekler.GetLength(0).ToString();
                //wordArraysName[6] = "Yerler - " + Yerler.GetLength(0).ToString();
                //wordArraysName[7] = "Renkler - " + Renkler.GetLength(0).ToString();
                //wordArraysName[8] = "Hayvanlar - " + Hayvanlar.GetLength(0).ToString();
                //wordArraysName[9] = "Vucut - " + Vucut.GetLength(0).ToString();
                //wordArraysName[10] = "Zaman - " + Zaman.GetLength(0).ToString();
                //wordArraysName[11] = "Fiiler 1+50 - " + Fiil50_1.GetLength(0).ToString();
                //wordArraysName[12] = "Karışık 1+50 - " + Words_1.GetLength(0).ToString();
                //wordArraysName[13] = "Karışık 2+50 - " + Words_2.GetLength(0).ToString();
                //wordArraysName[14] = "Tümü - " + WordCount.ToString();

                wordArraysName[0] = "UNIT_4 - " + UNIT_3.GetLength(0).ToString();
                wordArraysName[1] = "UNIT_5 - " + UNIT_4.GetLength(0).ToString();
                wordArraysName[2] = "UNIT_6 - " + UNIT_5.GetLength(0).ToString();
                wordArraysName[3] = "UNIT_7 - " + UNIT_6.GetLength(0).ToString();
                wordArraysName[4] = "UNIT_8 - " + UNIT_8.GetLength(0).ToString();
                wordArraysName[5] = "UNIT_9 - " + UNIT_9.GetLength(0).ToString();
                wordArraysName[6] = "UNIT_10 - " + UNIT_10.GetLength(0).ToString();

                wordArraysName[7] = "Tümü - " + WordCount.ToString();
            }

            return wordArraysName;
        }

        private static string[,] GetAllWordArray()
        {
            string[,] customArray = new string[WordCount, WordCount];
            int sayac = 0;
            if (listWordArrays != null)
            {
                for (int i = 0; i < listWordArrays.Count; i++)
                {
                    for (int k = 0; k < listWordArrays[i].GetLength(0); k++)
                    {
                        customArray[sayac, 0] = listWordArrays[i][k, 0];
                        customArray[sayac, 1] = listWordArrays[i][k, 1];

                        sayac++;
                    }
                }
            }

            return customArray;
        }

        private static List<string[,]> listWordArrays;
        private static int WordCount = 0;
        public static List<string[,]> getListWordArrays()
        {
            if (listWordArrays == null)
            {
                listWordArrays = new List<string[,]>();

                //listWordArrays.Add(Nesneler);
                //listWordArrays.Add(Sifatlar);
                //listWordArrays.Add(Fruit);
                //listWordArrays.Add(Fiiller);
                //listWordArrays.Add(Aileiliski);
                //listWordArrays.Add(Meslekler);
                //listWordArrays.Add(Yerler);
                //listWordArrays.Add(Renkler);
                //listWordArrays.Add(Hayvanlar);
                //listWordArrays.Add(Vucut);
                //listWordArrays.Add(Zaman);
                //listWordArrays.Add(Fiil50_1);
                //listWordArrays.Add(Words_1);
                //listWordArrays.Add(Words_2);


                listWordArrays.Add(UNIT_3);
                listWordArrays.Add(UNIT_4);
                listWordArrays.Add(UNIT_5);
                listWordArrays.Add(UNIT_6);
                listWordArrays.Add(UNIT_8);
                listWordArrays.Add(UNIT_9);
                listWordArrays.Add(UNIT_10);

                WordCount = 0;
                for (int i = 0; i < listWordArrays.Count; i++)
                    WordCount += listWordArrays[i].GetLength(0);

                listWordArrays.Add(GetAllWordArray());
            }
            return listWordArrays;
        }

        public static string[,] Nesneler = {
            // NESNELER
            {"sözlük", "dictionary"},
            {"silgi", "eraser"},
            {"kağıt", "paper"},
            {"sandalye", "chair"},
            {"mobilya", "furniture"},
            {"yol", "way"},
            {"yaşam", "life"},
            {"devlet", "state"},
            {"yer", "place"},
            {"durum", "case"},
            {"hükümet", "government"},
            {"alan", "area"},
            {"olay", "fact"},
            {"ay", "month"},
            {"iş", "business"},
            {"üye", "member"},
            {"kanun", "law"},
            {"topluluk", "community"},
            {"başkan", "president"},
            {"fikir", "idea"},
            {"savaş", "war"},
            {"barış", "peace"},
            {"sebep", "reason"},
            {"araştırma", "research"},
            {"mutfak", "kitchen"},
            {"yatak odası", "bedroom"},
            {"oturma odası", "living room"},
            {"yemek odası", "dining room"},
            {"çamaşır odası", "utility room"},
            {"banyo", "bathroom"},
            {"bodrum kat", "basement"},
            {"asansör", "elevator"},
            {"merdiven", "stairs"},
            {"kiler", "cellar"},
            {"çatı katı", "attic"},
            {"salon", "sitting room"},
            {"tuvalet", "toilets"},
    };

        public static String[,] Sifatlar = {
            // SIFATLAR
            {"en kötü", "worst"},
            {"çirkin", "ugly"},
            {"fakir", "poor"},
            {"zengin", "rich"},
            {"genç", "young"},
            {"yaşlı", "old"},
            {"zeki", "clever"},
            {"aptal", "stupid"},
            {"farklı", "different"},
            {"aynı", "same"},
            {"hafif", "light"},
            {"ağır", "heavy"},
            {"eğlenceli", "funny"},
            {"sıkıcı", "boring"},
            {"erken", "early"},
            {"geç", "late"},
            {"cesur", "brave"},
            {"tehlikeli", "dangerous"},
            {"zor", "difficult"},
            {"lezzetli", "delicious"},
            {"taze", "fresh"},
            {"kirli", "dirty"},
            {"yarım", "half"},
            {"aç", "hungry"},
            {"kızgın", "angry"},
            {"hasta", "ill"},
            {"sağlıklı", "healthy"},
            {"imkansız", "impossible"},
            {"kıskanç", "jealous"},
            {"kibar", "polite"},
            {"önceki", "previous"},
            {"yanlış", "wrong"},
    };

        public static String[,] Fruit = {
            // MEYVE - SEBZE
            {"portakal", "orange"},
            {"karpuz", "watermelon"},
            {"ananas", "pineapple"},
            {"üzüm", "grape"},
            {"lahana", "cabbage"},
            {"armut", "pear"},
            {"şeftali", "peach"},
            {"yaban mersini", "blueberries"},
            {"domates", "tomato"},
            {"patates", "potato"},
            {"salatalık", "cucumber"},
            {"kuru soğan", "onion"},
            {"yeşil biber", "green pepper"},
            {"çilek", "strawberry"},
            {"marul", "lettuce"},
            {"mantar", "mushroom"},
            {"limon", "lemon"},
            {"turp", "radish"},
            {"yeşil fasulye", "green beans"},
            {"fasulye", "beans"},
            {"havuç", "carrot"},
            {"bal kabağı", "pumpkin"},
            {"ıspanak", "spinach"},
            {"greyfurt", "grapefruit"},
            {"brokoli", "broccoli"},
            {"kiraz", "cherry"},
            {"zeytin", "olive"},
            {"mısır", "corn"},
            {"biber", "pepper"},
            {"erik", "plum"},
            {"kavun", "melon"},
            {"ahududu", "raspberry"},
            {"sarımsak", "garlic"},
            {"patlıcan", "eggplant"},
            {"bitki", "plant"},
            {"yeşil soğan", "scallion"},
            {"şalgam", "turnip"},
            {"bezelye", "pea"},
            {"kayısı", "apricot"},
            {"nar", "pomegranate"},
            {"hindistan cevizi", "coconut"},
            {"pancar", "beet"},
            {"zencefil", "ginger"}
    };

        public static String[,] Fiiller = {
            // FİİLLER
            {"almak", "get"},
            {"yapmak", "make"},
            {"düşünmek", "think"},
            {"almak", "take"},
            {"vermek", "give"},
            {"anlatmak", "tell"},
            {"çalışmak", "work"},
            {"hissetmek", "feel"},
            {"koymak", "put"},
            {"başlamak", "begin"},
            {"duymak", "hear"},
            {"yaşamak", "live"},
            {"inanmak", "believe"},
            {"getirmek", "bring"},
            {"olmak", "happen"},
            {"ayakta durmak", "stand"},
            {"kaybetmek", "lose"},
            {"buluşmak", "meet"},
            {"dahil etmek", "include"},
            {"devam etmek", "continue"},
            {"harcamak", "spend"},
            {"büyümek", "grow"},
            {"teklif etmek", "offer"},
            {"hatırlamak", "remember"},
            {"ulaşmak", "reach"},
            {"yükseltmek", "raise"},
            {"karar vermek", "decide"},
            {"açıklamak", "explain"},
            {"umut etmek", "hope"},
            {"taşımak", "carry"},
            {"vurmak", "hit"},
            {"anlaşmak", "agree"},
            {"katılmak", "join"},
            {"üretmek", "produce"},
            {"çizmek", "draw"},
            {"seçmek", "choose"},
            {"tutmak", "hold"},
            {"kontrol etmek", "check"},
            {"onaylamak", "confirm"},
            {"dilemek", "wish"},
            {"yıkamak", "wash"},
            {"giymek", "wear"},
            {"kabul etmek", "accept"},
            {"izin vermek", "allow"},
            {"ödünç almak", "borrow"},
            {"şikayet etmek", "complain"},
            {"düşmek", "fall"},
            {"doldurmak", "fill"},
            {"unutmak", "forget"},
            {"incitmek", "hurt"},
            {"dinlemek", "listen"},
            {"ödemek", "pay"},
            {"cevap vermek", "reply"},
            {"imzalamak", "sign"},
            {"hecelemek", "spell"},
            {"çalışmak", "study"},
            {"başarmak", "succeed"},
            {"denemek", "try"},
            {"endişelenmek", "worry"},
            {"değiştirmek", "change"},
            {"tutmak", "keep"},
            {"ayarlamak", "set"},
            {"kalkmak", "stay"}
    };

        public static String[,] Aileiliski = {
            {"çocuklar", "children"},
            {"akrabalar", "relatives"},
            {"erkek nişanlı", "fiance"},
            {"kız nişanlı", "fiancee"},
            {"iş arkadaşı", "colleague"},
            {"koca", "husband"},
            {"karı eş", "wife"},
            {"teyze hala", "aunt"},
            {"amca dayı", "uncle"},
            {"kuzen", "cousin"},
            {"komşu", "neighbor"},
            {"yeğen", "nephew"},
            {"aile", "parents"},
            {"boşanmış", "divorced"},
            {"nişanlı", "engaged"},
            {"evli", "married"},
            {"ayrılmış", "separated"},
            {"evlenmemiş", "unmarried"},
            {"dul", "widowed"}
    };

        public static String[,] Meslekler = {
            {"yazar", "author"},
            {"sanatçı", "artist"},
            {"berber", "barber"},
            {"marangoz", "carpenter"},
            {"genel müdür", "CEO"},
            {"aşçı", "cook"},
            {"dansçı", "dancer"},
            {"dişçi", "dentist"},
            {"mühendis", "engineer"},
            {"itfaiyeci", "fireman"},
            {"bahçıvan", "gardener"},
            {"hakim", "judge"},
            {"avukat", "lawyer"},
            {"yönetici", "manager"},
            {"müzisyen", "musician"},
            {"hemşire", "nurse"},
            {"profesör", "professor"},
            {"sekreter", "secretary"},
            {"şarkıcı", "singer"},
            {"asker", "soldier"},
            {"erkek garson", "waiter"},
            {"kadın garson", "waitress"},
            {"yazar", "writer"},
            {"muhasebeci", "accountant"},
            {"mimar", "architect"},
            {"reklamcı", "advertiser"},
            {"avukat", "attorney"},
            {"astronot", "astronaut"},
            {"esnaf", "artisan"},
            {"sporcu", "athlete"},
            {"çiftçi", "farmer"},
            {"temizlikçi", "cleaner"},
            {"bakıcı", "caretaker"},
            {"antrenör", "coach"},
            {"palyaço", "clown"},
            {"kurye", "courier"},
            {"dalgıç", "diver"},
            {"çiçekçi", "florist"},
            {"balıkçı", "fisher"},
            {"kurucu", "founder"},
            {"manav", "greengrocer"},
            {"stajyer", "intern"},
            {"gazeteci", "journalist"},
            {"gardiyan", "guard"},
            {"memur", "officer"},
            {"hırsız", "thief"},
            {"bilim adamı", "scientist"},
            {"büyücü", "wizard"},
            {"savaşçı", "warrior"},
            {"işçi", "worker"},
    };

        public static String[,] Yerler = {
            {"fırın", "bakery"},
            {"müze", "museum"},
            {"kilise", "church"},
            {"bakkal", "grocer"},
            {"cami", "mosque"},
            {"alışveriş merkezi", "mall"},
            {"kasap", "butcher"},
            {"eczane", "pharmacy"},
            {"göl", "lake"},
            {"nehir", "river"},
            {"deniz", "sea"},
            {"dağ", "mountain"},
    };

        public static String[,] Renkler = {
            {"pembe", "pink"},
            {"mor", "purple"},
            {"kahverengi", "brown"},
            {"turuncu", "orange"},
            {"gri", "grey"},
            {"lacivert", "navy"},
            {"bordo", "maroon"}
    };

        public static String[,] Hayvanlar = {
            {"koyun", "sheep"},
            {"keçi", "goat"},
            {"timsah", "crocodile"},
            {"kutup ayısı", "polar bear"},
            {"inek", "cow"},
            {"fil", "elephant"},
            {"zürafa", "giraffe"},
            {"kaz", "goose"},
            {"horoz", "cock"},
            {"gergedan", "rhino"},
            {"geyik", "deer"},
            {"goril", "gorilla"},
            {"kanguru", "kangaroo"},
            {"yunus balığı", "dolphin"},
            {"sıçan", "rat"},
            {"yarasa", "bat"},
            {"kertenkele", "lizard"},
            {"antilop", "antelope"},
            {"çita", "cheetah"},
            {"bukalemun", "chameleon"},
            {"boğa", "bull"},
            {"sincap", "squirrel"},
            {"öküz", "ox"},
            {"balina", "whale"},
            {"kaplumbağa", "turtle"},
            {"tavşan", "rabbit"},
            {"kurbağa", "frog"},
            {"arı", "bee"}
    };

        public static String[,] Vucut = {
            {"saç", "hair"},
            {"kafa", "head"},
            {"kulak", "ear"},
            {"burun", "nose"},
            {"ağız", "mouth"},
            {"diş", "tooth"},
            {"dişler", "teeth"},
            {"el", "hand"},
            {"parmak", "finger"},
            {"yanak", "cheek"},
            {"kol", "arm"},
            {"bacak", "leg"},
            {"diz", "knee"},
            {"ayak", "foot"},
            {"ayaklar", "feet"},
            {"kalça", "hip"},
            {"sakal", "beard"},
            {"göğüs", "breast"},
            {"çene", "chin"},
            {"dudak", "lip"},
            {"bıyık", "whiskers"},
            {"tırnak", "nail"},
            {"boyun", "neck"},
            {"omuz", "shoulder"},
            {"dil", "tongue"}
    };

        public static String[,] Zaman = {
            {"ocak", "january"},
            {"şubat", "february"},
            {"mart", "march"},
            {"nisan", "april"},
            {"mayıs", "may"},
            {"haziran", "june"},
            {"temmuz", "july"},
            {"ağustos", "august"},
            {"eylül", "september"},
            {"ekim", "october"},
            {"kasım", "november"},
            {"aralık", "december"},
            {"pazartesi", "monday"},
            {"salı", "tuesday"},
            {"çarşamba", "wednesday"},
            {"perşembe", "thursday"},
            {"cuma", "friday"},
            {"cumartesi", "saturday"},
            {"pazar", "sunday"},
            {"ilkbahar", "spring"},
            {"yaz", "summer"},
            {"sonbahar", "autumn"},
            {"kış", "winter"}
    };

        public static String[,] Fiil50_1 = {
            {"anlamına gelmek", "mean"},
            {"görünmek", "seem"},
            {"sağlamak", "provide"},
            {"öncülük etmek", "lead"},
            {"ortaya çıkmak", "appear"},
            {"düşünmek", "consider"},
            {"beklemek", "expect"},
            {"önermek", "suggest"},
            {"izin vermek", "let"},
            {"kalmak", "remain"},
            {"teslim almak", "receive"},
            {"tanımlamak", "describe"},
            {"geliştirmek", "develop"},
            {"sebep olmak", "cause"},
            {"artırmak", "increase"},
            {"örtmek", "cover"},
            {"istemek", "claim"},
            {"oluşturmak", "form"},
            {"içermek", "contain"},
            {"azaltmak", "reduce"},
            {"kurmak", "establish"},
            {"başarmak", "achieve"},
            {"aramak", "seek"},
            {"anlaşmak", "deal"},
            {"servis", "serve"},
            {"temsil etmek", "represent"},
            {"yükselmek", "rise"},
            {"tartışmak", "discuss"},
            {"toplamak", "pick"},
            {"tartışmak", "argue"},
            {"kanıtlamak", "prove"},
            {"zevk almak", "enjoy"},
            {"takdim etmek", "introduce"},
            {"sunmak", "present"},
            {"varmak", "arrive"},
            {"sağlamak", "ensure"},
            {"davranmak", "act"},
            {"ilgili olmak", "relate"},
            {"etkilemek", "affect"},
            {"belirlemek", "identify"},
            {"karşılaştırmak", "compare"},
            {"duyurmak", "announce"},
            {"elde etmek", "obtain"},
            {"belirtmek", "indicate"},
            {"merak etmek", "wonder"},
            {"korumak", "maintain"},
            {"acı çekmek", "suffer"},
            {"önlemek", "avoid"},
            {"varsaymak", "suppose"},
            {"belirlemek", "determine"}//178

    };

        public static String[,] Words_1 = {
            {"iyileştirmek", "treat"},
            {"atmak", "throw"},
            {"ziyaret etmek", "visit"},
            {"mevcut", "exist"},
            {"teşvik etmek", "encourage"},
            {"zorlamak", "force"},
            {"yansıtmak", "reflect"},
            {"itiraf etmek", "admit"},
            {"hazırlamak", "prepare"},
            {"değiştirmek", "replace"},
            {"bahsetmek", "mention"},
            {"keşfetmek", "discover"},
            {"engel olmak", "prevent"},
            {"korkmuş", "afraid"},
            {"varmak", "arrive"},
            {"fatura", "bill"},
            {"kaynatmak", "boil"},
            {"tereyağı", "butter"},
            {"başkent", "capital"},
            {"halı", "carpet"},
            {"ucuz", "cheap"},
            {"ceket", "coat"},
            {"doğru ", "correct"},
            {"günlük", "daily"},
            {"kazanmak", "earn"},
            {"yeterli", "enough"},
            {"uzak", "far"},
            {"şişman", "fat"},
            {"zemin", "floor"},
            {"çatal", "fork"},
            {"alışkanlık", "habit"},
            {"yakışıklı", "handsome"},
            {"nefret etmek", "hate"},
            {"korku", "horror"},
            {"ilgili", "interested"},
            {"gülmek", "laugh"},
            {"ödünç vermek", "lend"},
            {"mektup", "letter"},
            {"öğle yemeği", "lunch"},
            {"yemek", "meal"},
            {"toplantı", "meeting"},
            {"hata", "mistake"},
            {"zıt", "opposite"},
            {"fırın ocak", "oven"},
            {"kişisel", "personal"},
            {"cep", "pocket"},
            {"havuz", "pool"},
            {"sessiz", "quiet"},
            {"tren yolu", "railway"},
            {"buzdolabı", "refrigerator"},
            {"kiralamak", "rent"} // 164
    };

        public static String[,] Words_2 = {
            {"tuvalet", "restroom"},
            {"binmek", "ride"},
            {"yüzük", "ring"},
            {"yükselmek", "rise"},
            {"yol", "road"},
            {"çatı", "roof"},
            {"gül", "rose"},
            {"raf", "shelf"},
            {"gömlek", "shirt"},
            {"ayakkabı", "shoe"},
            {"hasta", "sick"},
            {"etek", "skirt"},
            {"çorap", "socks"},
            {"çorba", "soup"},
            {"kaşık", "spoon"},
            {"pul kaşe", "stamp"},
            {"takım elbise", "suit"},
            {"tatlı", "sweet"},
            {"uzun boylu", "tall"},
            {"kalın", "thick"},
            {"ince", "thin"},
            {"susamış", "thirsty"},
            {"düzenli", "tidy"},
            {"diş fırçası", "toothbrush"},
            {"diş macunu", "toothpaste"},
            {"havlu", "towel"},
            {"kasaba", "town"},
            {"eğitmenler", "trainers"},
            {"pantolon", "trousers"},
            {"iç çamaşırı", "underwear"},
            {"duvar", "wall"},
            {"güçsüz", "weak"},
            {"rüzgar", "wind"},
            {"olağanüstü", "wonderful"},
            {"yurt dışı", "abroad"},
            {"kaza", "accident"},
            {"yıldönümü", "anniversary"},
            {"tavla", "backgammon"},
            {"zil", "bell"},
            {"ısırmak", "bite"},
            {"battaniye", "blanket"},
            {"kutu", "can"},
            {"kapak", "cap"},
            {"soyunma odası", "changing room"},
            {"giyinme odası", "dressing room"},
            {"sakız", "chewing gum"},
            {"tırmanmak", "climb"},
            {"bez", "cloth"},
            {"toplamak", "collect"},
            {"şaşkın", "confused"} // 286
        };

        public static String[,] Words_3 = {
            {"iletişim", "contact"},
            {"maliyet", "cost"},
            {"pamuk", "cotton"},
            {"kanepe", "couch"},
            {"öksürmek", "cough"},
            {"meraklı", "curious"},
            {"müşteri", "customer"},
            {"şirin", "cute"}, // 300
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""}
        };

        public static String[,] Words_4 = {
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""}
        };

        public static String[,] Words_5 = {
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""}
        };

        public static String[,] Words_Yedek = {
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""},
            {"", ""}
        };

        public static String[,] UNIT_3 = {
            {"küvet", "bathtub"},
            {"mutfak dolabı", "cupboard"},
            {"üst tarafı", "above"},
            {"alt tarafı", "below"},
            {"sırasında", "during"},
            {"-nin -nın", "of"},
            {"üzerine", "onto"},
            {"dışında", "outside"},
            {"üzerinde", "over"},
            {"içinden", "throught"},
            {"süresince", "throughout"},
            {"-e -a -ye -ya", "to"},
            {"-e kadar", "until"},
            {"bir olayın bir şeyin üzerine", "upon"},
            {"içinde bünyesinde", "within"},
            {"-siz -sız", "without"},
        };

        public static String[,] UNIT_4 = {
            {"ucuz", "cheap"},
            {"bayanlar küçük omuz veya el çantası", "purse"},
            {"fiş makbuz", "receipt"},
            {"numaralı koltuklar", "seat"},
            {"amir gözetmen", "supervisor"},
            {"şu o", "that"},
            {"bunlar", "these"},
            {"kalın", "thick"},
            {"ince", "thin"},
            {"şunlar onlar", "those"},
            {"cüzdan", "wallet"}
        };

        public static String[,] UNIT_5 = {
            {"biraz", "some"},
            {"birkaç", "a few"},
            {"sayılamayan şeyler için biraz", "a little"},
            {"otomativ fuarı", "automotive fair"},
            {"güzellik yarışması", "beauty contest"},
            {"iş toplantısı", "business meeting"},
            {"tarla", "field"},
            {"uluslararası fuar", "international fair"},
            {"basın konferansı", "press conference"},
            {"güvercin", "pigeon"},
            {"martı", "seagull"},
            {"serçe", "sparrow"}
        };

        public static String[,] UNIT_6 = {
            {"kim", "who"},
            {"kimi kime", "whom"},
            {"kimin", "whose"},
            {"nasıl", "how"},
            {"hangisi", "which"},
            {"onların", "their"},

            {"çağ yaş", "age"},
            {"mimari tarihi", "architectural history"},
            {"mimari", "architecture"},
            {"marka", "brand"},
            {"başkent", "capital city"},
            {"iklim ortam atmosfer", "climate"},
            {"konser", "concert"},
            {"akşam yemeği", "dinner"},
            {"boşanmış", "divorced"},
            {"maaşlı çalışan eleman", "employee"},
            {"işveren", "employer"},
            {"ne büyüklükte", "how big"},
            {"ne kadar hızlı", "how fast"},
            {"ne genişlikte", "how large"},
            {"tür", "kind"},
            {"öğle yemeği", "lunch"},
            {"medeni durum", "marital status"},
            {"bugünlerde", "nowadays"},
            {"portatif", "portable"},
            {"meslek", "profession"},
            {"son zamanlarda, geçenlerde", "recently"},
            {"hasta", "sick"},
            {"çeşit", "sort"},
            {"ders çalışma", "study"},
            {"gece geç yenen yemek", "supper"},
            {"çalışmak araştırmak incelemek", "to study"},
            {"genellikle", "usually"},
            {"ses", "voice"},
            {"ağırlık", "weight"},
            {"iğrenç", "nasty"},
            {"uzun", "tall"},
            {"gezi", "trip"},
            {"nasıl gidiyor", "how is it going"},
            {"buradaki zamanınız iyi geçsin", "have a nice stay"},
            {"iyi yolculuklar", "have a nice trip"},
            {"afiyet olsun", "bon appetit"}
        };

        public static String[,] UNIT_8 = {
            {"dönüşmek, olmak", "to become"},
            {"getirmek", "to bring"},
            {"aramak çağırmak seslenmek", "to call"},
            {"kazanmak, hak para ün vs", "to earn"},
            {"hissetmek", "to feel"},
            {"eklemek, katmak, ilave etmek", "to include"},
            {"tutmak korumak saklamak", "to keep"},
            {"sağlamak, sunmak", "to provide"},
            {"görünmek", "to seem"},
            {"söylemek", "to tell"},
            {"çabuk", "quickly"},
            {"iyi", "well"},
            {"asla, hiç", "never"},
            {"hiç, herhangi bir zamanda", "ever"},
            {"sık sık", "often"},
            {"arada bir", "every now and then"},
            {"arada bir, duruma göre", "occasionally"},
            {"haftada bir", "once a week"},
            {"haftada iki kez", "twice a week"},
            {"haftada üç kez", "thrice a week"},
            {"her iki haftada bir", "in every two weeks"},
            {"her üç haftada bir", "in every three weeks"},
            {"her biri", "each"},
            {"kendim", "my own"},
            {"kendi", "his own"},
            {"birlikte", "together"},
            {"dolayısıyla, bu yüzden, böylece", "so"},
            {"çok", "so much"},
            {"dana eti", "beef"},
            {"çay fincanı", "cup"},
            {"kahve fincanı, kupa", "mug"},
            {"sebze", "vegetable"},
            {"yarın", "tomorrow"},
            {"dün", "yesterday"}
        };

        public static String[,] UNIT_9 = {
            {"aynı fikirde olmak", "to agree"},
            {"görünmek, ortaya çıkmak", "to appear"},
            {"düşünmek, dikkate almak", "to consider"},
            {"tanımlamak açıklamak tarif etmek", "to describe"},
            {"beklemek, tahmin etmek", "to expect"},
            {"düşmek", "to fall"},
            {"artmak, artırmak", "to increase"},
            {"kapsamak, dahil etmek", "to involve"},
            {"liderlik etmek", "to lead"},
            {"izin vermek, serbest bırakmak", "to let"},
            {"uzanmak, ulaşmak", "to reach"},
            {"bir yerden gönderilen bir şeyi almak", "to receive"},
            {"geride kalmak, olduğu gibi kalmak", "to remain"},
            {"hatırlatmak", "to remind"},
            {"gerektirmek", "to require"},
            {"önermek, düşündürmek", "to suggest"},
            {"aslında", "actually"},
            {"herhangi biri, her insan", "anyone"},
            {"herhangi bir şey, her nesne", "anything"},
            {"şu anda", "at the moment"},
            {"bez, kumaş", "cloth"},
            {"giysi", "clothes"},
            {"herkes", "everyone"},
            {"inanç, iman", "faith"},
            {"gelir", "income"},
            {"mektup", "letter"},
            {"kimse", "no one"},
            {"hiçbir şey", "nothing"},
            {"kazanç, kar", "profit"},
        };

        public static String[,] UNIT_10 = {
            {"bir kaç, çok sayıda", "several"},
            {"bir düzine", "a dozen"},
            {"az sayıda", "few"},
            {"bir çok", "many"},
            {"çok fazla", "so many"},
            {"haddinden fazla", "too many"},
            {"onlarca", "tens"},
            {"yüzlerce", "hundreds"},
            {"çay veya kahve fincan tabağı", "saucer"},
            {"kaşık", "spoon"},
            {"çatal", "fork"},
            {"tabak, plaka", "plate"},
            {"çorba kaşığı", "tablespoon"},
            {"çay kaşığı", "teaspoon"},
            {"porsiyon", "serving"},
            {"kaşar peyniri", "yellow cheese"},
            {"margarin yağ", "butter"},
            {"yerfıstığı", "peanut"},
            {"fıstık ezmesi", "peanut butter"},
            {"et", "meat"},
            {"zeytinyağı", "olive oil"},
            {"şarap", "wine"},
            {"teneke kutu", "can"},
            {"paket", "packet"},
            {"sigara", "cigarette"}
        };
    }
}