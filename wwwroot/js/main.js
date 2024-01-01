
const menu_select = document.querySelectorAll("div.equip_menu>div");
var test1 = document.getElementById("ex-body");
var test2 = document.getElementById("c-arm");
var test3 = document.getElementById("zeus");
var title = document.getElementById("title");
var subtitle = document.getElementById("subtitle");
var explain1 = document.getElementById("explain1");
var explain2 = document.getElementById("explain2");
var explain3 = document.getElementById("explain3");
var pic = document.getElementById("pic");

menu_select[0].addEventListener("mouseover", () => {
    test1.style.backgroundColor = "gray";
    test2.style.backgroundColor = "transparent";
    test3.style.backgroundColor = "transparent";
    test1.style.color = "white";
        
    document.getElementById("equip_image").src = "../assets/images/Ex-Body.png";
    document.getElementById("equip_image").style.width = "325px";
    document.getElementById("equip_image").style.height = "325px";

    title.innerText = 'EX-BODY';
    subtitle.innerText = '체형검사 분석 기기';
    subtitle.style.fontSize = "24px";
    explain1.style.display = "block";
    explain2.style.display = "none";
    explain3.style.display = "none";

    pic.style.lineHeight = "475px";
});
menu_select[0].addEventListener("mouseout", () => {
    test1.style.color = "black";
});

menu_select[1].addEventListener("mouseover", () => {
    test1.style.backgroundColor = "transparent";
    test2.style.backgroundColor = "gray";
    test3.style.backgroundColor = "transparent";
    test1.style.color = "black";
    test2.style.color = "white";

    document.getElementById("equip_image").src = "../assets/images/C-ARM.png";
    document.getElementById("equip_image").style.width = "405px";
    document.getElementById("equip_image").style.height = "405px";

    title.innerText = 'C-ARM';
    subtitle.innerText = '실시간 방사선 영상장치';
    subtitle.style.fontSize = "24px";
    explain1.style.display = "none";
    explain2.style.display = "block";
    explain3.style.display = "none";

    pic.style.lineHeight = "425px";
});
menu_select[1].addEventListener("mouseout", () => {
    test2.style.color = "black";
});

menu_select[2].addEventListener("mouseover", () => {
    test1.style.backgroundColor = "transparent";
    test2.style.backgroundColor = "transparent";
    test3.style.backgroundColor = "gray";
    test1.style.color = "black";
    test3.style.color = "white";

    document.getElementById("equip_image").src = "../assets/images/ZEUSWAVE.png";
    document.getElementById("equip_image").style.width = "405px";
    document.getElementById("equip_image").style.height = "405px";
    title.innerText = 'ZEUS WAVE';
    subtitle.innerText = '체외충격파치료기(ESWT)와 의료용레이저조사기(HILT)를 복합한 통증 치료기기';
    subtitle.style.fontSize = "15px";
    explain1.style.display = "none";
    explain2.style.display = "none";
    explain3.style.display = "block";
});
menu_select[2].addEventListener("mouseout", () => {
    test3.style.color = "black";
});