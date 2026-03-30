const canvas = document.getElementById("canvas")
const ctx = canvas.getContext("2d")

function canvas_render() {

    canvas.style.left = `${g.min_width}px`
    canvas.style.top = `${g.min_height}px`
    canvas.width = g.max_width
    canvas.height = g.max_height

    ctx.fillStyle = "black"
    ctx.fillRect(50, 50, 50, 50)

}

