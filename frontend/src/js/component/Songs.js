
export default function Songs(songs) {
    return `
    <div class='objectGrid'>
            ${songs
              .map(song => {
                return `
                <div class='objectItem'>
                        <h3>${song.title}</h3>
                        <img class="song__image" src=${song.image}></img>                        
                        <input class="song__id" type="hidden" value="${song.id}">
                        
                        <button class="edit-song__submit" >Edit</button>
                        <button class="delete-song__submit">Delete</button>
                </div>
                `;
              })
              .join("")}
         </div>

         <section class="add-song">
            <input class="add-song__songtitle" type="text" placeholder="Add a song!">
            <input class="add-song__songimage" type="hidden" value="./css/images/genericsong.jpg">
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
