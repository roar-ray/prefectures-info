using System;
namespace PrefecturesInfo.Models
{
    public record Prefecture
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string CapitalName { get; set; } = "";
    }

    public class PrefectureDB
    {
        private static List<Prefecture> _prefectures = new List<Prefecture>()
        {
            new Prefecture{Id = 1,Name="北海道",CapitalName="札幌市"},
            new Prefecture{Id = 2,Name="青森県",CapitalName="青森市"},
            new Prefecture{Id = 3,Name="岩手県",CapitalName="盛岡市"},
            new Prefecture{Id = 4,Name="宮城県",CapitalName="仙台市"},
            new Prefecture{Id = 5,Name="秋田県",CapitalName="秋田市"},
            new Prefecture{Id = 6,Name="山形県",CapitalName="山形市"},
            new Prefecture{Id = 7,Name="福島県",CapitalName="福島市"},
            new Prefecture{Id = 8,Name="茨城県",CapitalName="水戸市"},
            new Prefecture{Id = 9,Name="栃木県",CapitalName="宇都宮市"},
            new Prefecture{Id = 10,Name="群馬県",CapitalName="前橋市"},
            new Prefecture{Id = 11,Name="埼玉県",CapitalName="さいたま市"},
            new Prefecture{Id = 12,Name="千葉県",CapitalName="千葉市"},
            new Prefecture{Id = 13,Name="東京都",CapitalName="新宿区"},
            new Prefecture{Id = 14,Name="神奈川県",CapitalName="横浜市"},
            new Prefecture{Id = 15, Name = "新潟県", CapitalName ="新潟市"},
            new Prefecture{Id = 16, Name = "富山県", CapitalName ="富山市"},
            new Prefecture{Id = 17, Name = "石川県", CapitalName ="金沢市"},
            new Prefecture{Id = 18, Name = "福井県", CapitalName ="福井市"},
            new Prefecture{Id = 19, Name = "山梨県", CapitalName ="甲府市"},
            new Prefecture{Id = 20, Name = "長野県", CapitalName ="長野市"},
            new Prefecture{Id = 21, Name = "岐阜県", CapitalName ="岐阜市"},
            new Prefecture{Id = 22, Name = "静岡県", CapitalName ="静岡市"},
            new Prefecture{Id = 23, Name = "愛知県", CapitalName ="名古屋市"},
            new Prefecture{Id = 24, Name = "三重県", CapitalName ="津市"},
            new Prefecture{Id = 25, Name = "滋賀県", CapitalName ="大津市"},
            new Prefecture{Id = 26, Name = "京都府", CapitalName ="京都市"},
            new Prefecture{Id = 27, Name = "大阪府", CapitalName ="大阪市"},
            new Prefecture{Id = 28, Name = "兵庫県", CapitalName ="神戸市"},
            new Prefecture{Id = 29, Name = "奈良県", CapitalName ="奈良県"},
            new Prefecture{Id = 30, Name = "和歌山県", CapitalName ="和歌山市"},
            new Prefecture{Id = 31, Name = "鳥取県", CapitalName ="鳥取市"},
            new Prefecture{Id = 32, Name = "島根県", CapitalName ="松江市"},
            new Prefecture{Id = 33, Name = "岡山県", CapitalName ="岡山市"},
            new Prefecture{Id = 34, Name = "広島県", CapitalName ="広島市"},
            new Prefecture{Id = 35, Name = "山口県", CapitalName ="山口市"},
            new Prefecture{Id = 36, Name = "徳島県", CapitalName ="徳島市"},
            new Prefecture{Id = 37, Name = "香川県", CapitalName ="高松市"},
            new Prefecture{Id = 38, Name = "愛媛県", CapitalName ="松山市"},
            new Prefecture{Id = 39, Name = "高知県", CapitalName ="高知市"},
            new Prefecture{Id = 40, Name = "福岡県", CapitalName ="福岡市"},
            new Prefecture{Id = 41, Name = "佐賀県", CapitalName ="佐賀市"},
            new Prefecture{Id = 42, Name = "長崎県", CapitalName ="長崎市"},
            new Prefecture{Id = 43, Name = "熊本県", CapitalName ="熊本市"},
            new Prefecture{Id = 44, Name = "大分県", CapitalName ="大分市"},
            new Prefecture{Id = 45, Name = "宮崎県", CapitalName ="宮崎市"},
            new Prefecture{Id = 46, Name = "鹿児島県", CapitalName ="鹿児島市"},
            new Prefecture{Id = 47, Name = "沖縄県", CapitalName ="那覇市"},
        };

        public static List<Prefecture> GetPrefectures()
        {
            return _prefectures;
        }

        public static Prefecture? GetPrefecture(int id)
        {
            return _prefectures.SingleOrDefault(prefecture => prefecture.Id == id);
        }

        public static Prefecture CreatePrefecture(Prefecture prefecture)
        {
            _prefectures.Add(prefecture);
            return prefecture;
        }

        public static Prefecture UpdatePrefecture(Prefecture update)
        {
            _prefectures = _prefectures.Select(prefecture =>
            {
                if (prefecture.Id == update.Id)
                {
                    prefecture.Name = update.Name;
                }
                return prefecture;
            }).ToList();
            return update;
        }

        public static void RemovePrefecture(int id)
        {
            _prefectures = _prefectures.FindAll(prefecture => prefecture.Id != id).ToList();
        }
    }

}

