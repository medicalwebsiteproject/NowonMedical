using System.Runtime.ConstrainedExecution;
using System.Collections.Generic;

namespace NowonMedical.Models
{
    public class NavigatorPath {
        public string Name { get; set; }
        public string Path { get; set; }
    }

    public class NavigatorModel
    {
        public readonly Dictionary<string, NavigatorPath[]> Navigator = new Dictionary<string, NavigatorPath[]>();
        public int TopMenuIdx = 0;
        public int SubMenuIdx = 0;

        public NavigatorModel(int TopMenuIdx, int SubMenuIdx) 
        {
            Navigator["병원 소개"] = [
                new NavigatorPath { Name = "병원 소개", Path = "/intro/cover" },
                new NavigatorPath { Name = "의료진 소개", Path = "/intro/figure" },
                new NavigatorPath { Name = "오시는 길", Path = "/intro/path" },
                new NavigatorPath { Name = "진료시간표", Path = "/intro/time" }
            ];

            Navigator["진료 안내"] = [
                new NavigatorPath { Name = "척추클리닉", Path = "/clinic/spine" },
                new NavigatorPath { Name = "관절클리닉", Path = "/clinic/joint" },
                new NavigatorPath { Name = "신경통증클리닉", Path = "/clinic/nerve" },
                new NavigatorPath { Name = "도수치료", Path = "/clinic/therapy" },
                new NavigatorPath { Name = "체외충격파", Path = "/clinic/wave" },
                new NavigatorPath { Name = "재활치료", Path = "/clinic/retain" }
            ];

            Navigator["커뮤니티"] = [
                new NavigatorPath { Name = "공지사항", Path = "/community/notice" },
                new NavigatorPath { Name = "진료후기", Path = "/community/review" },
                new NavigatorPath { Name = "보도자료", Path = "/community/news" }
            ];

            this.TopMenuIdx = TopMenuIdx; 
            this.SubMenuIdx = SubMenuIdx;
        }
    }
}
