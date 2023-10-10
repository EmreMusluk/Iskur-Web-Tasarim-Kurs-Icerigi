function Task1(callBack) {
    setTimeout(() => {
        console.log("Görev 1 bitti..")
        callBack()
    }, 5000)
}

function Task2() {
    setTimeout(() => {
        console.log("Görev 2 bitti..");
    }, 1000)
}

Task1(Task2);

