const body = document.body;
const eye = document.querySelector(".eye");
const beam = document.querySelector(".beam");
const passwordInput = document.getElementById("password");

body.addEventListener('mousemove',function(e){
    let rect = beam.getBoundingClientRect()
    let mouseX = rect.right + (rect.width/2);
    let mouseY = rect.top + (rect.height/2);
    let rad = Math.atan2(mouseX-e.pageX,mouseY-e.pageY);
    let deg = (rad*(20/Math.PI)*-1)-350;
    body.style.setProperty('--beam-deg',deg+'deg');

})

eye.addEventListener('click',function(e){
    e.preventDefault();
    body.classList.toggle('show-password');
    passwordInput.type = passwordInput.type==='password'?'text':'password';
    eye.className='eye fa '+(passwordInput.type==='password'?'fa-eye-slash':'fa-eye');
    passwordInput.focus();
})