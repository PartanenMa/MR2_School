import '/src/styles/MainView.css';
import { useState } from 'react';

//MainView:
function MainView() {
    const [isShownMain, setIsShownMain] = useState(true);
    const [isShown1, setIsShown1] = useState(true);
    const [isShown2, setIsShown2] = useState(true);
    const [isShown3, setIsShown3] = useState(true);
    const [isShown4, setIsShown4] = useState(true);
    const [isShownNotes, setIsShownNotes] = useState(true);
    const [NoNotes, setNoNotes] = useState(true);
    const [Notes, setNotes] = useState(true);
    const [NoteAdded, setNoteAdded] = useState(true);
    const [CourseAdded, setCourseAdded] = useState(true);
    const [DeleteCourse, setDeleteCourse] = useState(true);
    const [CourseDeleted, setCourseDeleted] = useState(true);
    const [DeleteNote, setDeleteNote] = useState(true);
    const [NoteDeleted, setNoteDeleted] = useState(true);

    //AddNotesView:
    function Otsikko() {
        return (
            <div class="otsikko">
                <h2>Add new notes for course</h2>
            </div>
        );
    }

    function Valikko() {
        return (
            <label id="valikko">
                Course:
                <select id="kurssit" onChange={Piilota}>
                    {options.map((option, index) => {
                        return <option key={index} >
                            {option.name}
                        </option>
                    })}
                </select>
            </label>
        )
    }

    function Tekstikentta() {
        return (
            <div class="tekstikentta">
                <textarea id="postContent" rows={4} cols={40} />
            </div>
        );
    }

    function Piilota() {
        setNoteAdded(true);
    }

    function LisaaMuistiinpano() {
        let course = document.getElementById('kurssit').value;
        let note = document.getElementById('postContent').value;
        setNoteAdded(true);
        if (note != "") {
            notes.push(note);
            setNoteAdded(false);
        }
        document.getElementById('postContent').value = "";
    }

    function ShowAddNotesView() {
        setIsShownMain(false);
        setIsShown1(false);
    };

    function HideAddNotesView() {
        setIsShownMain(true);
        setIsShown1(true);
        setNoteAdded(true);
    }

    //ListNotesView:
    const options = [{ "id": 0, "name": "Versionhallinta" },
    { "id": 1, "name": "Java" },
    { "id": 2, "name": "Ruotsi" },
    { "id": 3, "name": "Ohjelmointi 1" }
    ];

    const notes = [{ "id": 0, "text": "add lisää", "course": { "id": 0, "name": "Versionhallinta" }, "timestamp": "2022-11-23T13:13:13" },
    { "id": 1, "text": "commit tallentaa", "course": { "id": 0, "name": "Versionhallinta" }, "timestamp": "2022-11-23T13:33:13" },
    { "id": 2, "text": "push työntää muutokset remoteen", "course": { "id": 0, "name": "Versionhallinta" }, "timestamp": "2022-11-24T13:13:13" },
    { "id": 3, "text": "talar du svenska", "course": { "id": 2, "name": "Ruotsi" }, "timestamp": "2022-11-22T08:23:12" }
    ];

    function Kurssivalikko() {
        const [course, setCourse] = useState("");
        const [text, setText] = useState("");

        function getAllNotes() {
            let allNotes = "";
            for (let i = 0; i < notes.length; i++) {
                allNotes = allNotes + notes[i].text + ", ";
            }
            if (allNotes == "") {
                setNoNotes(false);
            } else {
                setNotes(false);
                setIsShownNotes(false);
            }
            return (allNotes);
        }

        function getFilteredNotes(course) {
            let filter = course;
            let filteredNotes = "";
            for (let i = 0; i < notes.length; i++) {
                if (notes[i].course.name == filter) {
                    filteredNotes = filteredNotes + notes[i].text + ", ";
                }
            }
            if (filteredNotes == "") {
                setNoNotes(false);
            } else {
                setNotes(false);
                setIsShownNotes(false);
            }

            return (filteredNotes);
        }

        function NaytaMuistiinpanot(event) {
            let course = event.target.value;
            let filteredNotes = "";
            setDeleteNote(true);
            setDeleteCourse(true);
            setNoteDeleted(true);
            setCourseDeleted(true);
            setIsShownNotes(true);
            setNoNotes(true);
            setNotes(true);
            setText("");
            setCourse("");
            if (course == "All") {
                allNotes = getAllNotes();
                setCourse(course);
                setText(allNotes);
            } else if (course != "All") {
                if (notes.length != 0) {
                    for (let i = 0; i < options.length; i++) {
                        if (course == options[i].name) {
                            filteredNotes = getFilteredNotes(course);
                            setCourse(course);
                            setText(filteredNotes);
                        }
                    }
                } else if (notes.length == 0) {
                    setNoNotes(false);
                }
            }
        }

        function PoistetaankoNote() {
            setDeleteNote(false);
        }

        function PoistetaankoKurssi() {
            setDeleteCourse(false);
        }

        function getTimestamp(course) {
            let kurssi = course;
            let timeStamp = "";
            for (let i = 0; i < notes.length; i++) {
                if (notes[i].course.name == kurssi) {
                    timeStamp = timeStamp + notes[i].timestamp;
                    break;
                }
            }
            return timeStamp;
        }

        function getId(course) {
            let kurssi = course;
            let Id = "";
            for (let i = 0; i < notes.length; i++) {
                if (notes[i].course.name == kurssi) {
                    Id = Id + notes[i].id;
                    break;
                }
            }
            return Id;
        }

        return (
            <div class="kurssivalikko">
                <div style={{ display: DeleteNote ? 'none' : 'block' }}>
                    <h2>Delete this note?</h2>
                    <button id="poistaNote" onClick={PoistaNote}>Delete note</button>
                </div>
                <h2 style={{ display: NoteDeleted ? 'none' : 'block' }}>Note deleted!</h2>
                <div style={{ display: DeleteCourse ? 'none' : 'block' }}>
                    <h2>Delete this course?</h2>
                    <button id="poistaKurssi" onClick={PoistaKurssi}>Delete course</button>
                </div>
                <h2 style={{ display: CourseDeleted ? 'none' : 'block' }}>Course deleted!</h2>
                <h2>Select course</h2>
                <label>
                    Course:
                    <select id="kurssit" onChange={NaytaMuistiinpanot}>
                        <option>All</option>
                        {options.map((option, index) => {
                            return <option key={index} >
                                {option.name}
                            </option>
                        })}
                    </select>
                    <button id="ListNotesViewtakaisin" onClick={HideListNotesView} style={{ opacity: isShown4 ? '0' : '100' }}>Back</button>
                </label>
                <h2 style={{ display: Notes ? 'none' : 'block' }}>Muistiinpanot:</h2>
                <h2 style={{ display: NoNotes ? 'none' : 'block' }}>Ei muistiinpanoja!</h2>
                <div class="muistiinpanot" style={{ opacity: isShownNotes ? '0' : '100' }}>
                    <p>{"(Timestamp: " + getTimestamp(course) + "), "}{"(Course: " + course + "), "}{"(id: " + getId(course) + ")"}</p>
                    <div>
                        <button id="nappi" onClick={PoistetaankoKurssi}>{course + " note:"}</button>
                        <button id="nappi" onClick={PoistetaankoNote}>{text}</button>
                    </div>
                </div>
            </div>
        );
    }

    function ShowListNotesView() {
        if (options.length == 0) {
            setNoNotes(false);
        }
        setIsShownMain(false);
        setIsShown2(false);
        setIsShown4(false);
    }

    function HideListNotesView() {
        setIsShownMain(true);
        setIsShown2(true);
        setIsShown1(true);
        setIsShown4(true);
        setIsShownNotes(true);
        setNoNotes(true);
        setNotes(true);
        setDeleteCourse(true);
        setCourseDeleted(true);
        setDeleteNote(true);
        setNoteDeleted(true);
    }

    function PoistaNote() {
        setDeleteNote(true);
        setNoteDeleted(false);
        let poistettava = document.getElementById('kurssit').value;
        if (poistettava != "") {
            for (let i = 0; i < notes.length; i++) {
                if (poistettava == notes[i].text) {
                    options.splice(i, 1);
                }
            }
        }
    }

    function PoistaKurssi() {
        setDeleteCourse(true);
        setCourseDeleted(false);
        let poistettava = document.getElementById('kurssit').value;
        if (poistettava != "") {
            for (let i = 0; i < options.length; i++) {
                if (poistettava == options[i].name) {
                    options.splice(i, 1);
                }
            }
        }
        document.getElementById('lisaaKurssi').value = "";
    }

    //AddCoursesView:
    function LisaaOtsikko() {
        return (
            <h2>Add course</h2>
        );
    }

    function LisaaKurssi() {
        return (
            <div class="lisaa">
                <textarea id="lisaaKurssi" rows={4} cols={40} />
            </div>
        );
    }

    function KurssiNapit() {
        return (
            <div class="kurssinapit">
                <button id="lisaa" onClick={TallennaKurssi}>Add</button>
                <button id="palaa" onClick={HideAddCoursesView}>Back</button>
            </div>
        );
    }

    function ShowAddCoursesView() {
        setIsShownMain(false);
        setIsShown3(false);
    };

    function HideAddCoursesView() {
        setIsShownMain(true);
        setIsShown3(true);
        setCourseAdded(true);
    }

    function TallennaKurssi() {
        let kurssi = document.getElementById('lisaaKurssi').value;
        setCourseAdded(true);
        setCourseAdded(true);
        if (kurssi != "") {
            kurssi = { "id": 5, "name": document.getElementById('lisaaKurssi').value };
            options.push(kurssi);
            setCourseAdded(false);
        }
        document.getElementById('lisaaKurssi').value = "";
    }

    return (
        <div class="mainContainer">
            <div class="aloitusnapit" style={{ display: isShownMain ? 'block' : 'none' }}>
                <div class="createButton">
                    <button onClick={ShowAddNotesView}>Create notes for class</button>
                </div>,
                <div class="listButton">
                    <button onClick={ShowListNotesView}>List notes</button>
                </div>,
                <div class="addButton">
                    <button onClick={ShowAddCoursesView}>Add courses</button>
                </div>
            </div>
            <div class="listnotesview" style={{ display: isShown2 ? 'none' : 'block' }}>
                <Kurssivalikko />
            </div>
            <div class="addnotesview" style={{ display: isShown1 ? 'none' : 'block' }}>
                <div class="container">
                    <h2 style={{ display: NoteAdded ? 'none' : 'block' }}>Note added!</h2>
                    <Otsikko />
                    <Valikko />
                    <Tekstikentta />
                    <div class="napit">
                        <button id="tallenna" onClick={LisaaMuistiinpano}>Save</button>
                        <button id="takaisin" onClick={HideAddNotesView}>Back</button>
                    </div>
                </div>
            </div>
            <div class="kurssilisays" style={{ display: isShown3 ? 'none' : 'block' }}>
                <h2 style={{ display: CourseAdded ? 'none' : 'block' }}>Course added!</h2>
                <LisaaOtsikko />
                <LisaaKurssi />
                <KurssiNapit />
            </div>
        </div>
    );
}

export default MainView;