$(document).ready(function () {
    $(".navbar a, footer a[href='#myPage']").on('click', function (event) {
        if (this.hash !== "") {

            event.preventDefault();
            var hash = this.hash;

            $('html, body').animate({
                scrollTop: $(hash).offset().top
            }, 900, function () {

                window.location.hash = hash;
            });
        } 
    });

    $(window).scroll(function () {
        $(".slideanim").each(function () {
            var pos = $(this).offset().top;

            var winTop = $(window).scrollTop();
            if (pos < winTop + 600) {
                $(this).addClass("slide");
            }
        });
    });
})
window.onload = function () {
    console.log("u", localStorage.getItem("username"));
    if (localStorage.getItem("username") != null && localStorage.getItem("password") != null) {
        $("#container").load('Account.html');
    }
}
window.onload = function () {
    console.log("u", localStorage.getItem("username"));
    if (localStorage.getItem("username") != null && localStorage.getItem("password") != null) {
        $("#container").load('Account.html');
    }
    var callModal = document.getElementById('callModal');
    var modal = document.getElementById('myFirstModal');
    var closeButton = document.getElementById('closeButton');
    callModal.onclick = function () {
        $('body').css ({
            "overflow": "hidden"
        });
        modal.style.display = 'block';
    };
    window.onclick = function (event) {
        if (event.target == modal) {
            $('body').css({
                "overflow": ""
            });
            modal.style.display = 'none';
        }
    }
    closeButton.onclick = function () {
        $('body').css({
            "overflow": ""
        });
        modal.style.display = 'none';
    }
};

$('.sbtn').click(function () {
    document.location.href = "Signin.html";
})

$('.sub').click(function () {
    
    alert("Your mennage has been sent");
});
var user = "username";
var password = "password";
$('#reg').click(function (event) {
    event.preventDefault();
    var email = $('#email').val();
    var pass = $('#pass').val();
    localStorage.setItem(user, email);
    localStorage.setItem(password, pass);
})
$('#in').click(function (event) {
    event.preventDefault();
    var i,j;
    var email = $('#mail').val();
    var pass = $('#pwd').val();
    if (localStorage.getItem("username") != null) {
        $("#container").load('Account.html');
    }
    else alert("You're not registered");
})
$('#accx').click(function () {
    $("#container").load("Account2.html");
    localStorage.removeItem("username");
    localStorage.removeItem("password");
})