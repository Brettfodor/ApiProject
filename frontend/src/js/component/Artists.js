
export default function Artists(artists) {
    return `
    <ul>
            ${artists
              .map(artist => {
                return `
                    <li>
                        <h3>${artist.name}</h3>
                        <input class="artist__id" type="hidden" value="${artist.id}">
                        <button class="edit-artist__submit" >Edit</button>
                        <button class="delete-artist__submit">Delete</button>
                    </li>
                `;
              })
              .join("")}
         </ul>
         <section class='add-artist'>
            <input class='add-artist__artistname' type='text' placeholder='Add an artist!'>
            <button class='add-artist__submit'>Submit</button>
        </section>
    `
}