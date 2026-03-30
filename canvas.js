const canvas = document.getElementById("canvas")
const ctx = canvas.getContext("2d")

let box_size = 50
let box_pos_x = 50
let box_pos_y = 50

function one_box() {
    ctx.fillStyle = "black"
    ctx.fillRect(box_size, box_size, box_pos_x, box_pos_y)
}



function canvas_render() {

    canvas.style.left = `${g.min_width}px`
    canvas.style.top = `${g.min_height}px`
    canvas.width = g.max_width
    canvas.height = g.max_height

    one_box()





}

