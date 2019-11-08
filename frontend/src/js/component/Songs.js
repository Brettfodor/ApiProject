
export default function Songs(songs) {
    return `
    <ul>
            ${songs
              .map(song => {
                return `
                    <li>
                        <h3>${song.title}</h3>
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
            <select class= 'add-song__albumId' name="Album">
            <option value="1">East Atlanta Santa</option>
            <option value="2">Blink 182</option>
            <option value="3">The Poison</option>
            <option value="4">Full Moon Fever</option>
                </select>
            <button class="add-song__submit">Submit</button>
        </section>
    `
}
