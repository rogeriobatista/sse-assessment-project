tick();

function tick() {
    const time = new Date().toLocaleTimeString('en-GB', {
        hour12: true,
        hour: "numeric",
        minute: "numeric",
        second: "numeric"
    });

    const clock = document.getElementById('real-time-clock');

    clock.innerHTML = time;

    setTimeout(tick, 1000)
}

document.onmousemove = function (event) {
    const cursor_x = event.pageX;
    const cursor_y = event.pageY;

    const x_value = document.getElementById('mouse-position-x-value');
    const y_value = document.getElementById('mouse-position-y-value');

    x_value.innerHTML = cursor_x;
    y_value.innerHTML = cursor_y;
}