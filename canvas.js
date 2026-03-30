const canvas = document.getElementById("canvas")
const ctx = canvas.getContext("2d")

let box_size = 50
let box_pos_x = 50
let box_pos_y = 50

function one_box() {
    ctx.fillStyle = "black"
    ctx.fillRect(box_size, box_size, box_pos_x, box_pos_y)
}

let grid_size_x = 5
let grid_size_y = 5

let grid_x = []

grid_x.length = grid_size_x



grid_x.forEach(element => {
    one_box()
});
console.log(grid_x)

function canvas_render() {

    canvas.style.left = `${g.min_width}px`
    canvas.style.top = `${g.min_height}px`
    canvas.width = g.max_width
    canvas.height = g.max_height

}

