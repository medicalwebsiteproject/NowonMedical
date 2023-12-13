let isHide = false;

const openSubMenu = (open) => {
    Array.from(document.querySelectorAll("ul.sub-menu")).forEach(menu => {
        menu.classList[open ? "add" : "remove"]("open");
    });
}

window.onload = () => {
    const topNavs = document.querySelectorAll("ul.top-menu li.item");

    Array.from(topNavs).forEach(nav => {
        nav.addEventListener("mouseover", () => {
            nav.children[1].classList.add("open");
            document.querySelector("nav.main-navigator").style.borderBottom = "1px solid lightgray";
            openSubMenu(true);
        });

        nav.addEventListener("mouseout", () => {
            nav.children[1].classList.remove("open");
            document.querySelector("nav.main-navigator").style.borderBottom = "none";
            openSubMenu(false);
        });
    });

    document.onscroll = ev => {
        window.requestAnimationFrame(() => {
            const aside = document.querySelector("aside");
            const animation = {
                frame: [
                    {
                        top: aside.offsetTop + "px"
                    },
                    {
                        top: (window.scrollY + aside.clientHeight - 50) + "px",
                    }
                ],
                options: {
                    duration: 200,
                    fill: "forwards"
                }
            }

            aside.animate(animation.frame, animation.options);

            if (window.scrollY >= 120) {
                if (!isHide) {
                    isHide = true;
                    const titleBar = document.querySelector("header");
                    const animation = {
                        frame: [
                            {
                                top: "0px"
                            },
                            {
                                top: "-140px"
                            }
                        ],
                        options: {
                            duration: 500,
                            fill: "forwards"
                        }
                    }

                    titleBar.animate(animation.frame, animation.options);
                }
            } else {
                if (isHide) {
                    isHide = false;
                    const titleBar = document.querySelector("header");
                    const animation = {
                        frame: [
                            {
                                top: "-140px"
                            },
                            {
                                top: "0px"
                            }
                        ],
                        options: {
                            duration: 500,
                            fill: "forwards"
                        }
                    }

                    titleBar.animate(animation.frame, animation.options);
                }
            }
        });
    }
}