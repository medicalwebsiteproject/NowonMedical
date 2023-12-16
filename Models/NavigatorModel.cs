using System.Runtime.ConstrainedExecution;
using System.Collections.Generic;

namespace NowonMedical.Models
{
    public class NavigatorModel
    {
        public readonly Dictionary<string, string[]> Navigator = new Dictionary<string, string[]>();
        public int TopMenuIdx = 0;
        public int SubMenuIdx = 0;

        public NavigatorModel(int TopMenuIdx, int SubMenuIdx) 
        {
            Navigator["병원 소개"] = [
                "병원 소개",
                "의료진 소개",
                "오시는 길",
                "진료시간표"
            ];

            Navigator["진료 안내"] = [
                "척추클리닉",
                "관절클리닉",
                "신경통증클리닉",
                "도수치료",
                "체외충격파",
                "재활치료"
            ];

            Navigator["커뮤니티"] = [
                "공지사항",
                "진료후기",
                "보도자료"
            ];

            this.TopMenuIdx = TopMenuIdx; 
            this.SubMenuIdx = SubMenuIdx;
        }
    }
}
