var newname;
var num;
function Addnewitem() {
    var newItem = document.getElementById("my-input").value;
    var liElm = document.createElement("li");
    var dnElm = document.createElement("li");
    var svElm = document.createElement("li");
    liElm.innerText = newItem;
    var btn = document.createElement("button");
    var edbtn = document.createElement("button");
    var dnbtn = document.createElement("button");
    dnbtn.innerText = "done";
    edbtn.innerText = "edit";
    btn.innerText = "X";
    liElm.appendChild(btn);
    liElm.appendChild(edbtn);
    liElm.appendChild(dnbtn);
    btn.onclick = function () {
        var li = this.parentElement;
        li.remove();
    }
    edbtn.onclick = function () {
        var li = this.parentElement;
        var tbox = document.createElement("textarea");
        var svbtn = document.createElement("button");
        svbtn.innerText = "save";
        li.appendChild(tbox);
        li.appendChild(svbtn);
        svbtn.onclick = function () {
            newname = tbox.value;
            li.remove();
            save();
        }
    }
    dnbtn.onclick = function () {
        var li = this.parentElement;
        document.getElementById("dn-list").appendChild(dnElm);
        dnElm.innerText = newItem;
        dnElm.appendChild(btn);
        li.remove();
    }

    document.getElementById("my-list").appendChild(liElm);
    num = document.getElementsByTagName("li");
}
function save() {
    var newItem = newname;
    var liElm = document.createElement("li");
    var dnElm = document.createElement("li");
    var svElm = document.createElement("li");
    liElm.innerText = newItem;
    var btn = document.createElement("button");
    var edbtn = document.createElement("button");
    var dnbtn = document.createElement("button");
    dnbtn.innerText = "done";
    edbtn.innerText = "edit";
    btn.innerText = "X";
    liElm.appendChild(btn);
    liElm.appendChild(edbtn);
    liElm.appendChild(dnbtn);
    btn.onclick = function () {
        var li = this.parentElement;
        li.remove();
    }
    edbtn.onclick = function () {
        var li = this.parentElement;
        var tbox = document.createElement("textarea");
        var svbtn = document.createElement("button");
        svbtn.innerText = "save";
        li.appendChild(tbox);
        li.appendChild(svbtn);
        svbtn.onclick = function () {
            newname = tbox.value;
            li.remove();
            save();
        }
    }
    dnbtn.onclick = function () {
        var li = this.parentElement;
        document.getElementById("dn-list").appendChild(dnElm);
        dnElm.innerText = newItem;
        dnElm.appendChild(btn);
        li.remove();
    }

    document.getElementById("my-list").insertBefore(liElm, document.getElementById("my-list").children[num]);
}