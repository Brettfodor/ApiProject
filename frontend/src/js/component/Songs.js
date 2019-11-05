export default function Songs(songs) {
    return `
    <ul>
            ${songs
              .map(song => {
                return `
                    <li>
                        <h3>${song.name}</h3>
                        <input class="song__id" type="hidden" value="${song.id}">
                        <button class="edit-song__submit" >Edit</button>
                        <button class="delete-song__submit">Delete</button>
                    </li>
                `;
              })
              .join("")}
         </ul>
         <section class="add-song">
            <input class="add-song__songtitle" type="text" placeholder="Add a song!">
            <button class="add-song__submit">Submit</button>
        </section>
    `
}