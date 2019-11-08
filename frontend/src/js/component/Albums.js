
export default function Albums(albums) {
    return `
    <ul>
            ${albums
              .map(album => {
                return `
                    <li>
                        <h3>${album.title}</h3>
                        <img src=${album.image}></img>
                        <input class="album__id" type="hidden" value="${album.id}">
                        <button class="edit-album__submit" >Edit</button>
                        <button class="delete-album__submit">Delete</button>
                    </li>
                `;
              })
              .join("")}
         </ul>
         <section class="add-album">
        <input class="add-album__albumtitle" type="text" placeholder="Add an album!">
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
