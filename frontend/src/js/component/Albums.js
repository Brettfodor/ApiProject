
export default function Albums(albums) {
    return `
    <div class= 'objectGrid'>
            ${albums
              .map(album => {
                return `
                    <div class= 'objectItem'>
                        <img class="album__image" src=${album.image}></img>
                        <h3>${album.title}</h3>
                        <input class="album__id" type="hidden" value="${album.id}">
                        <button class="edit-album__submit" >Edit</button>
                        <button class="delete-album__submit">Delete</button>
                    </div>
                `;
              })
              .join("")}
         </div>
         <section class="add-album">
        <input class="add-album__albumtitle" type="text" placeholder="Add an album!">
        <input class="add-album__albumimg" type="hidden" value="./css/images/genericAlbum.jpg">
        <select class= 'add-album__artistId' name="Artist">
        <option value="1">Gucci Mane</option>
        <option value="2">Blink 182</option>
        <option value="3">Bullet Valentine</option>
        <option value="4">Tom Petty</option>
        </select>
        <button class="add-album__submit">Click Here To Add Album!</button>
        </section>
    `
}
