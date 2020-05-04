function solution() {
    let totalUl = document.querySelectorAll("ul").length;
    let totalOl = document.querySelectorAll("ol").length;

    let biggest = Math.max(totalUl, totalOl);
    return biggest;
}




