const topSelect = document.querySelector("div#topSelect");
const subSelect = document.querySelector("div#subSelect");
const selectOptions = document.querySelectorAll("div.select-box div.options div.option");

selectOptions.forEach(option => {
    option.addEventListener("click", () => {
        if (option.classList.contains("selected")) return;
        const route = option.dataset.route;
        window.location.href = route;
    });
});

document.querySelector("body").addEventListener("click", ev => {
    const topClasses = topSelect.classList;
    const subClasses = subSelect.classList;
    const parentElement = ev.target.parentElement;

    if (!(parentElement.classList.contains("banner-top-nav") || parentElement.classList.contains("banner-sub-nav") || parentElement.id == "topSelect" || parentElement.id == "subSelect")) {
        if (topClasses.contains("open")) {
            topSelect.classList.remove("open");
        }

        if (subClasses.contains("open")) {
            subSelect.classList.remove("open");
        }
    }
});

topSelect.addEventListener("click", () => {
    const topClasses = topSelect.classList;
    const subClasses = subSelect.classList;

    if (topClasses.contains("open")) {
        topSelect.classList.remove("open");
    } else {
        if (subClasses.contains("open")) {
            subSelect.classList.remove("open");
        }
        topSelect.classList.add("open");
    }
});

subSelect.addEventListener("click", () => {
    const topClasses = topSelect.classList;
    const subClasses = subSelect.classList;

    if (subClasses.contains("open")) {
        subSelect.classList.remove("open");
    } else {
        if (topClasses.contains("open")) {
            topSelect.classList.remove("open");
        }
        subSelect.classList.add("open");
    }
});