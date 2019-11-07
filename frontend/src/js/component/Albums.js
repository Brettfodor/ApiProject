
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
        <input class="add-album__artistId" type="hidden" value="1">
        <button class="add-Album__Add">Click Here To Add Album!</button>
        </section>
    `
}